using System;
using Conker.DI.Core.Domain;

namespace Conker.DI.Core.Infrastructure.Notifiers
{
	public class TwitterNotifier : INotify
	{
		public void Notify(User user)
		{
			Console.WriteLine("Hello from twitter");
		}
	}
}