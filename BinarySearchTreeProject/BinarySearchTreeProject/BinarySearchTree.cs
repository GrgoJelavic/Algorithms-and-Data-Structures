using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeProject
{
    class BinarySearchTree
    {
        private Node root;

        public BinarySearchTree()
        {
            root = null;
        }

        public BinarySearchTree(int data)
        {
            Node temp = new Node(data);
            root = temp;
        }

        public bool IsEmpty()
        {
            return (root == null);
        }

        public void Insert(int x)
        {
            root = Insert(root, x);
        }

        private Node Insert(Node p, int x)
        {
            if (p == null)
                p = new Node(x);
            else if (x < p.info)
                p.lchild = Insert(p.lchild, x);
            else if (x > p.info)
                p.rchild = Insert(p.rchild, x);
            else
                Console.WriteLine(x + " is already in the binary tree.");
            return p;
        }

        public bool Search(int x)
        {
            return (Search(root, x) != null);
        }

        private Node Search(Node p, int x)
        {
            if (p == null)
                return null;
            else if (x < p.info)
                return Search(p.lchild, x);
            else if (x > p.info)
                return Search(p.rchild, x);
            return p;
        }

        public void Delete(int x)
        {
            root = Delete(root, x);
        }

        private Node Delete(Node p, int x)
        {
            Node ch, s;
            if (p == null)
            {
                Console.WriteLine(x + " is not found in the binary tree.");
                return p;
            }
            if (x < p.info)
                p.lchild = Delete(p.lchild, x);
            else if (x > p.info)
                p.rchild = Delete(p.rchild, x);
            else
            {
                if (p.lchild != null && p.rchild != null)
                {
                    s = p.rchild;
                    while (s.lchild != null)
                        s = s.lchild;
                    p.info = s.info;
                    p.rchild = Delete(p.rchild, s.info);
                }
                else
                {
                    if (p.lchild != null)
                        ch = p.lchild;
                    else
                        ch = p.rchild;
                    p = ch;
                }
            }
            return p;
        }

        public int Min()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The binary tree is empty.");
                return 0;
            }
            return Min(root).info;
        }

        private Node Min(Node p)
        {
            if (p.lchild == null)
                return p;
            return Min(p.lchild);
        }

        public int Max()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The binary tree is empty.");
                return 0;
            }

            return Max(root).info;
        }
        private Node Max(Node p)
        {
            if (p.rchild == null)
                return p;
            return Max(p.rchild);
        }


        public void Display()
        {
            Display(root, 0);
            Console.WriteLine();
        }

        private void Display(Node p, int level)
        {
            int i;
            if (p == null)
                return;
            Display(p.rchild, level + 1);
            Console.WriteLine();
            for (i = 0; i < level; i++)
                Console.Write("   ");
            Console.Write(p.info);
            Display(p.lchild, level + 1);
        }

        public void Preorder()
        {
            Preorder(root);
            Console.WriteLine();
        }

        private void Preorder(Node p)
        {
            if (p == null)
                return;
            Console.Write(p.info + " ");
            Preorder(p.lchild);
            Preorder(p.rchild);
        }

        public void Inorder()
        {
            Inorder(root);
            Console.WriteLine();
        }

        private void Inorder(Node p)
        {
            if (p == null)
                return;
            Inorder(p.lchild);
            Console.Write(p.info + " ");
            Inorder(p.rchild);
        }

        public void Postorder()
        {
            Postorder(root);
            Console.WriteLine();
        }

        public void Postorder(Node p)
        {
            if (p == null)
                return;
            Postorder(p.lchild);
            Postorder(p.rchild);
            Console.Write(p.info + " ");
        }

        public int Height()
        {
            return Height(root);
        }

        private int Height(Node p)
        {
            if (p == null)
                return 0;
            int hL = Height(p.lchild);
            int hR = Height(p.rchild);
            if (hL > hR)
                return 1 + hL;
            else
                return 1 + hR;
        }
    }
}
