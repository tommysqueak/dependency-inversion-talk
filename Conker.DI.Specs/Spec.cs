using Machine.Specifications;
using Moq;
using StructureMap.AutoMocking;

namespace Conker.DI.Specs
{
	public class Spec<T> where T : class
	{
		static MoqAutoMocker<T> container;

		Establish context = () =>
			container = new MoqAutoMocker<T>();

		protected static T Subject
		{
			get { return container.ClassUnderTest; }
		}

		protected static Mock<TDependency> Dependency<TDependency>() where TDependency : class
		{
			return Mock.Get(container.Get<TDependency>());
		}
	}
}