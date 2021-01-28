using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> myDictionary = new MyDictionary<string>();
            myDictionary.Add("Burak");


            Console.WriteLine(myDictionary.Count);
        }
    }
}
