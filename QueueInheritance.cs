﻿// Fig. 19.16: QueueInheritanceLibrary.cs
// Implementing a queue by inheriting from class List.
using System;
using LinkedListLibrary;

namespace QueueInheritanceLibrary
{
   // class QueueInheritance inherits List's capabilities
   public class QueueInheritance : CustomList
   {
       public int count { get; private set; }
      // pass name "queue" to List constructor
      public QueueInheritance() : base("queue") { }

      // place dataValue at end of queue by inserting 
      // dataValue at end of linked list
      public void Enqueue(string dataValue)
      {
         InsertAtBack(1, dataValue);
            count = count + 1; //might cause logical error
      }

      // remove item from front of queue by removing
      // item at front of linked list
      public string Dequeue()
      {
            count = count + 1; //might cause logical error
            return RemoveStringFromFront();
      }
   }
}

