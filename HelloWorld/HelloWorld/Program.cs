using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            ChangeTitle("My first application in C#");
            Console.WriteLine("Hello World");
            Console.ReadLine();
        }

        static void ChangeTitle(string title)
        {
            Console.Title = title;
        }
    }
}
