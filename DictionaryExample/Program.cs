using System;
using System.Collections.Generic;
namespace DictionaryExample
{
    class Program
    {
        static void Main()
        {
            //create a empty dictionary
            Console.WriteLine("Key value pairs in Dictionary");
            Dictionary<int, string> employees = new Dictionary<int, string>()
            {
                {101,"Mohith" },
                {102,"Rohith" },
                {103,"Ramesh" },
                {104,"Suresh" }
            };
            employees.Add(105, "Renu");
            
            foreach(KeyValuePair <int,string> item in employees)
                {
                    Console.WriteLine(item.Key+","+item.Value);
                }
            //keys
            Console.WriteLine();
            Console.WriteLine("Keys in Dictionary");
            Dictionary<int,string>.KeyCollection keys=employees.Keys;
            foreach(int item in keys)
            { Console.WriteLine(item); }
            Console.WriteLine();
            Console.WriteLine("Values in Dictionary");
            Dictionary<int, string>.ValueCollection values = employees.Values;
            foreach(string item in values)
            { Console.WriteLine(item); }
            //contains 
            Console.WriteLine();
            Console.WriteLine("Contains the element");
            bool b = employees.ContainsKey(101);
            Console.WriteLine("Contains Value : "+b);
            Console.ReadKey();

        }
    }
}
