using System;
using System.Xml.Serialization;

namespace SyntaxTree.FastSpring.Api
{
	[XmlRoot(ElementName = "order", IsNullable = false, Namespace = "")]
	public sealed class Order
	{
		[XmlElement("reference")]
		public string Reference { get; set; }

		[XmlElement("status")]
		public Status Status { get; set; }

		[XmlElement("statusChanged")]
		public DateTime StatusChanged { get; set; }

		[XmlElement("test")]
		public bool IsTest { get; set; }

		[XmlElement("due")]
		public DateTime Due { get; set; }

		[XmlElement("currency")]
		public string Currency { get; set; }

		[XmlElement("referrer")]
		public string Referrer { get; set; }

		[XmlElement("originIp")]
		public string OriginIP{ get; set; }

		[XmlElement("total")]
		public double Total { get; set; }

		[XmlElement("tax")]
		public double Tax { get; set; }

		[XmlElement("shipping")]
		public double Shipping { get; set; }

		[XmlElement("sourceName")]
		public string SourceName { get; set; }

		[XmlElement("sourceKey")]
		public string SourceKey { get; set; }

		[XmlElement("sourceCampaign")]
		public string SourceCampaign { get; set; }

		[XmlElement("customer")]
		public Contact Customer { get; set; }

		[XmlElement("purchaser")]
		public Contact Purchaser { get; set; }

		[XmlElement("address")]
		public Address Address { get; set; }

		[XmlArray("orderItems")]
		[XmlArrayItem("orderItem")]
		public OrderItem[] Items { get; set; }

		[XmlArray("payments")]
		[XmlArrayItem("payment")]
		public Payment[] Payments { get; set; }
	}
}