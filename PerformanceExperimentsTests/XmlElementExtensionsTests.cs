using System.Xml;
using Xunit;

namespace PerformanceExperiments.Tests;

public class XmlElementExtensionsTests
{
	[Fact]
	public void TestImportContents()
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

		const string destXml = "<root><newitem a='y'/></root>";

		XmlDocument sourceDoc = new();
		XmlDocument destDoc1 = new();
		XmlDocument destDoc2 = new();

		sourceDoc.LoadXml(sourceXml);
		destDoc1.LoadXml(destXml);
		destDoc2.LoadXml(destXml);

		XmlElement sourceNode = (XmlElement)sourceDoc.SelectSingleNode("/root/item")!;
		XmlElement destNode1 = (XmlElement)destDoc1.SelectSingleNode("/root/newitem")!;
		XmlElement destNode2 = (XmlElement)destDoc2.SelectSingleNode("/root/newitem")!;

		// Act
		destNode1.ReplaceContents(sourceNode);
		destNode2.InnerXml = sourceNode.InnerXml;

		// Assert
		Assert.Equal(destDoc1.OuterXml, destDoc2.OuterXml);
	}
}
