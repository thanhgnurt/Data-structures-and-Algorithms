using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithm_Pratice.Stack;
using Algorithm_Pratice.Queue;
using Algorithm_Pratice.Linked_List;
using Algorithm_Pratice.Sort;
using Algorithm_Pratice.Trees;

namespace Algorithm_Pratice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[8] { 35, 33, 42, 10, 14, 19, 27, 44 };
            // StackCus StackDemo = new StackCus(10);
            //  StackDemo.Push("a");
            // StackDemo.Push("b");
            //StackDemo.Pop();
            // string peek = StackDemo.Peek();
            // bool isEmpty = StackDemo.IsEmpty();
            // Console.WriteLine(StackDemo.top);
            // Console.WriteLine(peek);
            BTSTree treeDemo = new BTSTree(input[0]);
            for (int i =1; i< input.Length; i++)
            {
                treeDemo.InsertNodeIndex(input[i], i);
            }
            int ind = treeDemo.Search(15);
            Console.WriteLine("Position in Array : {0}", ind);
            Console.ReadLine();




            BTSTree newTree = new BTSTree(5);
            newTree.InsertNode(10);
            newTree.InsertNode(3);
            newTree.InsertNode(2);
            newTree.InsertNode(4);
            newTree.InsertNode(6);
            newTree.InsertNode(7);
            newTree.InsertNode(12);
            int index = newTree.root.Search(12);
            Console.WriteLine(index);
;
            // Implement_Queue_Linked_List<int> queueLL = new Implement_Queue_Linked_List<int>();
            // queueLL.Push(15);
            //// queueLL.Push(25);
            //queueLL.Push(30);
            // queueLL.Push(55);

            // Console.WriteLine("head1: {0}",queueLL.headQueue.next.data);
            // Console.WriteLine("tail1: {0}", queueLL.Length);
            //  Console.WriteLine("peek: {0}",queueLL.Peek().data);

            //   Console.WriteLine("Pop: {0}",queueLL.Pop().data);
            // Console.WriteLine("head2: {0}", queueLL.headQueue.data);
            // Console.ReadLine();
            //---check function CountingSort
            // input = Counting_Sort.CountingSort(input);
            //--Check function QuickSort
            // input = Quick_Sort.QuickSort(input);
            // input = Insertion_Sort.InsertionSort(input);
            // input = Shell_Sort.ShellSort(input);
           // int indexSearch = BinarySearch.BinarySearchRecursive(input, 0, 9, 4);
           // Console.WriteLine(indexSearch);
            for (int i = 0; i< input.Length; i++)
            {
                Console.WriteLine(input[i]);
            }
            Console.ReadLine();
            

        }






    }
}
