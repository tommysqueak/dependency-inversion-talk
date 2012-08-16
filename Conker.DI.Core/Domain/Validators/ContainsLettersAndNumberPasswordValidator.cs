using System;
using Conker.DI.Common;

namespace Conker.DI.Core.Domain.Validators
{
	public class ContainsLettersAndNumberPasswordValidator : IValidatePasswords
	{
		public void ValidatePassword(string password)
		{
			//	Regex would've only made me cry
			Logger.WriteLine("Validating Password contains the number 1.");
			if (!password.Contains("1"))
				throw new Exception("Password does not contain the number 1.");
		}
	}
}