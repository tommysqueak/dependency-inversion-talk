using System.Collections.Generic;

namespace Conker.DI.Mvc.Controllers
{
	public static class StringCollectionExtensions
	{
		public static string Join(this IList<string> list)
		{
			string joinedMessage = "";

			foreach (var value in list)
			{
				joinedMessage += value + "<br>";
			}

			return joinedMessage;
		}
	}
}