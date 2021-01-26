using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>();


            names.Add("Mert");
            names.Add("efe");

            Console.WriteLine(names.Length);
          

            foreach (var name in names.Items)
            {
                Console.WriteLine(name);
            }
            {
                
            }
        }
    }
}
