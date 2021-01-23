using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int,string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(01, "Adana");
            myDictionary.Add(06, "Ankara");
            myDictionary.Add(34, "İstanbul");
            myDictionary.Add(35, "İzmir");

            foreach (var name in myDictionary.Keys)
            {
                Console.WriteLine(name);
            }
            foreach (var number in myDictionary.Values)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();
        }
    }
}
