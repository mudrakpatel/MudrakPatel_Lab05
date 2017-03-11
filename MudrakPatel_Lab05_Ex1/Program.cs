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
            /////////////////////////////
            //Code given by teacher
            #region oldCode
            //var list = new CustomList(); // create List container

            //// create data to store in List
            //double[] doubleArray = { };

            ////// use List insert methods       
            ////list.InsertAtFront(aBoolean);
            ////list.Display();
            ////list.InsertAtFront(aCharacter);
            ////list.Display();
            ////list.InsertAtBack(anInteger);
            ////list.Display();
            ////list.InsertAtBack(aString);
            ////list.Display();

            //for (int index = 0; index < 12 ; index++)
            //{
            //    //doubleArray[index] = index;
            //    list.AddFirst(new LinkedListNode<double>(index));
            //}

            //// remove data from list and display after each removal
            //try
            //{
            //    object removedObject = list.RemoveFromFront();
            //    Console.WriteLine($"{removedObject} removed");
            //    list.Display();

            //    removedObject = list.RemoveFromFront();
            //    Console.WriteLine($"{removedObject} removed");
            //    list.Display();

            //    removedObject = list.RemoveFromBack();
            //    Console.WriteLine($"{removedObject} removed");
            //    list.Display();

            //    removedObject = list.RemoveFromBack();
            //    Console.WriteLine($"{removedObject} removed");
            //    list.Display();
            //}
            //catch (EmptyListException emptyListException)
            //{
            //    Console.Error.WriteLine($"\n{emptyListException}");
            //}
            #endregion
            /////////////////////////////
            var doubleList = new CustomList();
            var node1 = new CustomListNode(1.0, null);
            //var node2 = new CustomListNode(2.0, node1);
            //var node3 = new CustomListNode(3.0, node2);
            //var node4 = new CustomListNode(4.0, node3);
            //var node5 = new CustomListNode(5.0, node4);
            //var node6 = new CustomListNode(6.0, node1);
            Console.WriteLine("\n>>> Display method called...\n"); //Display method
            doubleList.Display();
            Console.WriteLine("\n >>> The count of the list is: {0,2}\n", CustomList.Count(doubleList));
        }
    }
}
