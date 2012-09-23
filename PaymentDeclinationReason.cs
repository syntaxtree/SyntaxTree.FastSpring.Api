using System.Xml.Serialization;

namespace SyntaxTree.FastSpring.Api
{
	public enum PaymentDeclinationReason
	{
		[XmlEnum("")]
		None,

		[XmlEnum("internal-error")]
		InternalError,

		[XmlEnum("unsupported-country")]
		UnsupportedCountry,

		[XmlEnum("expired-card")]
		ExpiredCard,

		[XmlEnum("declined")]
		Declined,

		[XmlEnum("risk")]
		Risk,

		[XmlEnum("processor-risk")]
		ProcessorRisk,

		[XmlEnum("connection")]
		Connection,

		[XmlEnum("unknown")]
		Unknown,

		[XmlEnum("cc-address-verification")]
		CcAddressVerification,

		[XmlEnum("cc-cvv")]
		CcCvv,

		[XmlEnum("voice-auth")]
		VoiceAuth,
	}
}