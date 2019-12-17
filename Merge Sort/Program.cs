using System;

namespace Merge_Sort
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Merge and Sort Routine");
			int[] numbers = { 5, 10, 3, 2, 4, 7, 1, 23, 56, 17, 19, 45, 12, 10, 7 };
			Console.WriteLine("Array before sort: 5, 10, 3, 2, 4, 7, 1, 23, 56, 17, 19, 45, 12, 10, 7");
			 var sortedArray = MergeSort.MergeAndSort(numbers);

			Console.Write("Array after sort: ");
			foreach (int val in sortedArray)
			{
				Console.Write(val + ",");
			}
			Console.WriteLine();
		}
	}
}
