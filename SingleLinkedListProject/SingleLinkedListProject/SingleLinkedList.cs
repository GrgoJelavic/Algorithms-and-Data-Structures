using System;
using System.Collections.Generic;
using System.Text;

namespace SingleLinkedListProject
{

    class SingleLinkedList
    {
        private Node start;

        public SingleLinkedList()
        {
            start = null;
        }

        public void DisplayList()
        {
            Node p;
            if (start == null)
                Console.WriteLine("Empty list!");
            else
            {
                Console.Write("The list is: ");
                p = start;
                while (p != null)
                {
                    Console.Write(p.info + " ");
                    p = p.link;
                }
                Console.WriteLine();
            }
        }

        public void CountNodes()
        {
            int n = 0;
            Node p = start;
            while (p != null)
            {
                n++;
                p = p.link;
            }
            Console.WriteLine("Number of the nodes in the list is:" + n);
        }

        public bool Search(int x)
        {
            int position = 1;
            Node p = start;
            while (p != null)
            {
                if (p.info == x)
                    break;
                position++;
                p = p.link;
            }
            if (p == null)
            {
                Console.WriteLine(x + " is not in the list!");
                return false;
            }
            else
            {
                Console.WriteLine(x + " is on position: " + position);
                return true;
            }
        }

        public void InsertInBeginning(int data)
        {
            Node temp = new Node(data);
            temp.link = start;
            start = temp;
        }

        public void InsertAtEnd(int data)
        {
            Node p;
            Node temp = new Node(data);
            if (start == null)
            {
                start = temp;
                return;
            }
            p = start;
            while (p.link != null)
                p = p.link;
            p.link = temp;
        }

        public void CreateList()
        {
            int i, n, data;
            do
                Console.Write("Insert number of nodes you want in the list : ");
            while (!int.TryParse(Console.ReadLine(), out n) || n < 1);

            if (n == 0)
                return;
            for (i = 1; i <= n; i++)
            {
                do
                {
                    Console.Write("Insert node data: ");
                } while (!int.TryParse(Console.ReadLine(), out data)); 
                InsertAtEnd(data);
            }
        }

        public void InsertAfter(int data, int x)
        {
            Node p = start;
            while (p != null)
            {
                if (p.info == x)
                    break;
                p = p.link;
            }
            if (p == null)
                Console.WriteLine(x + " is not in the list.");
            else
            {
                Node temp = new Node(data);
                temp.link = p.link;
                p.link = temp;
            }
        }

        public void InsertBefore(int data, int x)
        {
            Node temp;
            if (start == null)
            {
                Console.WriteLine("The list is empty!");
                return;
            }
            if (x == start.info)
            {
                temp = new Node(data);
                temp.link = start;
                start = temp;
                return;
            }
            Node p = start;
            while (p.link != null)
            {
                if (p.link.info == x)
                    break;
                p = p.link;
            }   
            if (p.link == null)
                Console.WriteLine(x + " is not in the list.");
            else
            {
                temp = new Node(data);
                temp.link = p.link;
                p.link = temp;
            }
        }

        public void InsertAtPosition(int data, int k)
        {
            Node temp;
            int i;
            if (k == 1)
            {
                temp = new Node(data);
                temp.link = start;
                start = temp;
                return;
            }
            Node p = start;
            for (i = 1; i < k - 1 && p != null; i++) 
                p = p.link;
            if (p == null)
                Console.WriteLine("You can insert node data until position: " + i );
            else
            {
                temp = new Node(data);
                temp.link = p.link;
                p.link = temp;
            }

        }

        public void DeleteFirstNode()
        {
            if (start == null)
                return;
            start = start.link;
        }

        public void DeleteLastNode()
        {
            if (start == null)
                return;
            if (start.link == null)
            {
                start = null;
                return;
            }
            Node p = start;
            while (p.link.link != null)
                p = p.link;
            p.link = null;
        }

        public void DeleteNode(int x)
        {
            if (start == null)
            {
                Console.WriteLine("The list is empty!\n");
                return;
            }
            if (start.info == x)
            {
                start = start.link;
                return;
            }
            Node p = start;
            while (p.link != null)
            {
                if (p.link.info == x)
                    break;
                p = p.link;
            }
            if (p.link == null)
                Console.WriteLine("Node " + x + " is not in the list.");
            else
                p.link = p.link.link;
        }

