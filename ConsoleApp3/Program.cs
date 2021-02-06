using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(01, "Adana");
            myDictionary.Add(02, "Adıyaman");
            myDictionary.Add(03, "Afyon");
        }
    }
}
