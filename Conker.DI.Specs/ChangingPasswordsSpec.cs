using System;
using Conker.DI.Common;
using Conker.DI.Common.Logging;
using Conker.DI.Core;
using Machine.Specifications;
using Moq;
using It = Machine.Specifications.It;

namespace Conker.DI.Specs
{
	public class ChangingPasswordsSpec
	{
		Establish context = () =>
		{
			validator = new Mock<IValidatePasswords>();
			passwordChanger = new PasswordChanger(validator.Object);
		};

		Because of = () =>
		     passwordChanger.Changepassword(1, "Password1");

		It should_validate_the_password = () =>
		   validator.Verify(m => m.Validate("Password1"));

		It should_change_password;

		It should_notify_the_user_their_password_has_changed;

		static PasswordChanger passwordChanger;
		static Mock<IValidatePasswords> validator;
	}

	public interface IValidatePasswords
	{
		void Validate(string password);
	}

	public class PasswordChanger
	{
		readonly IValidatePasswords validatePasswords;

		public PasswordChanger(IValidatePasswords validatePasswords)
		{
			this.validatePasswords = validatePasswords;
		}

		public void Changepassword(int id, string password)
		{
			validatePasswords.Validate(password);
		}
	}
}