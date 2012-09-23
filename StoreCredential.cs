using System;

namespace SyntaxTree.FastSpring.Api
{
	public sealed class StoreCredential
	{
		public string Company { get; private set; }
		public string Username { get; private set; }
		public string Password { get; private set; }

		public StoreCredential(string company, string username, string password)
		{
			if (company == null)
				throw new ArgumentNullException("company");
			if (username == null)
				throw new ArgumentNullException("username");
			if (password == null)
				throw new ArgumentNullException("password");

			if (company.Length == 0)
				throw new ArgumentException("Company name is empty.", "company");
			if (username.Length == 0)
				throw new ArgumentException("Username is empty.", "username");
			if (password.Length == 0)
				throw new ArgumentException("Password is empty", "password");

			Company = company;
			Username = username;
			Password = password;
		}
	}
}