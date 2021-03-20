using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Sedat");
            myDictionary.Add(1, "Nihal");
            myDictionary.Add(1, "Enes");
            myDictionary.Add(1, "Zana");
            myDictionary.Add(1, "Zerya");

            foreach (var item in myDictionary.value)
            {
                Console.WriteLine(item);
            }
        }
    }
}
