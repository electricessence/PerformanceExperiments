using BenchmarkDotNet.Attributes;
using CommunityToolkit.HighPerformance.Buffers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.XPath;

namespace PerformanceExperiments;

/*
|                  Method |      Mean |     Error |    StdDev | Ratio | RatioSD |   Gen0 | Allocated | Alloc Ratio |
|------------------------ |----------:|----------:|----------:|------:|--------:|-------:|----------:|------------:|
|          XPathTraversal | 21.722 us | 0.4197 us | 0.3721 us |  1.00 |    0.00 | 5.2795 |   11080 B |        1.00 |
|             NodeWalking |  9.133 us | 0.0330 us | 0.0293 us |  0.42 |    0.01 | 0.4120 |     880 B |        0.08 |
| XPathNavigatorTraversal | 20.854 us | 0.1341 us | 0.1188 us |  0.96 |    0.02 | 4.7913 |   10024 B |        0.90 |
*/

public static class XmlDocumentExtensions
{
	public class InterningXmlReader : XmlReader
	{
		private readonly XmlReader _innerReader;
		private readonly StringPool _stringPool;

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
			if (disposing) _innerReader.Dispose();
		}

		public InterningXmlReader(XmlReader innerReader, StringPool stringPool)
		{
			_innerReader = innerReader ?? throw new ArgumentNullException(nameof(innerReader));
			_stringPool = stringPool ?? throw new ArgumentNullException(nameof(stringPool));
		}

		public override string Value => _stringPool.GetOrAdd(_innerReader.Value);

		public override int AttributeCount => _innerReader.AttributeCount;

		public override string BaseURI => _innerReader.BaseURI;

		public override int Depth => _innerReader.Depth;

		public override bool EOF => _innerReader.EOF;

		public override bool IsEmptyElement => _innerReader.IsEmptyElement;

		public override string LocalName => _innerReader.LocalName;

		public override string NamespaceURI => _innerReader.NamespaceURI;

		public override XmlNameTable NameTable => _innerReader.NameTable;

		public override XmlNodeType NodeType => _innerReader.NodeType;

		public override string Prefix => _innerReader.Prefix;

		public override ReadState ReadState => _innerReader.ReadState;

		public override string GetAttribute(int i) => _stringPool.GetOrAdd(_innerReader.GetAttribute(i));

		public override string? GetAttribute(string name)
		{
			var value = _innerReader.GetAttribute(name);
			if (value is null) return null;
			return _stringPool.GetOrAdd(value);
		}

		public override string? GetAttribute(string name, string? namespaceURI) => _innerReader.GetAttribute(name, namespaceURI);

		public override string? LookupNamespace(string prefix) => _innerReader.LookupNamespace(prefix);

		public override bool MoveToAttribute(string name) => _innerReader.MoveToAttribute(name);

		public override bool MoveToAttribute(string name, string? ns) => _innerReader.MoveToAttribute(name, ns);

		public override bool MoveToElement() => _innerReader.MoveToElement();

		public override bool MoveToFirstAttribute() => _innerReader.MoveToFirstAttribute();

		public override bool MoveToNextAttribute() => _innerReader.MoveToNextAttribute();

		public override bool Read() => _innerReader.Read();

		public override bool ReadAttributeValue() => _innerReader.ReadAttributeValue();

