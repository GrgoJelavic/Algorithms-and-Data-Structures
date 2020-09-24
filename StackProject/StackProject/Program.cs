using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice, x;
            StackLinkedList stackL = new StackLinkedList();

            while (true)
            {
                Console.WriteLine("1. Push element");
                Console.WriteLine("2. Pop element");
                Console.WriteLine("3. Peek");
                Console.WriteLine("4. Display elements");
                Console.WriteLine("5. Display size");
                Console.WriteLine("6. Exit");
                do
                    Console.WriteLine("\nEnter your choice: ");
                while (!int.TryParse(Console.ReadKey().KeyChar.ToString(), out choice));
                if (choice == 6)
                    break;
                Console.Clear();
                switch (choice)
                {
                    case 1:
                        do
                            Console.Write("Push element: ");
                        while (!int.TryParse(Console.ReadLine(), out x));
                        stackL.Push(x);
                        break;
                    case 2:
                        do
                            Console.Write("Pop element: ");
                        while (!int.TryParse(Console.ReadLine(), out x));
                        stackL.Pop();
                        break;
                    case 3:
                        Console.WriteLine("Peek: " + stackL.Peek());
                        break;
                    case 4:
                        stackL.Display();
                        break;
                    case 5:
                        Console.WriteLine("Stack size: " + stackL.Size());
                        break;
                    default:
                        Console.WriteLine("Wrong choice! Try again!");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
    
}
