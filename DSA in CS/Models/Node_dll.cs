using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_in_CS.Models
{
    public class Node_dll
    {
        public int value;
        public Node_dll next;
        public Node_dll previous;
        public Node_dll(int value)
        {
            this.value = value;
            this.next = null;
            this.previous = null;
        }
    }
}
