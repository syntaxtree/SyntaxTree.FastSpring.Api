using System.Xml.Serialization;

namespace SyntaxTree.FastSpring.Api
{
	[XmlRoot("orders")]
	public class OrderSearchResult
	{
		[XmlElement("order")]
		public ShortOrder[] Items { get; set; }
	}
}
