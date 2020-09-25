using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree binaryTree = new BinarySearchTree();
            int choice, x;

            while (true)
            {
                Console.WriteLine("1. Display");
                Console.WriteLine("2. Search");
                Console.WriteLine("3. Insert");
                Console.WriteLine("4. Delete");
                Console.WriteLine("5. Preorder traversal");
                Console.WriteLine("6. Inorder traversal");
                Console.WriteLine("7. Postorder traversal");
                Console.WriteLine("8. Height");
                Console.WriteLine("9. Search min");
                Console.WriteLine("10. Search max");
                Console.WriteLine("11. Exit");
                do
                    Console.Write("Enter your choice: ");
                while (!int.TryParse(Console.ReadLine(), out choice));
                if (choice == 11)
                    break;
                Console.Clear();
                switch (choice)
                {
                    case 1:
                        binaryTree.Display();
                        break;
                    case 2:
                        do
                            Console.Write("Insert value you want to search: ");
                        while (!int.TryParse(Console.ReadLine(), out x));
                        if (binaryTree.Search(x))
                            Console.WriteLine("The value is not found");
                        else
                            Console.WriteLine("The value is not found");
                        break;
                    case 3:
                        do
                            Console.Write("Inserv value: ");
                        while (!int.TryParse(Console.ReadLine(), out x));
                        binaryTree.Insert(x);
                        break;
                    case 4:
                        do
                            Console.Write("Delete value: ");
                        while (!int.TryParse(Console.ReadLine(), out x));
                        binaryTree.Delete(x);
                        break;
                    case 5:
                        binaryTree.Preorder();
                        break;
                    case 6:
                        binaryTree.Inorder();
                        break;
                    case 7:
                        binaryTree.Postorder();
                        break;
                    case 8:
                        Console.WriteLine("Height: " + binaryTree.Height());
                        break;
                    case 9:
                        Console.WriteLine("Minimum value: " + binaryTree.Min());
                        break;
                    case 10:
                        Console.WriteLine("Maximum value: " + binaryTree.Max());
                        break;
                }
            }
        }
    }
}
