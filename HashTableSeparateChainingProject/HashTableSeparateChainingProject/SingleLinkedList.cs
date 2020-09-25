using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableSeparateChainingProject
{
    class SingleLinkedList
    {
        private Node start;

        public SingleLinkedList()
        {
            start = null;
        }

        public void insertInBegin(Student student)
        {
            Node temp = new Node(student);
            temp.link = start;
            start = temp;
        }

        public void displayList()
        {
            if (start == null)
                Console.WriteLine("---Empty---");
            else
            {
                Node p = start;
                while (p != null)
                {
                    Console.Write(p.info.toString() + " ");
                    p = p.link;
                }
            }
        }

        public void deleteNode(int key)
        {
            if (start == null)
            {
                Console.WriteLine("Value: " + key + " is not found!");
                return;
            }
            if (start.info.getOib() == key)
            {
                start = start.link;
                return;
            }
            Node p = start;
            while (p.link != null)
            {
                if (p.link.info.getOib() == key)
                    break;
                p = p.link;
            }
            if (p.link == null)
                Console.WriteLine("Value: " + key + " is not found!");
            else
                p.link = p.link.link;
        }

        public void search(int key)
        {
            Node p = start;
            while (p != null)
            {
                if (p.info.getOib() == key)
                    break;
                p = p.link;
            }
            if (p == null)
                Console.WriteLine("Value: " + key + " is not found!");
            else
                Console.WriteLine("Value: " + key + " is not found!");
        }
    }
}
