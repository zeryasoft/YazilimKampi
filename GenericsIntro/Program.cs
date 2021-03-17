using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Sedat");
            isimler.Add("Nihal");
            isimler.Add("Enes");
            isimler.Add("Zana");
            isimler.Add("Zerya");
            //foreach (var item in isimler)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
