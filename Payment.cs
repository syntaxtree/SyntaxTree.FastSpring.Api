using System;
using System.Xml.Serialization;

namespace SyntaxTree.FastSpring.Api
{
	public sealed class Payment
	{
		[XmlElement("status")]
		public Status Status { get; set; }

		[XmlElement("statusChanged")]
		public DateTime StatusChanged { get; set; }

		[XmlElement("methodType")]
		public PaymentMethod Method { get; set; }

		[XmlElement("declinedReason")]
		public PaymentDeclinationReason DeclinationReason { get; set; }

		[XmlElement("currency")]
		public string Currency { get; set; }

		[XmlElement("total")]
		public double Total { get; set; }
	}
}