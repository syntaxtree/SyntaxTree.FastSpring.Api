using System.Xml.Serialization;

namespace SyntaxTree.FastSpring.Api
{
	public sealed class Contact
	{
		[XmlElement("firstName")]
		public string FirstName { get; set; }

		[XmlElement("lastName")]
		public string LastName { get; set; }

		[XmlElement("company")]
		public string Company { get; set; }

		[XmlElement("email")]
		public string Email { get; set; }

		[XmlElement("phoneNumber")]
		public string PhoneNumber { get; set; }
	}
}