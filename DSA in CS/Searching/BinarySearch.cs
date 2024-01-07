using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_in_CS.Searching
{
    internal class BinarySearch
    {
        public int BinarySearchValue(int[] myArray, int value)
        {
            int start = 0;
            int end = myArray.Length - 1;
            int mid = (start + end) / 2;

            if (myArray.Length == 0)
            {
                return -1;
            }
            else
            {
                while (start <= end)
                {
                    mid = (start + end) / 2;
                    if (myArray[mid] == value)
                    {
                        return mid;
                    }
                    else if (myArray[mid] > value)
                    {
                        end = mid-1;
                    }
                    else
                    {
                        start = mid+1;
                    }
                }
                return -1;
            }
        }
    }
}
