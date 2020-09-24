using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularLSingleLinkedListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice, data, x;

            CircularLinkedList List = new CircularLinkedList();

            List.CreateList();

            while (true)
            {
                Console.WriteLine("\n1. Display list");
                Console.WriteLine("2. Insert node in the empty list");
                Console.WriteLine("3. Insert node at the beginning of the list");
                Console.WriteLine("4. Insert node at the end of the list");
                Console.WriteLine("5. Insert node after particular node");
                Console.WriteLine("6. Delete the first node");
                Console.WriteLine("7. Delete the last node");
                Console.WriteLine("8. Delete particular node");
                Console.WriteLine("9. Exit");
                do
                    Console.WriteLine("\nEnter your choice: ");
                while (!int.TryParse(Console.ReadKey().KeyChar.ToString(), out choice));
                Console.Clear();
                if (choice == 9)
                    break;
                switch (choice)
                {
                    case 1:
                        List.DisplayList();
                        break;
                    case 2:
                        do
                        Console.WriteLine("Insert new node: ");
                        while (!int.TryParse(Console.ReadLine(), out data));
                        List.InsertInEmptyList(data);
                        break;
                    case 3:
                        do
                            Console.WriteLine("Insert new node: ");
                        while (!int.TryParse(Console.ReadLine(), out data));
                        List.InsertInBeginning(data);
                        break;
                    case 4:
                        do
                            Console.WriteLine("Insert new node: ");
                        while (!int.TryParse(Console.ReadLine(), out data));
                        List.InsertAtEnd(data);
                        break;
                    case 5:
                        do
                            Console.WriteLine("Insert new node: ");
                        while (!int.TryParse(Console.ReadLine(), out data));
                        do
                        Console.WriteLine("Insert particular node: ");
                        while (!int.TryParse(Console.ReadLine(), out x));
                        List.InsertAfter(data, x);
                        break;
                    case 6:
                        List.DeleteFirstNode();
                        break;
                    case 7:
                        List.DeleteLastNode();
                        break;
                    case 8:
                        do
                            Console.WriteLine("Insert node you want to delete: ");
                        while(!int.TryParse(Console.ReadLine(), out data));   
                        List.DeleteNode(data);
                        break;
                    default:
                        Console.WriteLine("Wrong choice");
                        break;
                }
                Console.WriteLine();
            }
            Console.WriteLine("Exit");
        }
    }
}
