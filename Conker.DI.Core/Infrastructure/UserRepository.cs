using Conker.DI.Core.Domain;

namespace Conker.DI.Core.Infrastructure
{
	public class UserRepository : IUserRepository
	{
		public User Get(int id)
		{
			return Database.UserNumber1;
		}
	}
}