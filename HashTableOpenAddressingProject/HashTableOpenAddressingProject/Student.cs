using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableOpenAddressingProject
{
    class Student
    {
        private int oib; 
        private String imePrezime;

        public Student(int oib, String imePrezime)
        {
            this.oib = oib;
            this.imePrezime = imePrezime;
        }

        public int getOib()
        {
            return oib;
        }

        public void setOib(int oib)
        {
            this.oib = oib;
        }

        public String getImePrezime()
        {
            return imePrezime;
        }
    }
}
