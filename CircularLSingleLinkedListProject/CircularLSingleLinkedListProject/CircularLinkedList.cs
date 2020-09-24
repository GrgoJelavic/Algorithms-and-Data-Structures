using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularLSingleLinkedListProject
{
    class CircularLinkedList
    {
        private Node last;

        public CircularLinkedList()
        {
            last = null;
        }

        public void DisplayList()
        {
            if (last == null)
                Console.WriteLine("The list is empty!\n");
            else
            {
                Node p = last.link;
                do
                {
                    Console.Write(p.info + " ");
                    p = p.link;
                } while (p != last.link);
                Console.WriteLine();
            }
        }

        public void InsertInBeginning(int data)
        {
            Node temp = new Node(data);
            temp.link = last.link;
            last.link = temp;
        }

        public void InsertInEmptyList(int data)
        {
            Node temp = new Node(data);
            last = temp;
            last.link = last;
        }

        public void InsertAtEnd(int data)
        {
            Node temp = new Node(data);
            temp.link = last.link;
            last.link = temp;
            last = temp;
        }

        public void CreateList()
        {
            int i, n, data;
            do
                Console.Write("Insert number of nodes you want in the list: ");
            while (!int.TryParse(Console.ReadLine(), out n));
            if (n == 0)
                return;
            do
                Console.Write("Insert first node: ");
            while (!int.TryParse(Console.ReadLine(), out data));
            InsertInEmptyList(data);

            for (i = 2; i <= n; i++)
            {
                Console.Write("Insert next node: ");
                data = Convert.ToInt32(Console.ReadLine());
                InsertAtEnd(data);
            }
        }

        public void InsertAfter(int data, int x)
        {
            Node p = last.link;
            do
            {
                if (p.info == x)
                    break;
                p = p.link;
            } while (p != p.link);

            if (p == last.link && p.info != x)
                Console.WriteLine(x + " is not in the list.");
            else
            {
                Node temp = new Node(data);
                temp.link = p.link;
                p.link = temp;
                if (p == last)
                    last = temp;
            }
        }

        public void DeleteFirstNode()
        {
            if (last == null) 
                return;
            if (last.link == last) 
            {
                last = null;
                return;
            }
            last.link = last.link.link;
        }

        public void DeleteLastNode()
        {
            if (last == null) 
                return;
            if (last.link == last)
                last = null;
            else
            {
                Node p = last.link;
                while (p.link != last)
                    p = p.link;
                p.link = last.link;
                last = p;
            }         
        }

        public void DeleteNode(int x)
        {
            if (last == null) 
                return;
            if (last.link == last && last.info == x) 
            {
                last = null;
                return;
            }
            if (last.link.info == x) 
            {
                last.link = last.link.link;
                return;
            }
            Node p = last.link;
            while (p.link != last.link)
            {
                if (p.link.info == x)
                    break;
                p = p.link;
            }
            if (p.link == last.link)
                Console.WriteLine(x + " is not  in the list.");
            else
            {
                p.link = p.link.link;
                if (last.info == x)
                    last = p;
            }
        }
    }
}
