using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedListProject
{
    class Demo
    {
        static void Main(string[] args)
        {
            int choice, data, k, x;

            SingleLinkedList list = new SingleLinkedList();

            list.CreateList();

            while (true)
            {
                Console.WriteLine("1. Display list");
                Console.WriteLine("2. Count nodes in the list");
                Console.WriteLine("3. Search node in the list");
                Console.WriteLine("4. Insert node in  the empty list/Insert at the beggining of  the list");
                Console.WriteLine("5. Insert at the end of the list");
                Console.WriteLine("6. Insert node after a particular node");
                Console.WriteLine("7. Insert node before a particular node");
                Console.WriteLine("8. Insert node at the particular position");
                Console.WriteLine("9. Delete first node");
                Console.WriteLine("10. Delete last node");
                Console.WriteLine("11. Delete particular node");
                Console.WriteLine("12. List reverse");
                Console.WriteLine("13. Bubble sort - data changes");
                Console.WriteLine("14. Bubble sort - link changes");
                Console.WriteLine("15. Merge two sorted list");
                Console.WriteLine("16. Merge Sort");
                Console.WriteLine("17. Quit");
                do
                    Console.Write("Enter your choice: ");
                while (!int.TryParse(Console.ReadLine(), out choice));
                if (choice == 17)
                    break;
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        list.DisplayList();
                        break;
                    case 2:
                        Console.Clear();
                        list.CountNodes();
                        break;
                    case 3:
                        Console.Clear();
                        do
                            Console.Write("Insert element you want to search: ");
                        while (!int.TryParse(Console.ReadLine(), out data));
                        list.Search(data);
                        break;
                    case 4:
                        Console.Clear();
                        do
                            Console.Write("Insert node: ");
                        while (!int.TryParse(Console.ReadLine(), out data));
                        list.InsertInBeginning(data);
                        break;
                    case 5:
                        Console.Clear();
                        do
                            Console.Write("Insert node: ");
                        while (!int.TryParse(Console.ReadLine(), out data));
                        list.InsertAtEnd(data);
                        break;
                    case 6:
                        Console.Clear();
                        do
                            Console.Write("Insert node: ");
                        while (!int.TryParse(Console.ReadLine(), out data));
                        do
                            Console.Write("Insert particular node: ");
                        while (!int.TryParse(Console.ReadLine(), out x));
                        list.InsertAfter(data, x);
                        break;
                    case 7:
                        Console.Clear();
                        do
                            Console.Write("Insert node: ");
                        while (!int.TryParse(Console.ReadLine(), out data));
                        do
                            Console.Write("Insert particular node: ");
                        while (!int.TryParse(Console.ReadLine(), out x));
                        list.InsertBefore(data, x);
                        break;
                    case 8:
                        Console.Clear();  
                        do
                            Console.Write("Insert node: ");
                        while (!int.TryParse(Console.ReadLine(), out data));
                        do
                            Console.Write("Insert position you want to insert on: ");
                        while (!int.TryParse(Console.ReadLine(), out k));
                        list.InsertAtPosition(data, k);
                        break;
                    case 9:
                        Console.Clear();
                        list.DeleteFirstNode();
                        break;
                    case 10:
                        Console.Clear();
                        list.DeleteLastNode();
                        break;
                    case 11:
                        Console.Clear();
                        do
                            Console.Write("Insert the node you want to delete: ");
                        while(!int.TryParse(Console.ReadLine(), out data));
                        list.DeleteNode(data);
                        break;
                    case 12:
                        Console.Clear();
                        list.ReverseList();
                        break;
                    case 13:
                        Console.Clear();
                        list.BubbleSortExData();
                        break;
                    case 14:
                        Console.Clear();
                        list.BubbleSortExLinks();
                        break;
                    case 15:
                        list.MergeList(list);
                        break;
                    case 16:
                        Console.Clear();
                        list.MergeSort();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Wrong choice! Try again!");
                        break;
                }
                Console.WriteLine();
            }
            Console.WriteLine("Exit");
        }
    }
}