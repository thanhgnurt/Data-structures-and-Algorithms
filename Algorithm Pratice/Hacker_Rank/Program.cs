﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hacker_Rank.Stacks_and_Queues;

namespace Hacker_Rank
{
    class Program
    {
        static void Main(string[] args)
        {
            Friend_Circle_Queries_NotPerfoment friendCircle = new Friend_Circle_Queries_NotPerfoment();
            Stack stack = new Stack();
            stack.Push("a");
            stack.Push("b");
            stack.Pop();
            Console.WriteLine(stack.top);

            Console.ReadLine();
        }
    }
}
