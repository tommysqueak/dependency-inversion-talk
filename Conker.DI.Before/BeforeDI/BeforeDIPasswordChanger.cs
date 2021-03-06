﻿using System;
using Conker.DI.Common;
using Conker.DI.Common.Logging;
using Conker.DI.Core;
using Conker.DI.Core.Domain;
using Conker.DI.Core.Domain.Validators;
using Conker.DI.Core.Infrastructure;
using Conker.DI.Core.Infrastructure.Notifiers;

namespace Conker.DI.Before.BeforeDI
{
	public class BeforeDIPasswordChanger
	{
		public void ChangePassword(int userId, string newPassword)
		{
			IValidatePasswords validator = new Over6CharsPasswordValidator();
			validator.ValidatePassword(newPassword);

			validator = new ContainsLettersAndNumberPasswordValidator();
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