using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
	public static IEnumerable<XmlNode> GetDescendants(this XmlNode node, bool includeSelf = false)
	{
		if (includeSelf) yield return node;

		XmlNode? current = node.FirstChild;
		if(current is null) yield break;

	start: // Using a label to avoid unnecessary while condition check.
		yield return current;

		var next = current.FirstChild ?? current.NextSibling;
		if(next is null)
		{
		findNext: // Again, using a label avoids an unnecessary null check.
			var parent = current!.ParentNode!;
			// 'parent' should never be null as we should have come full circle.
			// Unless the tree was modified, but that would cause more than just a null reference problem.
			Debug.Assert(parent is not null);
			if(parent == node)
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

	private static void CopyNodeContents(XmlNode sourceNode, XmlNode destNode)
	{
		XmlDocument destDoc = destNode.OwnerDocument!;

		foreach (XmlNode childNode in sourceNode.GetChildren())
		{
			XmlNode? copiedNode = null;

			switch (childNode)
			{
				case XmlElement sourceElement:
					XmlElement destElement = destDoc.CreateElement(childNode.Prefix, childNode.LocalName, childNode.NamespaceURI);
					foreach (XmlAttribute attr in sourceElement.Attributes)
					{
						XmlAttribute copiedAttr = destDoc.CreateAttribute(attr.Prefix, attr.LocalName, attr.NamespaceURI);
						copiedAttr.Value = attr.Value;
						destElement.Attributes.Append(copiedAttr);
					}
					copiedNode = destElement;
					break;

				case XmlText sourceText:
					copiedNode = destDoc.CreateTextNode(sourceText.Value);
					break;

				case XmlComment sourceComment:
					copiedNode = destDoc.CreateComment(sourceComment.Value);
					break;

				case XmlCDataSection sourceCData:
					copiedNode = destDoc.CreateCDataSection(sourceCData.Value);
					break;

				case XmlProcessingInstruction sourcePI:
					copiedNode = destDoc.CreateProcessingInstruction(sourcePI.Target, sourcePI.Data);
					break;

				case XmlEntityReference sourceEntityRef:
					copiedNode = destDoc.CreateEntityReference(sourceEntityRef.Name);
					break;
			}

			if (copiedNode is null)
				continue;

			destNode.AppendChild(copiedNode);
			CopyNodeContents(childNode, copiedNode);
		}
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

[MemoryDiagnoser]
public class XmlCopyBenchmark
{
	private readonly XmlDocument sourceDoc;
	private readonly XmlDocument destDoc;
	private readonly XmlElement sourceNode;
	private readonly XmlElement destNode;

	public XmlCopyBenchmark()
	{
		sourceDoc = new XmlDocument();

		const string sourceXml = @"
            <root>
                <item>
                    <subitem attr='value'>
                        <child attr1='val1' attr2='val2'>
                            <grandchild>Text content</grandchild>
                            <grandchild attr3='val3'>
                                <greatgrandchild>More text</greatgrandchild>
                            </grandchild>
                        </child>
                        <child>
                            <grandchild>Another text node</grandchild>
                        </child>
                    </subitem>
                    <subitem>
                        <child>
                            <grandchild>One more text node</grandchild>
                        </child>
                    </subitem>
                </item>
            </root>";
		sourceDoc.LoadXml(sourceXml);
		sourceNode = (XmlElement)sourceDoc.SelectSingleNode("/root/item")!;

		destDoc = new XmlDocument();
		const string destXml = "<root><newitem/></root>";
		destDoc.LoadXml(destXml);
		destNode = (XmlElement)destDoc.SelectSingleNode("/root/newitem")!;
	}

	[Benchmark]
	public void ImportContents()
	{
		destNode.ReplaceContents(sourceNode);
	}

	[Benchmark(Baseline = true)]
	public void InnerXml()
	{
		destNode.InnerXml = sourceNode.InnerXml;
	}
}
