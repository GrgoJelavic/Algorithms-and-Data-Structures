using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice, x;

            QueueLinkedList queueL = new QueueLinkedList();

            while (true)
            {
                Console.WriteLine("\n1. Enqueue");
                Console.WriteLine("2. Dequeue");
                Console.WriteLine("3. Peek");
                Console.WriteLine("4. Display queue");
                Console.WriteLine("5. Display size");
                Console.WriteLine("6. Exit");
                do
                    Console.Write("\nEnter your choice: ");
                while (!int.TryParse(Console.ReadKey().KeyChar.ToString(), out choice));
                if (choice == 6)
                    break;
                Console.Clear();
                switch (choice)
                {
                    case 1:
                        do
                            Console.Write("Enqueue: ");
                        while (!int.TryParse(Console.ReadLine(), out x));
                        queueL.Insert(x);
                        break;
                    case 2:
                        x = queueL.Delete();
                        Console.WriteLine("Dequeue: " + x);
                        break;
                    case 3:
                        Console.WriteLine("Peek: " + queueL.Peek());
                        break;
                    case 4:
                        queueL.Display();
                        break;
                    case 5:
                        Console.WriteLine("Queue size: " + queueL.Size());
                        break;
                    default:
                        Console.WriteLine("Wrong choice! Try again!");
                        break;
                }
            }
        }
    }
}
