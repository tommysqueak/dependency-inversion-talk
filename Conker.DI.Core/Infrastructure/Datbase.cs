using Conker.DI.Core.Domain;

namespace Conker.DI.Core.Infrastructure
{
	public class Database
	{
		public static User UserNumber1 = new User
		                                 	{
		                                 		Id = 1,
												Password = "1234",
		                                 		Email = "tom@tom.com",
		                                 		Mobile = "+44123456789",
		                                 		Name = "Tom Philip",
		                                 		TwitterUsername = "tommysqueak"
		                                 	};
	}
}