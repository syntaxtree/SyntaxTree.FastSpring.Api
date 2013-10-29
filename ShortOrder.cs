using System;
using System.Xml.Serialization;

namespace SyntaxTree.FastSpring.Api
{
	[XmlRoot(ElementName = "order", IsNullable = false, Namespace = "")]
	public class ShortOrder
	{
		[XmlElement("reference")]
		public string Reference { get; set; }

		[XmlElement("status")]
		public Status Status { get; set; }

		[XmlElement("statusChanged")]
		public DateTime StatusChanged { get; set; }
	
		[XmlElement("test")]
		public bool IsTest { get; set; }

		[XmlElement("returnStatus")]
		public ReturnStatus ReturnStatus { get; set; }

		[XmlElement("customer")]
		public Contact Customer { get; set; }
	}
}