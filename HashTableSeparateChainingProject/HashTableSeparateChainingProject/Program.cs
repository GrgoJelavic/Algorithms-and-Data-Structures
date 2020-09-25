using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableSeparateChainingProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stud1 = new Student(1, "John Snow");
            Student stud2 = new Student(11, "Mark Veron");
            Student stud3 = new Student(10, "Anne Duncan");
            HashTable table = new HashTable(10);
            table.insert(stud1);
            table.insert(stud2);
            table.insert(stud3);
            table.displayTable();
            Console.WriteLine();
            table.delete(1);
            table.displayTable();
            table.search(1);
            table.search(11);
        }
    }
}
