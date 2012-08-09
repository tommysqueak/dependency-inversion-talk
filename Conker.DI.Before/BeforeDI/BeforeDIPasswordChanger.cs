using System;
using Conker.DI.Common;
using Conker.DI.Common.Logging;
using Conker.DI.Core.Domain;
using Conker.DI.Core.Infrastructure;

namespace Conker.DI.Before.BeforeDI
{
	public class BeforeDIPasswordChanger
	{
		public void ChangePassword(int userId, string newPassword)
		{
			var validator = new PasswordValidator();
			validator.ValidatePassword(newPassword);

			var repository = new UserRepository();
			var user = repository.Get(userId);

			Logger.WriteLine("Changing password");
			user.Password = newPassword;

			var emailNotifier = new EmailNotifier(new EmailTemplateStore());
			emailNotifier.Notify(user);
		}
	}
}