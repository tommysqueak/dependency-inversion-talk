using System;
using Conker.DI.Common;

namespace Conker.DI.Core.Infrastructure
{
	public static class SmtpServer
	{
		public static void Send(string email, string message)
		{
			Logger.WriteLine("{0} to '{1}'", message, email);
		}
	}
}