using Conker.DI.Core;
using Conker.DI.Core.Domain;
using Machine.Specifications;
using Moq;
using It = Machine.Specifications.It;

namespace Conker.DI.Specs
{
	public class when_changing_a_valid_password
	{
		Establish context = () =>
		{
			validator = new Mock<IValidatePasswords>();
			repository = new Mock<IUserRepository>();
			notifier= new Mock<INotify>();

			user = new User();
			repository.Setup(m => m.Get(1)).Returns(user);

			passwordChanger = new PasswordChanger(validator.Object, repository.Object, notifier.Object);
		};

		Because of = () =>
		     passwordChanger.ChangePassword(1, "Password1");

		It should_validate_the_password = () =>
		   validator.Verify(m => m.ValidatePassword("Password1"));

		It should_change_password = () =>
			user.Password.ShouldEqual("Password1");

		It should_notify_the_user_their_password_has_changed = () =>
			notifier.Verify(m => m.Notify(user));

		static PasswordChanger passwordChanger;
		static Mock<IValidatePasswords> validator;
		private static User user;
		private static Mock<IUserRepository> repository;
		private static Mock<INotify> notifier;
	}

}