        public void ReverseList()
        {
            Node prev, p, next;
            prev = null;
            p = start;
            while (p != null)
            {
                next = p.link;
                p.link = prev;
                prev = p;
                p = next;
            }
            start = prev;
        }

        public void BubbleSortExData()
        {
            Node end, p, q;
            for (end = null; end != start.link; end = p)
            {
                for (p = start; p.link != end; p = p.link)
                {
                    q = p.link;
                    if (p.info > q.info)
                    {
                        int temp = p.info;
                        p.info = q.info;
                        q.info = temp;
                    }
                }
            }
        }

        public void BubbleSortExLinks()
        {
            Node end, r, p, q, temp;
            for (end = null; end != start.link; end = p)
            {
                for (r = p = start; p.link != end; r = p, p = p.link)
                {
                    q = p.link;
                    if (p.info > q.info)
                    {
                        p.link = q.link;
                        q.link = p;
                        if (p != start)
                            r.link = q;
                        else
                            start = q;
                        temp = p;
                        p = q;
                        q = temp;
                    }
                }
            }
        }

        public SingleLinkedList Merge1(SingleLinkedList list)
        {
            SingleLinkedList mergelist = new SingleLinkedList();
            mergelist.start = Merge1(start, list.start);
            return mergelist;
        }
        private Node Merge1(Node p1, Node p2)
        {
            Node startM;
            if (p1.info <= p2.info)
            {
                startM = new Node(p1.info);
                p1 = p1.link;
            }
            else
            {
                startM = new Node(p2.info);
                p2 = p2.link;
            }
            Node pM = startM;
            while (p1 != null && p2 != null)
            {
                if (p1.info <= p2.info)
                {
                    pM.link = new Node(p1.info);
                    p1 = p1.link;
                }
                else
                {
                    pM.link = new Node(p2.info);
                    p2 = p2.link;
                }
                pM = pM.link;
            }
            while (p1 != null)
            {
                pM.link = new Node(p1.info);
                p1 = p1.link;
                pM = pM.link;
            }
            while (p2 != null)
            {
                pM.link = new Node(p2.info);
                p2 = p2.link;
                pM = pM.link;
            }
            return startM;
        }

        private Node Merge2(Node p1, Node p2)
        {
            Node startM;
            if (p1.info <= p2.info)
            {
                startM = p1;
                p1 = p1.link;
            }
            else
            {
                startM = p2;
                p2 = p2.link;
            }
            Node pM = startM;
            while (p1 != null && p2 != null)
            {
                if (p1.info <= p2.info)
                {
                    pM.link = p1;
                    pM = pM.link;
                    p1 = p1.link;
                }
                else
                {
                    pM.link = p2;
                    pM = pM.link;
                    p2 = p2.link;
                }
            }
            if (p1 == null)
                pM.link = p2;
            else
                pM.link = p1;
            return startM;
        }

        public void MergeList(SingleLinkedList list1)
        {

            SingleLinkedList list2 = new SingleLinkedList();

            list2.CreateList();
            list1.BubbleSortExData();
            list2.BubbleSortExData();

            Console.WriteLine("Prva lista .... "); list1.DisplayList();
            Console.WriteLine("Druga lista ...."); list2.DisplayList();

            SingleLinkedList list3;
            list3 = list1.Merge1(list2);
            Console.WriteLine("Spojena lista...."); list3.DisplayList();
        }

        public void MergeSort()
        {
            start = MergeSortRec(start);
        }

        public Node MergeSortRec(Node listStart)
        {
            if (listStart == null || listStart.link == null) 
                return listStart;
            Node start1 = listStart;
            Node start2 = DivideList(listStart);
            start1 = MergeSortRec(start1);
            start2 = MergeSortRec(start2);
            Node startM = Merge2(start1, start2);
            return startM;
        }

        private Node DivideList(Node p)
        {
            Node q = p.link.link;
            while (q != null && q.link != null)
            {
                p = p.link;
                q = q.link.link;
            }
            Node start2 = p.link;
            p.link = null;
            return start2;
        }
    }
}
