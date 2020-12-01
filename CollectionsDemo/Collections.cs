using System;
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
    }
}
