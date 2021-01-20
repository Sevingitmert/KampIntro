using System;
using Microsoft.VisualBasic.CompilerServices;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int num1 = 100;
            int num2 = 100;
            Console.WriteLine("Sayılar num1 :" + num1);
            Console.WriteLine("Sayılar num2 :" + num2);

            Console.WriteLine("Sayıların toplamı :" + (num1+num2));

            AddRef(num1, ref num2);
            Console.WriteLine("AddRef methodundan sonra num1 :" + num1 );
            Console.WriteLine("AddRef methodundan sonra num2 :" + num2 );
            OutRef(out num1,num2);
            Console.WriteLine("AddOut methodundan sonra num1 :" + num1);
            Console.WriteLine("AddOut methodundan sonra num2 :" + num2);


            void AddRef( int num1,ref int num2)
            {
                num2 = 10;
                Console.WriteLine("Ref sayıların toplamı :" + (num1+num2));
            }
            void OutRef(out int num1, int num2)
            {
                num1 = 20;
                Console.WriteLine("Out sayıların toplamı :" + (num1 + num2));
            }
        }
    }
}
