using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>{"emre","aybik","efe","sema"};
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            names.Add("Mert");
            Console.WriteLine(names[4]);
            
        }
    }
}
