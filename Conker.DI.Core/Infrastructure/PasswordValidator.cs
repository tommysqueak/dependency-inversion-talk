using System;
using Conker.DI.Common;

namespace Conker.DI.Core.Infrastructure
{
	public class PasswordValidator
	{
		public void ValidatePassword(string newPassword)
		{
			Logger.WriteLine("Validating Password is greater than 6 chars");
			if (newPassword.Length < 6)
				throw new Exception("Password not long enough. Password should be create than 6 chars.");

			Logger.WriteLine("Validating Password contains the number 1");
			if (!newPassword.Contains("1"))
				throw new Exception("Password does not contain the number 1.");
		}
	}
}