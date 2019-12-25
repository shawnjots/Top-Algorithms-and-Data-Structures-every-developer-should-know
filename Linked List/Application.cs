using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_List
{
	public class Application : IApplication
	{
		private readonly INode _first;
		private readonly INode _second;
		private readonly INode _third;
		
		public Application(INode first, INode second, INode third)
		{
			_first = first;
			_second = second;
			_third = third;
		}

		public void Run()
		{
			Console.WriteLine("Linked Lists");

			_first.Value = 5;

			_second.Value = 7; _first.Next = _second;

			_third.Value = 9; _second.Next = _third;

			Node.PrintList(_first);

		}
	}
}
