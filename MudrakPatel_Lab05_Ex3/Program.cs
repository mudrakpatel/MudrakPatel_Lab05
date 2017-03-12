using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Import QueueInheritenceLibrary
using QueueInheritanceLibrary;
using LinkedListLibrary;


namespace MudrakPatel_Lab05_Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("\n>>> Creating and populating the Queue...\n");
                var stringQueue = new QueueInheritance();
                for (int index = 0; index < 5; index++)
                {
                    stringQueue.Enqueue("-String: " + Convert.ToString(index) + "-");//Call Enqueue method
                }
                Console.WriteLine("\n>>> Calling StringDisplay method...\n");
                stringQueue.StringListDisplay();
                Console.WriteLine("\n>>> Calling Dequeue method...\n");
                var dequeuedString = stringQueue.Dequeue();// Call Dequeue method
                Console.WriteLine("\n--- String dequeued: {0,2}\n", dequeuedString);
                Console.WriteLine("\n>>> Calling StringDisplay method...\n");
                stringQueue.StringListDisplay();
                Console.WriteLine("\n>>> Calling garbage collector...\n");
                GC.WaitForPendingFinalizers();
                GC.Collect();
            }
            catch (EmptyListException exception)
            {
                Console.WriteLine("\n>>> Exception message: {0,2}\n", exception.Message);
            }
            catch(Exception exception)
            {
                Console.WriteLine("\n>>> Exception message: {0,2}\n", exception.Message);
            }
        }
    }
}
