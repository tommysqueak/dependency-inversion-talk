using Conker.DI.Core.Infrastructure;

namespace Conker.DI.Core.Domain
{
	public class UserRepository
	{
		public User Get(int Id)
		{
			return Database.UserNumber1;
		}
	}
}