using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Import StackInheritenceLibrary
using StackInheritanceLibrary;

namespace MudrakPatel_Lab05_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n>>> Creating Stack...\n");
            var stackList = new StackInheritance();
            Console.WriteLine("\n>>> Populating Stack with some data...\n");
            for (int index = 0; index < 5; index++)
            {
                stackList.Push(index); //Call Push method
            }
            Console.WriteLine("\n>>> Called Display method...\n");
            stackList.Display();
            Console.WriteLine("\n>>> Called Pop method...\n");

        }
    }
}
