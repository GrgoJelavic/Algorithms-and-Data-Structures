using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableSeparateChainingProject
{
    class Node
    {
        public Student info;
        public Node link;

        public Node(Student info)
        {
            this.info = info;
            this.link = null;
        }
    }
}
