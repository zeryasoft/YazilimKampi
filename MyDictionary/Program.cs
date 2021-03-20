using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Sedat");
            myDictionary.Add(2, "Nihal");
            myDictionary.Add(3, "Enes");
            myDictionary.Add(4, "Zana");
            myDictionary.Add(5, "Zerya");

            foreach (var item in myDictionary.value)
            {
                Console.WriteLine(item);
            }
        }
    }
}
