using System;
using Conker.DI.Common;

namespace Conker.DI.Core.Domain.Validators
{
	public class Over6CharsPasswordValidator : IValidatePasswords
	{
		public void ValidatePassword(string password)
		{
			Logger.WriteLine("Validating Password is greater than 6 chars");
			if (password.Length < 6)
				throw new Exception("Password not long enough. Password should be create than 6 chars.");
		}
	}
}