using StructureMap;

namespace Conker.DI.Common
{
	public static class ServiceLocator
	{
		 public static T GetInstance<T>()
		 {
		 	return ObjectFactory.GetInstance<T>();
		 }
	}
}