using System.Xml;
using Xunit;

namespace PerformanceExperiments.Tests;

public class XmlElementExtensionsTests
{
	// Arrange
	const string sourceXml = @"
            <root>
                <item a='x'>
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

	readonly XmlDocument sourceDoc;
	readonly XmlElement sourceNode;

	const string destXml = "<root><newitem a='y'/></root>";
	readonly XmlDocument innerXmlDoc;
	readonly XmlElement innerXmlNode;

	public XmlElementExtensionsTests()
	{
		sourceDoc = new();
		sourceDoc.LoadXml(sourceXml);
		sourceNode = (XmlElement)sourceDoc.SelectSingleNode("/root/item")!;

		innerXmlDoc = GetNewDestinationDoc();
		innerXmlNode = GetNewDestinationNode(innerXmlDoc);
		innerXmlNode.InnerXml = sourceNode.InnerXml;
	}

	static XmlDocument GetNewDestinationDoc()
	{
		XmlDocument destDoc = new();
		destDoc.LoadXml(destXml);
		return destDoc;
	}

	static XmlElement GetNewDestinationNode(XmlDocument destDoc)
		=> (XmlElement)destDoc.SelectSingleNode("/root/newitem")!;

	[Fact]
	public void TestReplaceContents()
	{
		XmlDocument destDoc = GetNewDestinationDoc();
		XmlElement destNode = GetNewDestinationNode(destDoc);

		// Act
		destNode.ReplaceContents(sourceNode);

		// Assert
		Assert.Equal(innerXmlDoc.OuterXml, destDoc.OuterXml);
	}

	[Fact]
	public void TestReplaceContentsNonRecursive()
	{
		XmlDocument destDoc = GetNewDestinationDoc();
		XmlElement destNode = GetNewDestinationNode(destDoc);

		// Act
		destNode.ReplaceContentsNonRecursive(sourceNode);

		// Assert
		Assert.Equal(innerXmlDoc.OuterXml, destDoc.OuterXml);
	}
}
