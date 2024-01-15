using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_in_CS.Sorting
{
    internal class BubbleSort
    {
        public int[] BubbleSortArray(int[] myArray)
        {
            int length = myArray.Length;

            for(int i = 0; i < length; i++)
            {
                for(int j = i+1; j < length; j++)
                {
                    if (myArray[i] > myArray[j])
                    {
                        int temp = myArray[i];
                        myArray[i] = myArray[j];
                        myArray[j] = temp;
                    }
                }
            }
            return myArray;
        }
    }
}
