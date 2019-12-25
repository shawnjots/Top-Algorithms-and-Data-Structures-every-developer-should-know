using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_List
{
	public class Node : INode
	{
		public int Value { get; set; }
		public INode Next { get; set; }


		public static void PrintList(INode node)
		{
			while (node != null)
			{
				Console.WriteLine(node.Value);
				node = node.Next;
			}
		}
	}
}
