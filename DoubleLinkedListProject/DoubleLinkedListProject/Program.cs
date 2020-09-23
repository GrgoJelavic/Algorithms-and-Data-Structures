using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice, data, x;
            DoubleLinkedList list = new DoubleLinkedList();
            list.CreateList();
            while (true)
            {
                Console.WriteLine("1. Display list");
                Console.WriteLine("2. Insert in empty list");
                Console.WriteLine("3. Insert at the beginning of the list");
                Console.WriteLine("4. Insert at the end of the list");
                Console.WriteLine("5. Insert node after particular node");
                Console.WriteLine("6. Insert node before particular node");
                Console.WriteLine("7. Delete first node");
                Console.WriteLine("8. Delete last node");
                Console.WriteLine("9. Delete particualr node");
                Console.WriteLine("10. The list reverse");
                Console.WriteLine("11. Exit");
                do
                    Console.WriteLine("Enter your choice: ");
                while (!int.TryParse(Console.ReadLine(), out choice));
                if (choice == 11)
                    break;
                Console.Clear();
                switch (choice)
                {

                    case 1:
                        list.DisplayList();
                        break;
                    case 2:
                        do
                            Console.WriteLine("Insert node: ");
                        while (!int.TryParse(Console.ReadLine(), out data));
                        list.InsertInEmptyList(data);
                        break;
                    case 3:
                        do
                            Console.WriteLine("Insert node: ");
                        while (!int.TryParse(Console.ReadLine(), out data));
                        list.InsertInBeginning(data);
                        break;
                    case 4:
                        do
                            Console.WriteLine("Insert node: ");
                        while (!int.TryParse(Console.ReadLine(), out data));
                        list.InsertAtEnd(data);
                        break;
                    case 5:
                        do
                            Console.WriteLine("Insert node: ");
                        while (!int.TryParse(Console.ReadLine(), out data));
                        do
                            Console.WriteLine("Insert node after a particular node: ");
                        while (!int.TryParse(Console.ReadLine(), out x));
                        list.InsertAfter(data, x);
                        break;
                    case 6:
                        do
                            Console.WriteLine("Insert node: ");
                        while (!int.TryParse(Console.ReadLine(), out data));
                        do
                            Console.WriteLine("Insert node before a particular node: ");
                        while (!int.TryParse(Console.ReadLine(), out x));
                        list.InsertAfter(data, x);
                        break;
                    case 7:
                        list.DeleteFirstNode();
                        break;
                    case 8:
                        list.DeleteLastNode();
                        break;
                    case 9:
                        do
                            Console.WriteLine("Delete node: ");
                        while (!int.TryParse(Console.ReadLine(), out data));
                        list.DeleteNode(data);
                        break;
                    case 10:
                        list.ReverseList();
                        break;
                    default:
                        Console.WriteLine("Wrong choice! Try again!");
                        break;

                }
                Console.WriteLine();
            }
            Console.WriteLine("Exit");
        }
    }
}
