using System.Xml.Serialization;

namespace SyntaxTree.FastSpring.Api
{
	public sealed class OrderItem
	{
		[XmlElement("productDisplay")]
		public string ProductDisplay { get; set; }

		[XmlElement("productName")]
		public string ProductName { get; set; }

		[XmlElement("quantity")]
		public int Quantity { get; set; }

		[XmlElement("subscriptionReference")]
		public string SubscriptionReference { get; set; }
	}
}