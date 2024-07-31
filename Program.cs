using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;
using System.Xml.Linq;
using System;
using System.Collections;

namespace AdvC_2
{
    internal class Program
    {

        #region 2.1 function
        static void rev(ArrayList list)
        {
            int f = 0;
            int l = list.Count - 1;

            while (f < l)
            {
                object temp = list[f];
                list[f] = list[l];
                list[l] = temp;
                f++;
                l--;
            }
        }
        #endregion

        #region 2.2 function
        static void eve( List<int> list)
        {
            for(int i=0; i < list.Count; i++) 
            {
                if (list[i] % 2>0) 
                {
                    list.RemoveAt(i);
                } 
            }
            
        }

        #endregion


        static void Main(string[] args)
        {
            #region Part 01

            //Write a Report about all Collections Given in the Session and Compare[Structure, Time Complexity, and Business Case With Implemented Examples]

            ////List:
            ////Structure: Resizable array that holds elements.
            ////Time Complexity:O(1)
            ////Used when you need a dynamic list with fast random access.
            //List<string> list = new List<string>();
            //list.Add("ahmed");
            //Console.WriteLine(list[0]);

            ////SortedList:
            ////Structure: Stores key-value pairs.
            ////Automatically arranges elements in ascending order of the key by default.
            ////Time Complexity:O(log n)
            ////Used When you need to sorted data by key.
            //SortedList sl = new SortedList();
            //sl.Add(2, "ahmed");
            //sl.Add(1, "samir");
            //sl.Add(4, "wael");
            //sl.Add(3, "mohamed");
            //foreach (DictionaryEntry x in sl)
            //{
            //    Console.WriteLine($"Key: {x.Key}, Value: {x.Value}");
            //}

            ////Stack:
            ////Structure:Last - In - First - Out.
            ////Time Complexity: O(1)
            //// for push and pop operations.
            ////Used for undo functionality.
            //Stack<int> s = new Stack<int>();
            //s.Push(3);
            //s.Pop();
            //s.Push(8);
            //s.Push(2);
            //foreach (int x in s)
            //{
            //    Console.WriteLine(x);
            //}

            ////Queue:
            ////Structure:First - In - First - Out.
            ////Time Complexity: O(1)
            //// for enqueue and dequeue operations.
            ////Useful for task scheduling.
            //Queue<int> q = new Queue<int>();
            //q.Enqueue(5);            
            //q.Enqueue(17);
            //q.Dequeue();
            //q.Enqueue(80);
            //foreach (int x in q)
            //{
            //    Console.WriteLine(x);
            //}

            ////LinkedList
            ////Structure: use node.
            ////Time Complexity:O(n)
            ////Used when we need frequent insertions/ removals.
            //LinkedList<string> l = new LinkedList<string>();
            //l.AddLast("mohamed");
            //l.AddLast("ahmed");
            //l.AddLast("farag");
            //foreach (string x in l)
            //{
            //    Console.WriteLine(x);
            //}
            #endregion

            #region Part 02

            #region 2.1

            ////You are given an ArrayList containing a sequence of elements.
            ////try to reverse the order of elements in the ArrayList in-place(in the same arrayList)
            ////without using the built-in Reverse.
            ////Implement a function that takes the ArrayList as input and modifies it to have the reversed order of elements.

            //ArrayList l = new ArrayList();
            //l.Add(5); l.Add(189); l.Add(16); l.Add(80); l.Add(-1);
            //rev(l);
            //foreach (var x in l)
            //{
            //    Console.WriteLine(x);
            //}

            #endregion

            #region 2.2

            ////You are given a list of integers.Your task is to find and return a new list containing only the even numbers from the given list.

            //List<int> l = new List<int>() { 1, 2, 3, 4, 5 };
            //eve(l);
            //foreach (var x in l)
            //{
            //    Console.WriteLine(x);
            //}

            #endregion

            #region 2.3

            ////implement a custom list called FixedSizeList<T> with a predetermined capacity.
            ////This list should not allow more elements than its capacity and should provide clear messages if one tries to exceed it or access invalid indices.
            ////Requirements:
            ////Create a generic class named FixedSizeList<T>.
            ////Implement a constructor that takes the fixed capacity of the list as a parameter.
            ////Implement an Add method that adds an element to the list, but throws an exception if the list is already full.
            ////Implement a Get method that retrieves an element at a specific index in the list but throws an exception for invalid indices.

            //var f=new fl<int>(5);
            //f.Add(1); f.Add(2); f.Add(3); f.Add(4); f.Add(5);
            //f.Add(1); //over fixed size
            //Console.WriteLine($"Index number 5 = {f.Get(5)} ");
            ////f.Get(6); //error

            #endregion

            #endregion
        }
    }
}
