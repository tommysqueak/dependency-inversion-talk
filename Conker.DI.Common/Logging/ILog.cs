namespace Conker.DI.Common.Logging
{
	public interface ILog
	{
		void WriteLine(string message);
		void WriteLine(string formattedMessage, params object[] args);
	}
}