using Conker.DI.Core.Domain;

namespace Conker.DI.Core.Infrastructure.Notifiers
{
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

			SmtpServer.Send(user.Email, message);
		}
	}
}