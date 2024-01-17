using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_in_CS.Sorting
{
    internal class SelectionSort
    {
        public int[] SelectionSortArray(int[] myArray)
        {
            int length = myArray.Length;
            
            for(int i=0; i<length; i++)
            {
                int min = myArray[i];
                int minIndex = i;

                for(int j=i+1; j<length; j++)
                {
                    if (myArray[j] < min)
                    {
                        min = myArray[j];
                        minIndex = j;
                    }
                }

                var temp = myArray[minIndex];
                myArray[minIndex] = myArray[i];
                myArray[i] = temp;
            }

            return myArray;
        }
    }
}
