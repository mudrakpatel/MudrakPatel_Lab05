using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Import the custom LinkedListLibrary_Mudrak
//using LinkedListLibrary_Mudrak;

namespace MudrakPatel_Lab05_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            List doubleList = new List("doubleList");
            for (int index = 0; index <= 12; index++) {
                doubleList.InsertAtBack(index); // Call InsertAtBack method
            }
            Console.WriteLine("\n>>> Print list items using Display method:\n");
            doubleList.Display(); // Call Display method
            Console.WriteLine("\n>>> Clear the list and display contents:\n");
            for (int index = 0; index < doubleList.Count(); index++) {
                
            }
                //Console.WriteLine("\n>>> The list is empty now!\n---{0,2}", exception.Message);
            Console.WriteLine("\n>>> Now the contents of the List are:\n");
            doubleList.Display(); // Call Display method to prove that the List is empty
        }
    }
}
