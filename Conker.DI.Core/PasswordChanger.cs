using Conker.DI.Core.Domain;

namespace Conker.DI.Core
{
	public class PasswordChanger
	{
		readonly IValidatePasswords validatePasswords;
		private readonly IUserRepository repository;
		private readonly INotify notifier;

		public PasswordChanger(IValidatePasswords validatePasswords,
											IUserRepository repository, INotify notifier)
		{
			this.validatePasswords = validatePasswords;
			this.repository = repository;
			this.notifier = notifier;
		}

		public void ChangePassword(int id, string password)
		{
			validatePasswords.ValidatePassword(password);

			var user = repository.Get(id);
			user.Password = password;

			notifier.Notify(user);
		}
	}
}