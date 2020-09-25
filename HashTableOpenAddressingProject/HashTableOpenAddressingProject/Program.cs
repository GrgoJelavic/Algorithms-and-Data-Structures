using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableOpenAddressingProject
{
    class Program
    {
        static void Main(string[] args)
        {
            HashTable table = new HashTable(5);
            Student stud1 = new Student(1, "Alex Adams");
            Student stud2 = new Student(2, "John Davis");
            Student stud3 = new Student(3, "Mary Evans");
            Student stud4 = new Student(4, "Patricia Lopez");
            Student stud5 = new Student(6, "Robert Irwin");
            Student stud6 = new Student(4567, "Test Test");
            table.insert(stud1);
            table.insert(stud2);
            table.displayTable();
            Console.WriteLine();
            table.insert(stud3);
            table.displayTable();
            Console.WriteLine();
            table.insert(stud4);
            table.displayTable();
            Console.WriteLine();
            table.insert(stud5);
            table.displayTable();
            Console.WriteLine();
            table.insert(stud5);
            table.displayTable();
            Student temp = table.delete(4);
            Console.WriteLine("Deleted: " + temp.getOib() + " " + temp.getImePrezime());
            Console.WriteLine();
            table.displayTable();
            Console.WriteLine();
            table.insert(stud5);
            table.displayTable();
            Student temp2 = table.search(43);
            if (temp2 != null)
                Console.WriteLine("Student with key: " + temp2.getOib() + " is called " + temp2.getImePrezime());
            else
                Console.WriteLine("Student is not found in the table");
            Console.ReadKey();
        }
    }
}
