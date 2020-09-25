using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableOpenAddressingProject
{
    class HashTable
    {
        private Student[] array;
        private int m; //number of buckets
        private int n; //number of entries occupied in the hash table

        public HashTable(int tableSize)
        {
            this.m = tableSize;
            array = new Student[m];
            n = 0;
        }

        private int hash(int key)
        {
            int temp = key % m;
            return temp;
        }

        public void insert(Student student)
        {
            int key = student.getOib(); 
            int h = hash(key);
            int location = h;
            for (int i = 0; i < m; i++)
            {
                if (array[location] == null || array[location].getOib() == -1)
                {
                    array[location] = student;
                    n++;
                    return;
                }
                if (array[location].getOib() == key)
                {
                    Console.WriteLine("The double key!");
                    return;
                }
                h++;
                location = h % m;
            }
            Console.WriteLine("There is no space in the table");
        }

        public Student delete(int key)
        {
            int h = hash(key);
            int location = h;
            for (int i = 0; i < m; i++)
            {
                if (array[location] == null)
                {
                    return null;
                }
                if (array[location].getOib() == key)
                {
                    Student temp = array[location];
                    temp.setOib(-1); 
                    n--;
                    return temp;
                }
                h++;
                location = h % m;
            }
            return null;
        }

        public void displayTable()
        {
            for (int i = 0; i < m; i++)
            {
                if (array[i] != null && array[i].getOib() != -1)        
                    Console.WriteLine(array[i].getOib() + " " + array[i].getImePrezime());
                else
                    Console.WriteLine("---Empty---");
            }
        }

        public Student search(int key)
        {
            int h = hash(key);
            int location = h;
            for (int i = 0; i < m; i++)
            {
                if (array[location] == null)
                    return null;
                if (array[location].getOib() == key)
                    return array[location];
                h++;
                location = h % m;
            }
            return null;
        }
    }
}
