using Conker.DI.Core;
using Conker.DI.Core.Domain;
using Conker.DI.Core.Infrastructure;
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
					s.AddAllTypesOf<INotify>();
				}
			);

			//For<INotify>().Singleton().Use<UserPreferenceNotifier>();

		}
	}
}