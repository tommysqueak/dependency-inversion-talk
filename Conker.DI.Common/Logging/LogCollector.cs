using System.Collections.Generic;

namespace Conker.DI.Common.Logging
{
	public class LogCollector : ILog
	{
		public IList<string> Messages = new List<string>();

		public void WriteLine(string message)
		{
			Messages.Add(message);
		}

		public void WriteLine(string formattedMessage, params object[] args)
		{
			Messages.Add(string.Format(formattedMessage, args));
		}
	}
}