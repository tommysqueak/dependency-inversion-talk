namespace Conker.DI.Core.Domain.Validators
{
	public class PasswordValidator : IValidatePasswords
	{
		private readonly IValidatePasswords[] validators;

		public PasswordValidator(IValidatePasswords[] validators)
		{
			this.validators = validators;
		}

		public void ValidatePassword(string newPassword)
		{
			foreach (var validator in validators)
			{
				validator.ValidatePassword(newPassword);
			}
		}
	}
}