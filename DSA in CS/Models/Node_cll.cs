using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_in_CS.Models
{
    public class Node_cll
    {
        public int value;
        public Node_cll next;
        public Node_cll(int value)
        {
            this.value = value;
            this.next = null;
        }
    }
}
