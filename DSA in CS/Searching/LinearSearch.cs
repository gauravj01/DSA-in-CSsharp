using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_in_CS.Searching
{
    internal class LinearSearch
    {
        public int LinearSearchValue(int[] myArray, int value)
        {
            int index = -1;
            int length = myArray.Length;

            for (int i = 0; i < length; i++)
            {
                if (myArray[i] == value)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
    }
}
