using Conker.DI.Core.Domain;

namespace Conker.DI.Core.Infrastructure
{
	public class UserPreferenceNotifier
	{
		private readonly INotify[] notifiers;

		public UserPreferenceNotifier(INotify[] notifiers)
		{
			this.notifiers = notifiers;
		}

		public void Notify(User user)
		{
			foreach (var notifier in notifiers)
			{
				notifier.Notify(user);
			}
		}
	}
}