namespace Conker.DI.Core.Infrastructure
{
	public class EmailTemplateStore
	{
		public string BuildPlainTextMessage(string templateName)
		{
			return "Your password has changed! If this wasn't you, please notify support";
		}
	}
}