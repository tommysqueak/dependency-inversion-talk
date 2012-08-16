using Conker.DI.Common;
using Conker.DI.Core;
using Conker.DI.Core.Domain;
using Conker.DI.Core.Infrastructure;

namespace Conker.DI.Before.AfterDI
{
	public class AfterDIPasswordChanger
	{
		readonly PasswordValidator validator;
		readonly UserRepository userRepository;
		readonly INotify notifier;

		public AfterDIPasswordChanger(PasswordValidator validator, UserRepository userRepository, INotify notifier)
		{
			this.validator = validator;
			this.userRepository = userRepository;
			this.notifier = notifier;
		}

		public void ChangePassword(int userId, string newPassword)
		{
			validator.ValidatePassword(newPassword);

			var user = userRepository.Get(userId);

			Logger.WriteLine("Changing password");
			user.Password = newPassword;

			notifier.Notify(user);
		}
	}
}