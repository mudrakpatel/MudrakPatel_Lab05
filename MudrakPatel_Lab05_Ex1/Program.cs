using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Import the custom LinkedListLibrary_Mudrak
using LinkedListLibrary;

namespace MudrakPatel_Lab05_Ex1
{
    class Program
    {
        static void Main()
        {
            var doubleList = new CustomList();
            for(int index = 0; index < 5; index++)
            {
                doubleList.InsertAtBack(index); // Call InsertAtBack method
            }
            Console.WriteLine("\n>>> Display method called...\n");
            doubleList.Display(); //Call Display method
            ////
            //Call CustomList.Count static method
            Console.WriteLine("\n>>> The count of the list is: {0,2}\n", CustomList.Count(doubleList));
            Console.WriteLine("\n>>> Search method called...\n");
            doubleList.Search(2); //Call Search method
            Console.WriteLine("\n>>> RemoveFromFront method called...\n");
            doubleList.RemoveFromFront();
            Console.WriteLine("\n>>> Display method called...\n");
            doubleList.Display(); //Call Display method
            Console.WriteLine("\n>>> RemoveFromBack method called...\n");
            doubleList.RemoveFromBack();
            Console.WriteLine("\n>>> Display method called...\n");
            doubleList.Display(); //Call Display method
            Console.WriteLine("\n>>> InsertAtFront method called...\n");
            doubleList.InsertAtFront(10);
            Console.WriteLine("\n>>> Display method called...\n");
            doubleList.Display(); //Call Display method
            Console.WriteLine("\n>>> Calling garbage collector...\n");
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
    }
}
