using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Pratice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[10] { 5, 3, 2, 7, 6, 4, 5, 1, 9, 5 };

            //---check function CountingSort
            input = Counting_Sort.CountingSort(input);
            //--Check function QuickSort
            // input = Quick_Sort.QuickSort(input);
            //input = Insertion_Sort.InsertionSort(input);
            int indexSearch = BinarySearch.BinarySearchRecursive(input, 0, 9, 4);
            Console.WriteLine(indexSearch);
            for (int i = 0; i< input.Length; i++)
            {
                Console.WriteLine(input[i]);
            }
            Console.ReadLine();

        }






    }
}
