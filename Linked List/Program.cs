using Autofac;
using System;

namespace Linked_List
{
	class Program
	{
		public static IContainer Container;

		static void Main(string[] args)
		{
			Console.WriteLine("Linked Lists");

			ContainerBuilder builder = new ContainerBuilder();
			builder.RegisterType<Linked_List.Node>();
			Container = builder.Build();

			Node first = Container.Resolve<Linked_List.Node>();
			first.Value = 5; 

			Node second = Container.Resolve<Linked_List.Node>();
			second.Value = 7; first.Next = second;

			Node third = Container.Resolve<Linked_List.Node>();
			third.Value = 9; second.Next = third;

		}
	}
}
