using System;
using Conker.DI.Core;
using Conker.DI.Core.Infrastructure;
using StructureMap;

namespace Conker.DI.ConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			//var originalPwdChanger = new BeforeDIPasswordChanger();
			//originalPwdChanger.ChangePassword(1, "administrator1");

			//	Register
			ObjectFactory.Initialize((i => i.AddRegistry<DemoRegistry>()));

			//	Entry Point
			var passwordChanger = ObjectFactory.GetInstance<PasswordChanger>();

			passwordChanger.ChangePassword(1, "Password1");


			var user = new UserRepository().Get(1);
			Console.WriteLine();
			Console.WriteLine("Result: Password changed to '{0}'", user.Password);

			Console.ReadLine();
		}
	}
}
