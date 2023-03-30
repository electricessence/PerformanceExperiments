using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.XPath;

namespace PerformanceExperiments;

public static class XmlDocumentExtensions
{
	public static IEnumerable<XmlNode> GetDescendants(this XmlNode node, bool includeSelf = false)
	{
		XmlNode? current = node;

		if (includeSelf)
		{
			yield return current;
		}

		current = NextNode(current);

		while (current != null)
		{
			yield return current;
			current = NextNode(current);
		}
	}

	private static XmlNode? NextNode(XmlNode? node)
	{
		if (node!.HasChildNodes)
		{
			return node.FirstChild;
		}

		while (node is not null && node.NextSibling == null)
		{
			node = node.ParentNode;
		}

		return node?.NextSibling;
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
}

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
