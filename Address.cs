using System.Xml.Serialization;

namespace SyntaxTree.FastSpring.Api
{
	public sealed class Address
	{
		[XmlElement("addressLine1")]
		public string FirstLine { get; set; }

		[XmlElement("addressLine2")]
		public string SecondLine { get; set; }

		[XmlElement("city")]
		public string City { get; set; }

		[XmlElement("region")]
		public string Region { get; set; }

		[XmlElement("regionCustom")]
		public string RegionCustom { get; set; }

		[XmlElement("postalCode")]
		public string PostalCode { get; set; }

		[XmlElement("country")]
		public string Country { get; set; }
	}
}