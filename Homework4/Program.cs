using System;
using System.Collections.Generic;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> student = new Dictionary<int, string>();
            Console.WriteLine(student.Count);
            student.Add(26,"Mert");
            student.Add(48,"Emre");

            Console.WriteLine(student[26]);

            MyDictionary<int, string> student2 = new MyDictionary<int, string>();
            student2.Add(26,"mert");
            student2.Add(34,"murat");
            student2.Add(35 ,"aybik");
           // Console.WriteLine(student2.Length);


            foreach (var item in student2.Values)
            {
                Console.WriteLine(item);
            }
            student2.Write(1);

            student2.Write2(34);

        }
    }
}
