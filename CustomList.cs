using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListLibrary
{
    public class CustomList : LinkedList<double>
    {
        // class CustomList declaration
        //
        public CustomListNode firstNode { get; private set; }
        public CustomListNode lastNode { get; private set; }
        private string name; // string like "list" to display
        public int count { get; private set; } // count property of the list
        // construct empty CustomList with specified name
        public CustomList(string listName)
        {
            name = listName;
            firstNode = lastNode = null;
            count = 0;
        }

        // construct empty CustomList with "list" as its name 
        public CustomList() : this("list") { count = 0; }

        // Insert object at front of CustomList. If CustomList is empty, 
        // firstNode and lastNode will refer to same object.
        // Otherwise, firstNode refers to new node.
        public void InsertAtFront(double insertItem)
        {
            if (IsEmpty())
            {
                firstNode = lastNode = new CustomListNode(insertItem);
                count = count + 1;
            }
            else
            {
                firstNode = new CustomListNode(insertItem, firstNode);
                count = count + 1;
            }
        }
        // Insert object at end of CustomList. If CustomList is empty, 
        // firstNode and lastNode will refer to same object.
        // Otherwise, lastNode's Next property refers to new node.
        public void InsertAtBack(double insertItem, string inputStringData = "")
        {
            if (inputStringData.Equals(""))
            {
                if (IsEmpty())
                {
                    firstNode = lastNode = new CustomListNode(insertItem);
                    count = count + 1;
                }
                else
                {
                    lastNode = lastNode.Next = new CustomListNode(insertItem);
                    count = count + 1;
                }
            }
            else
            {
                if (IsEmpty())
                {
                    firstNode = lastNode = new CustomListNode(inputStringData);
                    count = count + 1;
                }
                else
                {
                    lastNode = lastNode.Next = new CustomListNode(inputStringData);
                    count = count + 1;
                }
            }
        }

        // remove first node from CustomList
        public double RemoveFromFront()
        {
            if (IsEmpty())
            {
                throw new EmptyListException(name);
            }

            var removedItemNode = firstNode;
            var removedItemData = firstNode.doubleData; // retrieve data

            // reset firstNode and lastNode references
            if (firstNode == lastNode)
            {
                firstNode = lastNode = null;
                count = count - 1;
            }
            else
            {
                firstNode = firstNode.Next;
                count = count - 1;
            }

            return removedItemData; // return removed data
        }

        ///
        //RemoveFromFront method string return version
        public string RemoveStringFromFront()
        {
            if (IsEmpty())
            {
                throw new EmptyListException(name);
            }

            var removedItemNode = firstNode;
            var removedItemData = firstNode.stringData; // retrieve data

            // reset firstNode and lastNode references
            if (firstNode == lastNode)
            {
                firstNode = lastNode = null;
                count = count - 1;
            }
            else
            {
                firstNode = firstNode.Next;
                count = count - 1;
            }

            return removedItemData; // return removed data
        }
        // remove last node from CustomList
        public object RemoveFromBack()
        {
            if (IsEmpty())
            {
                throw new EmptyListException(name);
            }

            var removedItemNode = lastNode;
            var removedItemData = lastNode.doubleData; // retrieve data

            // reset firstNode and lastNode references
            if (firstNode == lastNode)
            {
                firstNode = lastNode = null;
                count = count - 1;
            }
            else
            {
                CustomListNode current = firstNode;

                // loop while current.Next is not lastNode
                while (current.Next != lastNode)
                {
                    current = current.Next; // move to next node
                }

                // current is new lastNode
                lastNode = current;
                current.Next = null;
                count = count - 1;
            }

            return removedItemNode; // return removed data
        }

        // return true if CustomList is empty
        public bool IsEmpty()
        {
            return firstNode == null;
        }

        // output CustomList contents
        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine($"Empty {name}");
            }
            else
            {
                Console.Write($"The {name} is: ");

                CustomListNode current = firstNode;

                // output current node data while not at end of list
                while (current != null)
                {
                    Console.Write($"{current.doubleData} ");
                    current = current.Next;
                }

                Console.WriteLine("\n");
            }
        }
        //Overloaded Display method
        public void StringListDisplay()
        {
            if (IsEmpty())
            {
                Console.WriteLine($"Empty {name}");
            }
            else
            {
                Console.Write($"The {name} is: ");

                CustomListNode current = firstNode;

                // output current node data while not at end of list
                while (current != null)
                {
                    Console.Write($"{current.stringData} ");
                    current = current.Next;
                }

                Console.WriteLine("\n");
            }
        }
        //
        //Search method
        public void Search(double searchValue)
        {
            try
            {
                var tempNode = firstNode;
                while (tempNode != null)
                {
                    if (tempNode.doubleData.Equals(searchValue))
                    {
                        Console.WriteLine("\n--- Item found: {0,2}\n", tempNode.doubleData);
                        break;
                    }
                    tempNode = tempNode.Next;
                }
            }
            catch (EmptyListException exception)
            {
                Console.WriteLine("\n--- {0,2}\n", exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine("\n--- {0,2}\n", exception.Message);
            }
        }
        //
        //Count method
        public static int Count(CustomList inputList)
        {
            try
            {
                return inputList.count;
            }
            catch (EmptyListException exception)
            {
                Console.WriteLine("\n--- {0,2}\n", exception.Message);
                return 0;
            }
            catch (Exception exception)
            {
                Console.WriteLine("\n--- {0,2}\n", exception.Message);
                return 0;
            }
        }
    }
    //////////////////////////////////////
    public class CustomListNode : LinkedList<double>
    {
        // class to represent one node in a list
        //
        // automatic read-only property doubleData
        public double doubleData { get; private set; }
        public string stringData { get; private set; }

        // automatic property Next
        public CustomListNode Next { get; set; }

        // constructor to create CustomListNode that refers to dataValue
        // and is last node in list
        public CustomListNode(double dataValue) : this(dataValue, null) { }

        public CustomListNode(string stringDataValue) : this(stringDataValue, null) { }

        // constructor to create CustomListNode that refers to dataValue
        // and refers to next CustomListNode in CustomList
        public CustomListNode(double dataValue, CustomListNode nextNode)
        {
            doubleData = dataValue;
            Next = nextNode;
        }
        //
        //Another constructor for string type data
        public CustomListNode(string StringData, CustomListNode nextNode)
        {
            stringData = StringData;
            Next = nextNode;
        }
    }
}
