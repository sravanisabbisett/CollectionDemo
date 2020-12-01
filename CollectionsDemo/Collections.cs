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

        public void QueueDemo()
        {
            Queue queue = new Queue();
            //adding element in queue
            queue.Enqueue("sravani");
            queue.Enqueue("Rupika");
            queue.Enqueue("lakshmi");
            queue.Enqueue("sailaja");
            foreach (var element in queue)
                Console.WriteLine(element);
            //counting number of elements in queue
            Console.WriteLine("Total number of elements present in queue is::" + queue.Count);
            //removing topmost element in queue
            Console.WriteLine("Removing top most element in queue::" + queue.Dequeue());
            Console.WriteLine("Total number of elements after removing one element::" + queue.Count);
            //getting topmost element in queue
            Console.WriteLine("Printng top most element in queue::" + queue.Peek());
            //checking element is present or not in queue
            Console.WriteLine("Checking element is present or not::" + queue.Contains("sailaja"));
            //clearing all elents in queue
            queue.Clear();
            Console.WriteLine("Total number of elements after clearing the queue::" + queue.Count);

        }

        public void DictionaryDemo()
        {
            Dictionary<int, String> My_dict = new Dictionary<int, string>();
            My_dict.Add(1, "sravani");
            My_dict.Add(2, "sailaja");
            My_dict.Add(3, "Akhilesh");
            My_dict.Add(4, "nadh");

            //printing the elements in dictionay
            foreach (KeyValuePair<int, string> ele in My_dict)
            {
                Console.WriteLine("{0} and {1}",
                            ele.Key, ele.Value);
            }

            //Removing element in dictionaty
            Console.WriteLine("Counting the Number of elements Before removing::" + My_dict.Count);
            My_dict.Remove(1);
            Console.WriteLine("Counting the Number of elements after removing::"+My_dict.Count);
            var result=My_dict.ContainsKey(2);
            Console.WriteLine("Checking if the key is present or not::"+result);
            var valueResult = My_dict.ContainsValue("sailaja");
            Console.WriteLine("Checking if the value is present or not::" + valueResult);
            My_dict.Clear();
            Console.WriteLine("Counting the Number of elements after clearing the dictionary::" + My_dict.Count);

        }
    }
}
