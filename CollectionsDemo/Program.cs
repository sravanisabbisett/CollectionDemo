using System;

namespace CollectionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Collections collections = new Collections();
            Console.WriteLine("ListDemo");
            collections.ListDemo();
            Console.WriteLine("----------");
            Console.WriteLine("Stackdemo");
            collections.Stackdemo();
            Console.ReadKey();
            Console.WriteLine("----------");
            Console.WriteLine("Queuedemo");
            collections.QueueDemo();
        }
    }
}
