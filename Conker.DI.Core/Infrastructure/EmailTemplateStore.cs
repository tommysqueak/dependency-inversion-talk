namespace Conker.DI.Core.Infrastructure
{
	public class EmailTemplateStore
	{
		public string BuildPlainTextMessage(string templateName)
		{
			return "Sending Email about PWD change";
		}
	}
}