using System;
using Conker.DI.Core.Domain;
using Conker.DI.Core.Infrastructure;

namespace Conker.DI.Before.BeforeSR
{
	public class BeforeSRPasswordChanger
	{
		public void ChangePassword(int userId, string newPassword)
		{
			Console.WriteLine("Validating Password is greater than 6 chars");
			if (newPassword.Length < 6)
				throw new Exception("Password not long enough. Password should be create than 6 chars.");

			Console.WriteLine("Validating Password contains the number 1");
			if (!newPassword.Contains("1"))
				throw new Exception("Password does not contain the number 1.");
		
			var repository = new UserRepository();
			var user = repository.Get(userId);

			Console.WriteLine("Changing password");
			user.Password = newPassword;

			var message = "Your password has changed! If this wasn't you, please notify support";

			SmtpServer.Send(user.Email, message);
		}
	}
}