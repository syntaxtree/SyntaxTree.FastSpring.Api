using System;
using System.Net;
using System.Text;
using System.Xml.Serialization;

namespace SyntaxTree.FastSpring.Api
{
    public sealed class CompanyStore
    {
	    private readonly StoreCredential _credential;

		public CompanyStore(StoreCredential credential)
		{
			if (credential == null)
				throw new ArgumentNullException("credential");

			_credential = credential;
		}

        public T ParseResponse<T>(WebResponse response)
        {
            if (response == null)
                throw new InvalidOperationException("No response.");

            var responseStream = response.GetResponseStream();
            if (responseStream == null)
                throw new InvalidOperationException("Unable to acquire response stream.");

            return (T)new XmlSerializer(typeof(T)).Deserialize(responseStream);
        }

        public Coupon GenerateCoupon(string prefix)
        {
            if (prefix == null)
                throw new ArgumentNullException("prefix");
            if (prefix.Length == 0)
                throw new ArgumentException("Prefix is empty.", "prefix");

            var request = Request("POST", string.Concat("/coupon/",prefix,"/generate"));
            return ParseResponse<Coupon>(request.GetResponse());
        }

		public Order Order(string reference)
		{
			if (reference == null)
				throw new ArgumentNullException("reference");
			if (reference.Length == 0)
				throw new ArgumentException("Reference is empty.", "reference");

			var request = Request("GET", "/order/" + reference);
		    return ParseResponse<Order>(request.GetResponse());
		}

		private WebRequest Request(string method, string uri)
		{
			var request = WebRequest.Create(StoreUri(uri));
			request.ContentType = "application/xml";
			request.Method = method;
			request.Headers["Authorization"] = AuthorizationHeader();
			return request;
		}

	    private string AuthorizationHeader()
	    {
		    return "Basic " + Convert.ToBase64String(Encoding.UTF8.GetBytes(_credential.Username + ":" + _credential.Password));
	    }

	    private string StoreUri(string uri)
		{
			return "https://api.fastspring.com/company/" + _credential.Company + uri;
		}
    }
}
