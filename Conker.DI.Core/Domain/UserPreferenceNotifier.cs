namespace Conker.DI.Core.Domain
{
	public class UserPreferenceNotifier : INotify
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