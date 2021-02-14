using System;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1699, "Zafer");
            myDictionary.Add(1696, "Abdullah");
            myDictionary.Add(1700,"Bora");
            myDictionary.Add(1703,"Efecan");

            myDictionary.Key(1699);
            myDictionary.Key(1710);
            myDictionary.Key(1696);

            Console.ReadLine();

        }
    }
}
