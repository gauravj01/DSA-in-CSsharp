using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_in_CS.Sorting
{
    internal class InsertionSort
    {
        public int[] InsertionSortArray(int[] myArray)
        {
            int length = myArray.Length;
            
            for(int i=1; i < length; i++)
            {
                int j = i;
                int key = myArray[j];

                while (j > 0 && myArray[j - 1] > key)
                {
                    myArray[j] = myArray[j - 1];
                    j--;
                }

                myArray[j] = key;
            }

            return myArray;
        }
    }
}
