using Conker.DI.Common;
using Conker.DI.Core.Domain;

namespace Conker.DI.Core.Infrastructure
{
	public interface INotify
	{
		void Notify(User user);
	}

	public class SmsNotifier : INotify
	{
		public void Notify(User user)
		{
			Logger.WriteLine("Sending sms about pwd change");
		}
	}

	public class EmailNotifier : INotify
	{
		readonly EmailTemplateStore templateStore;

		public EmailNotifier(EmailTemplateStore templateStore)
		{
			this.templateStore = templateStore;
		}

		public void Notify(User user)
		{
			var message = templateStore.BuildPlainTextMessage("PwdChanged");

			SmptServer.Send(user.Email, message);
		}
	}
}