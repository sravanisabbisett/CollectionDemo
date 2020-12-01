using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CollectionsDemo
{
    class Collections
    {
        public void ListDemo()
        {
            List<string> names = new List<string>();
            names.Add("sravani");
            names.Add("lashkmi");
            names.Add("manju");
            names.Add("navya");
            names.Insert(2, "kavitha");
            Console.WriteLine("Checking if the element is present or not" + names.Contains("sravani"));
            Console.WriteLine("count numer of elements in list:" + names.Count);
            Console.WriteLine("Printing list of elements");
            foreach (string name in names)
                Console.WriteLine(name);
            names.Sort();
            Console.WriteLine("Printing the list of elements oafter sorting");
            foreach (string name in names)
                Console.WriteLine(name);
            names.Remove("manju");
            Console.WriteLine("counting the list of elements after removing::" + names.Count);


        }

        public void Stackdemo()
        {
            Stack myStack = new Stack();
            //add element in stack
            myStack.Push("sravani");
            myStack.Push("Rupika");
            myStack.Push("lakshmi");
            myStack.Push("sailaja");
            foreach (var element in myStack)
                Console.WriteLine(element);
            //counting all elements in stack
            Console.WriteLine("total elements present in stack is::" + myStack.Count);
            //removing topmost element
            Console.WriteLine("Top most element present in stack::" + myStack.Pop());
            Console.WriteLine("total elements present in stack after poping one element" + myStack.Count);
            //printing topmost element in stack
            Console.WriteLine("TopMost present in stack is::" + myStack.Peek());
            bool reslt = myStack.Contains("Rupika");
            Console.WriteLine("elemnet present in stack::" + reslt);
            //clearing the stack
            myStack.Clear();
            Console.WriteLine("total elements present in stack after clearing all  elements::" + myStack.Count);
        }
    }
}
