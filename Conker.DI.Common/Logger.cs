using System;

namespace Conker.DI.Common
{
	public static class Logger
	{
		public static void WriteLine(string message)
		{
			Console.WriteLine(message);
		}

		public static void WriteLine(string formattedMessage, params object[] args)
		{
			Console.WriteLine(formattedMessage, args);
		}
	}
}