using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>();

            names.Add("Mert");
        }
    }
}
