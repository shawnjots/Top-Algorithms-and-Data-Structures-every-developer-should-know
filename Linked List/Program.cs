using Autofac;
using System;

namespace Linked_List
{
	class Program
	{
		

		public static void Main(string[] args)
		{
			ContainerConfig.Configure();
			using var scope = ContainerConfig.Container.BeginLifetimeScope();
			var app = scope.Resolve<IApplication>();
			app.Run();

		}
	}
}
