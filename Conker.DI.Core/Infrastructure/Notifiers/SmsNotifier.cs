using Conker.DI.Common;
using Conker.DI.Core.Domain;

namespace Conker.DI.Core.Infrastructure.Notifiers
{
	public class SmsNotifier : INotify
	{
		public void Notify(User user)
		{
			Logger.WriteLine("Sending sms about pwd change");
		}
	}
}