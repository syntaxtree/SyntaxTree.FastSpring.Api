using System.Xml.Serialization;

namespace SyntaxTree.FastSpring.Api
{
	public enum PaymentMethod
	{
		[XmlEnum("paypal")]
		Paypal,

		[XmlEnum("creditcard")]
		CreditCard,

		[XmlEnum("test")]
		Test,

		[XmlEnum("bank")]
		Bank,

		[XmlEnum("check")]
		Check,

		[XmlEnum("purchase-order")]
		PurchaseOrder,

		[XmlEnum("free")]
		Free,
	}
}