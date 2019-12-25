using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Linked_List
{
	public static class ContainerConfig
	{
		public static IContainer Container;

		public static IContainer Configure()
		{
			var builder = new ContainerBuilder();
			builder.RegisterType<Linked_List.Node>().As<INode>();
			builder.RegisterType<Linked_List.Application>().As<IApplication>();

			//Register an assembly
			/*builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
				.Where(t => t.Name.EndsWith("FileConvention") && t.Namespace.EndsWith("NameSpace"))
				.As(t => t.GetInterfaces().FirstOrDefault(
					i => i.Name == "I" + t.Name));*/

			//Register an assembly or class library
			/*builder.RegisterAssemblyTypes(Assembly.Load("AssemblyName"))
				.Where(t => t.Namespace.Contains("FolderName"))
				.As(t => t.GetInterfaces().FirstOrDefault(
					i => i.Name == "I" + t.Name));*/

			Container = builder.Build();
			return Container;
		}
	}
}
