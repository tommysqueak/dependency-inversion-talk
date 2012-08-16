using Conker.DI.Core;
using Conker.DI.Core.Domain;
using Conker.DI.Core.Domain.Validators;
using Conker.DI.Core.Infrastructure;
using Conker.DI.Core.Infrastructure.Notifiers;
using StructureMap.Configuration.DSL;

namespace Conker.DI.ConsoleApp
{
	public class DemoRegistry : Registry
	{
		public DemoRegistry()
		{
			Scan(s =>
				{
					s.AssemblyContainingType<User>();
					s.SingleImplementationsOfInterface();
				}
			);

			Scan(s =>
				{
					s.AssemblyContainingType<User>();
					s.IncludeNamespaceContainingType<SmsNotifier>();
					s.AddAllTypesOf<INotify>();
				}
			);

			Scan(s =>
				{
					s.AssemblyContainingType<User>();
					s.IncludeNamespaceContainingType<Over6CharsPasswordValidator>();
					s.AddAllTypesOf<IValidatePasswords>();
					s.ExcludeType<PasswordValidator>();
				}
			);

			For<PasswordChanger>().Use<PasswordChanger>()
				.Ctor<INotify>().Is<UserPreferenceNotifier>()
				.Ctor<IValidatePasswords>().Is<PasswordValidator>();
		}
	}
}