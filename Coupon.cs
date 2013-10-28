using System.Xml.Serialization;

namespace SyntaxTree.FastSpring.Api
{
	[XmlRoot(ElementName = "couponCode", IsNullable = false, Namespace = "")]
	public sealed class Coupon
	{
		[XmlElement("code")]
		public string Code { get; set; }
	}
}