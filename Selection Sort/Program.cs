using System;

namespace Selection_Sort
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Selection Sort");
            SelectionSort();
		}

		public static void SelectionSort()
		{
            int[] arr = { 5, 10, 3, 2, 4, 7, 1, 23, 56, 17, 19, 45, 12, 10, 7 };
            int n = arr.Length;
            Console.WriteLine("Selection sort");
            Console.Write("Initial array is: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            int temp, smallest;
            for (int i = 0; i < n - 1; i++)
            {
                smallest = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[smallest])
                    {
                        smallest = j;
                    }
                }
                temp = arr[smallest];
                arr[smallest] = arr[i];
                arr[i] = temp;
            }
            Console.WriteLine();
            Console.Write("Sorted array is: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
	}
}