		public override void ResolveEntity() => _innerReader.ResolveEntity();
	}

	public static void LoadXmlWithPooling(this XmlDocument xmlDoc, string xmlContent, bool sharedPool = false)
	{
		if (xmlDoc == null)
			throw new ArgumentNullException(nameof(xmlDoc));
		if (xmlContent == null)
			throw new ArgumentNullException(nameof(xmlContent));

		var settings = new XmlReaderSettings { NameTable = xmlDoc.NameTable };

		using var reader = new InterningXmlReader(
			XmlReader.Create(new StringReader(xmlContent), settings),
			sharedPool ? StringPool.Shared : new());

		xmlDoc.Load(reader);
	}

	public static IEnumerable<XmlNode> GetDescendants(this XmlNode node, bool includeSelf = false)
	{
		if (includeSelf) yield return node;

		XmlNode? current = node.FirstChild;
		if (current is null) yield break;

		start: // Using a label to avoid unnecessary while condition check.
		yield return current;

		var next = current.FirstChild ?? current.NextSibling;
		if (next is null)
		{
		findNext: // Again, using a label avoids an unnecessary null check.
			var parent = current!.ParentNode!;
			// 'parent' should never be null as we should have come full circle.
			// Unless the tree was modified, but that would cause more than just a null reference problem.
			Debug.Assert(parent is not null);
			if (parent == node)
				yield break;

			next = parent.NextSibling;
			if (next is null)
			{
				current = parent;
				goto findNext;
			}
		}

		current = next;
		goto start;
	}

	public static IEnumerable<XmlElement> GetMatchingDescendants(
		this XmlNode node,
		string nodeName,
		string childName,
		string childValue,
		bool includeSelf = false)
	{
		foreach (var n in node.GetDescendants(includeSelf))
		{
			if (n.Name == nodeName
				&& n.NodeType == XmlNodeType.Element
				&& n[childName]?.FirstChild?.Value == childValue)
			{
				yield return (XmlElement)n;
			}
		}
	}

	public static IEnumerable<XmlElement> GetMatchingDescendantsLinq(
		this XmlNode node,
		string nodeName,
		string childName,
		string childValue,
		bool includeSelf = false)
		=> node.GetDescendants(includeSelf)
			.Where(n
				=> n.Name == nodeName
				&& n.NodeType == XmlNodeType.Element
				&& n[childName]?.FirstChild?.Value == childValue)
			.Cast<XmlElement>();

	public static ParallelQuery<XmlElement> GetMatchingDescendantsInParallel(
		this XmlNode node,
		string nodeName,
		string childName,
		string childValue,
		bool includeSelf = false)
		=> node.GetDescendants(includeSelf)
			.AsParallel()
			.Where(n
				=> n.Name == nodeName
				&& n.NodeType == XmlNodeType.Element
				&& n[childName]?.FirstChild?.Value == childValue)
			.Cast<XmlElement>();

	public static IEnumerable<XmlNode> GetChildren(this XmlNode node)
	{
		XmlNode? childNode = node.FirstChild;
		while (childNode is not null)
		{
			yield return childNode;
			childNode = childNode.NextSibling;
		}
	}

	public static void RemoveAllChildren(this XmlNode node)
	{
		XmlNode? childNode = node.LastChild;
		while (childNode is not null)
		{
			var prev = childNode.PreviousSibling;
			node.RemoveChild(childNode);
			childNode = prev;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static IEnumerable<XmlNode> GetChildrenAggressiveInlining(this XmlNode node)
	{
		XmlNode? childNode = node.FirstChild;
		while (childNode is not null)
		{
			yield return childNode;
			childNode = childNode.NextSibling;
		}
	}

	public static void ImportContents(this XmlElement target, XmlElement source)
	{
		if (target is null)
			throw new ArgumentNullException(nameof(target));

		if (source is null)
			throw new ArgumentNullException(nameof(source));

		if (target.OwnerDocument is null)
			throw new ArgumentException("Doesn't belong to an XmlDocument.", nameof(target));

		CopyNodeContents(source, target);
	}

	public static void ReplaceContents(this XmlElement target, XmlElement source)
	{
		if (target is null)
			throw new ArgumentNullException(nameof(target));

		if (source is null)
			throw new ArgumentNullException(nameof(source));

		if (target.OwnerDocument is null)
			throw new ArgumentException("Doesn't belong to an XmlDocument.", nameof(target));

		target.RemoveAllChildren();
		CopyNodeContents(source, target);
	}

	private static void CopyAttributes(XmlElement sourceElement, XmlElement destElement)
	{
		foreach (XmlAttribute attr in sourceElement.Attributes)
		{
			XmlAttribute copiedAttr = destElement.OwnerDocument.CreateAttribute(attr.Prefix, attr.LocalName, attr.NamespaceURI);
			copiedAttr.Value = attr.Value;
			destElement.Attributes.Append(copiedAttr);
		}
	}

	private static XmlNode CopyNode(XmlNode sourceNode, XmlDocument destDoc)
	{
		switch (sourceNode)
		{
			case XmlElement sourceElement:
				XmlElement destElement = destDoc.CreateElement(sourceNode.Prefix, sourceNode.LocalName, sourceNode.NamespaceURI);
				CopyAttributes(sourceElement, destElement);
				return destElement;

			case XmlText sourceText:
				return destDoc.CreateTextNode(sourceText.Value);

			case XmlComment sourceComment:
				return destDoc.CreateComment(sourceComment.Value);

			case XmlCDataSection sourceCData:
				return destDoc.CreateCDataSection(sourceCData.Value);

			case XmlProcessingInstruction sourcePI:
				return destDoc.CreateProcessingInstruction(sourcePI.Target, sourcePI.Data);

			case XmlEntityReference sourceEntityRef:
				return destDoc.CreateEntityReference(sourceEntityRef.Name);

			default:
				return destDoc.CreateNode(sourceNode.NodeType, sourceNode.Name, sourceNode.NamespaceURI);
		}
	}

	private static void CopyNodeContents(XmlNode sourceNode, XmlNode destNode)
	{
		XmlDocument destDoc = destNode.OwnerDocument!;

		foreach (XmlNode childNode in sourceNode.GetChildren())
		{
			XmlNode copiedNode = CopyNode(childNode, destDoc);
			destNode.AppendChild(copiedNode);
			CopyNodeContents(childNode, copiedNode);
		}
	}

	public static void ReplaceContentsNonRecursive(this XmlElement target, XmlElement source)
	{
		if (target is null)
			throw new ArgumentNullException(nameof(target));

		if (source is null)
			throw new ArgumentNullException(nameof(source));

		if (target.OwnerDocument is null)
			throw new ArgumentException("Doesn't belong to an XmlDocument.", nameof(target));

		target.RemoveAllChildren();
		CopyNodeContentsNonRecursive(source, target);
	}

	private static void CopyNodeContentsNonRecursive(XmlNode sourceNode, XmlNode destNode)
	{
		XmlNode? current = sourceNode.FirstChild;
		if (current is null) return;
		XmlDocument destDoc = destNode.OwnerDocument!;
		XmlNode? currentDestParent = destNode;

	start:
		var currentCopy = CopyNode(current, destDoc);
		currentDestParent.AppendChild(currentCopy);

		var next = current.FirstChild;
		if (next is not null)
		{
			current = next;
			currentDestParent = currentCopy;
			goto start;
		}

		next = current.NextSibling;
		if (next is not null)
		{
			current = next;
			goto start;
		}

	findNext:
		var parent = current.ParentNode!;
		if (parent == sourceNode) return;
		currentDestParent = currentDestParent.ParentNode!;
		next = parent.NextSibling;
		if (next is null)
		{
			current = parent;
			goto findNext;
		}

		current = next;
		goto start;
	}
}

/*
|                Method |     Mean |    Error |   StdDev | Ratio | RatioSD |   Gen0 | Allocated | Alloc Ratio |
|---------------------- |---------:|---------:|---------:|------:|--------:|-------:|----------:|------------:|
|            ChildNodes | 89.78 ns | 0.898 ns | 0.796 ns |  1.00 |    0.00 | 0.0305 |      64 B |        1.00 |
|           NextSibling | 77.25 ns | 1.163 ns | 1.088 ns |  0.86 |    0.02 | 0.0267 |      56 B |        0.88 |
| NextSiblingAggressive | 76.15 ns | 1.240 ns | 1.612 ns |  0.85 |    0.02 | 0.0267 |      56 B |        0.88 |
*/

[MemoryDiagnoser]
public class XmlDocumentTraversalBenchmarks
{
	private XmlDocument? _xmlDocument;
	private XmlNode? _rootNode;
	private XPathNavigator? _navigator;

	[GlobalSetup]
	public void Setup()
	{
		// Load your XML content into XmlDocument
		_xmlDocument = new XmlDocument();
		_xmlDocument.LoadXml(XML);

		// Set the root node
		_rootNode = _xmlDocument.DocumentElement;
		_navigator = _xmlDocument.CreateNavigator();
	}

	[Benchmark(Baseline = true)]
	public List<XmlElement> XPathTraversal()
	{
		var results = new List<XmlElement>();
		foreach (var (nodeName, childName, childValue) in TestParameters)
		{
			var xpath = $"//{nodeName}[{childName}='{childValue}']";
			var matchedNodes = _rootNode!.SelectNodes(xpath)!.Cast<XmlElement>();
			results.AddRange(matchedNodes);
		}
		return results;
	}

	[Benchmark]
	public List<XmlElement> NodeWalking()
	{
		var results = new List<XmlElement>();
		foreach (var (nodeName, childName, childValue) in TestParameters)
		{
			var matchedNodes = _rootNode!.GetMatchingDescendants(nodeName, childName, childValue);
			results.AddRange(matchedNodes);
		}
		return results;
	}

	[Benchmark]
	public List<XmlElement> XPathNavigatorTraversal()
	{
		var results = new List<XmlElement>();
		foreach (var (nodeName, childName, childValue) in TestParameters)
		{
			var xpath = $"//{nodeName}[{childName}='{childValue}']";
			var iterator = _navigator!.Select(xpath);

			while (iterator.MoveNext())
			{
				var element = (XmlElement)iterator.Current!.UnderlyingObject!;
				results.Add(element);
			}
		}
		return results;
	}

	//[Benchmark]
	//public List<XmlElement> NodeWalkingLinq()
	//{
	//	var results = new List<XmlElement>();
	//	foreach (var (nodeName, childName, childValue) in TestParameters)
	//	{
	//		var matchedNodes = _rootNode!.GetMatchingDescendantsLinq(nodeName, childName, childValue);
	//		results.AddRange(matchedNodes);
	//	}
	//	return results;
	//}

	//[Benchmark]
	//public List<XmlElement> NodeWalkingInParallel()
	//{
	//	var results = new List<XmlElement>();
	//	foreach (var (nodeName, childName, childValue) in TestParameters)
	//	{
	//		var matchedNodes = _rootNode!.GetMatchingDescendantsInParallel(nodeName, childName, childValue);
	//		results.AddRange(matchedNodes);
	//	}
	//	return results;
	//}

	private static readonly (string, string, string)[] TestParameters = new[]
	{
		("department", "name", "HR"),
		("department", "name", "IT"),
		("employee", "city", "New York"),
		("employee", "age", "28"),
	};

	private const string XML =
	"""
	<root>
		<company>
		<name>Acme Corp</name>
		<location>New York</location>
		<departments>
			<department>
			<name>HR</name>
			<employees>
				<employee>
				<name>John Doe</name>
				<age>30</age>
				<city>New York</city>
				</employee>
				<employee>
				<name>Jane Smith</name>
				<age>32</age>
				<city>New York</city>
				</employee>
			</employees>
			</department>
			<department>
			<name>IT</name>
			<employees>
				<employee>
				<name>James Brown</name>
				<age>28</age>
				<city>Los Angeles</city>
				</employee>
				<employee>
				<name>Michael Scott</name>
				<age>25</age>
				<city>New York</city>
				</employee>
			</employees>
			</department>
		</departments>
		</company>
		<company>
		<name>Global Tech</name>
		<location>San Francisco</location>
		<departments>
			<department>
			<name>Marketing</name>
			<employees>
				<employee>
				<name>Laura Johnson</name>
				<age>29</age>
				<city>San Francisco</city>
				</employee>
				<employee>
				<name>David Johnson</name>
				<age>35</age>
				<city>San Francisco</city>
				</employee>
			</employees>
			</department>
			<department>
			<name>Finance</name>
			<employees>
				<employee>
				<name>Amy Williams</name>
				<age>33</age>
				<city>San Francisco</city>
				</employee>
				<employee>
				<name>Emma Brown</name>
				<age>27</age>
				<city>San Francisco</city>
				</employee>
			</employees>
			</department>
		</departments>
		</company>
	</root>
	""";
}

[MemoryDiagnoser]
public class XmlChildNodesBenchmark
{
	private XmlDocument? _xmlDocument;
	private XmlNode? _parentNode;

	[GlobalSetup]
	public void Setup()
	{
		_xmlDocument = new XmlDocument();
		_xmlDocument.LoadXml("<root><item/><item/><item/><item/><item/></root>");
		_parentNode = _xmlDocument.DocumentElement;
	}

	[Benchmark(Baseline = true)]
	public string ChildNodes()
	{
		var name = string.Empty;
		foreach (XmlNode childNode in _parentNode!.ChildNodes)
		{
			name = childNode.Name;
		}
		return name;
	}

	[Benchmark]
	public string NextSibling()
	{
		var name = string.Empty;
		foreach (XmlNode childNode in _parentNode!.GetChildren())
		{
			name = childNode.Name;
		}
		return name;
	}

	[Benchmark]
	public string NextSiblingAggressive()
	{
		var name = string.Empty;
		foreach (XmlNode childNode in _parentNode!.GetChildrenAggressiveInlining())
		{
			name = childNode.Name;
		}
		return name;
	}

	//[Benchmark]
	//public string NextSiblingToArray()
	//{
	//	var name = string.Empty;
	//	foreach (XmlNode childNode in _parentNode!.GetChildren().ToArray())
	//	{
	//		name = childNode.Name;
	//	}
	//	return name;
	//}
}

/* Small XML
|                      Method |     Mean |     Error |    StdDev | Ratio | RatioSD |   Gen0 | Allocated | Alloc Ratio |
|---------------------------- |---------:|----------:|----------:|------:|--------:|-------:|----------:|------------:|
|                    InnerXml | 5.806 us | 0.1098 us | 0.1221 us |  1.00 |    0.00 | 3.6621 |   7.48 KB |        1.00 |
|             ReplaceContents | 3.917 us | 0.0432 us | 0.0361 us |  0.67 |    0.01 | 1.0300 |   2.12 KB |        0.28 |
| ReplaceContentsNonRecursive | 3.350 us | 0.0573 us | 0.0508 us |  0.57 |    0.02 | 0.6332 |    1.3 KB |        0.17 |
*/

/* Large XML
|                      Method |     Mean |     Error |    StdDev | Ratio | RatioSD |   Gen0 | Allocated | Alloc Ratio |
|---------------------------- |---------:|----------:|----------:|------:|--------:|-------:|----------:|------------:|
|                    InnerXml | 9.365 us | 0.1870 us | 0.2365 us |  1.00 |    0.00 | 4.5471 |   9.29 KB |        1.00 |
|             ReplaceContents | 7.069 us | 0.1303 us | 0.1218 us |  0.75 |    0.02 | 1.8387 |   3.76 KB |        0.40 |
| ReplaceContentsNonRecursive | 6.250 us | 0.1130 us | 0.1387 us |  0.67 |    0.02 | 1.3046 |   2.66 KB |        0.29 |
*/

[MemoryDiagnoser]
public class XmlCopyBenchmark
{
	private readonly XmlDocument sourceDoc;
	private readonly XmlDocument destDoc;
	private readonly XmlElement sourceNode;
	private readonly XmlElement destNode;

	public const string SourceXml = """
	<root>
		<items>
		<item id="1">
		    <properties>
		    <property key="name">Item 1</property>
		    <property key="description">This is the first item</property>
		    <property key="color">Red</property>
		    <property key="size">Medium</property>
		    </properties>
		    <categories>
		    <category id="A">
		        <subcategory id="A1">
		        <subsubcategory id="A1a"/>
		        <subsubcategory id="A1b"/>
		        <subsubcategory id="A1c"/>
		        </subcategory>
		        <subcategory id="A2"/>
		        <subcategory id="A3"/>
		    </category>
		    <category id="B"/>
		    </categories>
		    <relatedItems>
		    <itemRef id="2"/>
		    <itemRef id="3"/>
		    </relatedItems>
		</item>
		<item id="2">
		    <properties>
		    <property key="name">Item 2</property>
		    <property key="description">This is the second item</property>
		    <property key="color">Blue</property>
		    <property key="size">Large</property>
		    </properties>
		    <categories>
		    <category id="A">
		        <subcategory id="A1">
		        <subsubcategory id="A1a"/>
		        <subsubcategory id="A1b"/>
		        </subcategory>
		        <subcategory id="A2"/>
		    </category>
		    <category id="C"/>
		    </categories>
		    <relatedItems>
		    <itemRef id="1"/>
		    <itemRef id="3"/>
		    </relatedItems>
		</item>
		<item id="new"/>
		<item id="3">
		    <properties>
		    <property key="name">Item 3</property>
		    <property key="description">This is the third item</property>
		    <property key="color">Green</property>
		    <property key="size">Small</property>
		    </properties>
		    <categories>
		    <category id="B">
		        <subcategory id="B1">
		        <subsubcategory id="B1a"/>
		        </subcategory>
		        <subcategory id="B2"/>
		    </category>
		    <category id="C"/>
		    </categories>
		    <relatedItems>
		    <itemRef id="1"/>
		    <itemRef id="2"/>
		    </relatedItems>
		</item>
		</items>
	</root>
	""";

	public XmlCopyBenchmark()
	{
		sourceDoc = new XmlDocument();


		sourceDoc.LoadXml(SourceXml);
		sourceNode = (XmlElement)sourceDoc.SelectSingleNode("/root/items/item[@id='2']")!;

		destDoc = new XmlDocument();
		destDoc.LoadXml(SourceXml);
		destNode = (XmlElement)destDoc.SelectSingleNode("/root/items/item[@id='new']")!;
	}

	[Benchmark(Baseline = true)]
	public void InnerXml() => destNode.InnerXml = sourceNode.InnerXml;

	[Benchmark]
	public void ReplaceContents() => destNode.ReplaceContents(sourceNode);

	[Benchmark]
	public void ReplaceContentsNonRecursive() => destNode.ReplaceContentsNonRecursive(sourceNode);

}

[MemoryDiagnoser]
[SuppressMessage("Performance", "CA1822:Mark members as static")]
public class XmlLoadBenchmark
{

	[Benchmark(Baseline = true)]
	public void LoadXml()
	{
		var xmlDoc = new XmlDocument();
		xmlDoc.LoadXml(XmlCopyBenchmark.SourceXml);
	}

	[Benchmark]
	public void LoadXmlWithPooling()
	{
		var xmlDoc = new XmlDocument();
		xmlDoc.LoadXmlWithPooling(XmlCopyBenchmark.SourceXml);
	}

	[Benchmark]
	public void LoadXmlWithPoolingShared()
	{
		var xmlDoc = new XmlDocument();
		xmlDoc.LoadXmlWithPooling(XmlCopyBenchmark.SourceXml, true);
	}
}