using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12._2._1
{
    public class Node
    {
        public int Data;
        public Node Next;
        public Node(int data = 0)
        {
            Data = data;
            Next = null;
        }
    }
}
