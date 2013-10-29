using System.Xml.Serialization;

namespace SyntaxTree.FastSpring.Api
{
	public enum ReturnStatus
	{
		[XmlEnum("none")]
		None,

		[XmlEnum("partial")]
		Partial,

		[XmlEnum("full")]
		Full,
	}
}