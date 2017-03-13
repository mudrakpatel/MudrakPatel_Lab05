// Fig. 19.13: StackInheritanceLibrary.cs
// Implementing a stack by inheriting from class List.
using System;
using LinkedListLibrary;

namespace StackInheritanceLibrary
{
   // class StackInheritance inherits class List's capabilities
   public class StackInheritance : CustomList
   {
      // pass name "stack" to List constructor
      public StackInheritance() : base("stack") { }

      // place dataValue at top of stack by inserting 
      // dataValue at front of linked list
      public void Push(double dataValue)
      {
         InsertAtFront(dataValue);
      }

      // remove item from top of stack by removing
      // item at front of linked list
      public double Pop()
      {
         return (double)(this.RemoveFromFront());
      }
        //////////////////////////////////
        //Methods written by Mudrak Patel
        //////////////////////////////////
        //Peek method
        public object Peek()
        {
            try
            {
                return this.firstNode.Data;
            }
            catch (EmptyListException exception)
            {
                System.Console.WriteLine("\n>>> Exception message: {0,2}\n", exception.Message);
                return null;
            }
            catch (Exception exception)
            {
                System.Console.WriteLine("\n>>> Exception message: {0,2}\n", exception.Message);
                return null;
            }
        }
   }
}

