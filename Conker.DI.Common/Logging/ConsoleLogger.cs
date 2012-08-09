using System;

namespace Conker.DI.Common.Logging
{
	public class ConsoleLogger : ILog
	{
		public void WriteLine(string message)
		{
			Console.WriteLine(message);
		}

		public void WriteLine(string formattedMessage, params object[] args)
		{
			Console.WriteLine(formattedMessage, args);
		}
	}
}