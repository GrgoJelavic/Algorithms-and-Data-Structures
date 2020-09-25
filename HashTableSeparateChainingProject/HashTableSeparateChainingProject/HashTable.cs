using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableSeparateChainingProject
{
    class HashTable
    {
        private int m; //hash table size
        private int n; //number of buckets

        private SingleLinkedList[] array;

        public HashTable(int velicinaTablice)
        {
            this.m = velicinaTablice;
            this.n = 0;
            this.array = new SingleLinkedList[m];
        }

        private int hash(int key)
        {
            return key % m;
        }

        public void insert(Student temp)
        {
            int h = hash(temp.getOib());
            if (array[h] == null)
                array[h] = new SingleLinkedList();
            array[h].insertInBegin(temp);
            n++;
        }

        public void delete(int key)
        {
            int h = hash(key);
            if (array[h] != null)
            {
                array[h].deleteNode(key);
                n--;
            }
            else
                Console.WriteLine("Value: " + key + " is not found!");
        }

        public void displayTable()
        {
            for (int i = 0; i < m; i++)
            {
                if (array[i] != null)
                    array[i].displayList();
                else
                    Console.WriteLine("---Empty---");
            }
        }

        public void search(int key)
        {
            int h = hash(key);
            if (array[h] != null)
                array[h].search(key);
            else
                Console.WriteLine("Value: " + key + " is not found");

        }
    }
}
