using System.Xml.Serialization;

namespace SyntaxTree.FastSpring.Api
{
	public enum Status
	{
		[XmlEnum("open")]
		Open,

		[XmlEnum("request")]
		Request,

		[XmlEnum("requested")]
		Requested,

		[XmlEnum("acceptance")]
		Acceptance,

		[XmlEnum("accepted")]
		Accepted,

		[XmlEnum("fulfillment")]
		Fulfillment,

		[XmlEnum("fulfilled")]
		Fulfilled,

		[XmlEnum("completion")]
		Completion,

		[XmlEnum("completed")]
		Completed,

		[XmlEnum("canceled")]
		Canceled,

		[XmlEnum("failed")]
		Failed,
	}
}