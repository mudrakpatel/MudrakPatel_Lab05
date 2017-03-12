using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Import StackInheritenceLibrary
using StackInheritanceLibrary;
using LinkedListLibrary;

namespace MudrakPatel_Lab05_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
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
                Console.WriteLine("\n--- Popped element: {0,2}\n", stackList.Pop()); //Call Pop method
                Console.Write("\n--- Stack data: ");
                stackList.Display();
                Console.WriteLine(); //Blank line
                Console.WriteLine("\n>>> Called Peek method...\n");
                Console.WriteLine("\n--- Peeked element: {0,2}\n", stackList.Peek()); //Call Peek method
            }
            catch (EmptyListException exception)
            {
                Console.WriteLine("\n>>> Exception message: {0,2}\n", exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine("\n>>> Exception message: {0,2}\n", exception.Message);
            }
        }
    }
}
