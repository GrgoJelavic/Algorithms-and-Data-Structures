using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableSeparateChainingProject
{
    class Student
    {
        private int oib;
        private String ImePrezime;

        public Student(int oib, String imePrezime)
        {
            this.oib = oib;
            this.ImePrezime = imePrezime;
        }

        public int getOib()
        {
            return oib;
        }

        public String getImePrezime()
        {
            return ImePrezime;
        }

        public string toString()
        {
            return oib + " " + ImePrezime;
        }
    }
}
