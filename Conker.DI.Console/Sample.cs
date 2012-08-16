using Conker.DI.Common.Logging;
using Conker.DI.Core.Infrastructure;
using StructureMap;
using StructureMap.Configuration.DSL;



namespace Conker.DI.ConsoleApp
{
	public class Sample
	{
		public void Main()
		{
			ObjectFactory.Initialize(c => c.AddRegistry<SampleRegistry>());
		}
	}

	public class SampleRegistry : Registry
	{
		public SampleRegistry()
		{
			For<ILog>().Singleton().Use<LogCollector>();
			
			Forward<ILog, LogCollector>();
		}
	}
}