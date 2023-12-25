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
            if(myArray.Length == 0)
            {
                return -1;
            }
            else
            {
                return BinarySearchRecursion(myArray, value, 0, myArray.Length-1);
            }
        }

        //10, 20, 30, 40, 50, 60 -> 0,5

        //10, 20, 30, 40, 50 -> 0,4

        public int BinarySearchRecursion(int[] myArray, int value, int start, int end)
        {
            int mid = (start + end)/2;
            int pos = 0;
            if (myArray[mid] > value)
            {
                start = mid;
                BinarySearchRecursion(myArray, value, start, end);
            }
            else if(myArray[mid] < value)
            {
                end = mid;
                BinarySearchRecursion(myArray, value, start, end);
            }
            else
            {
                pos = mid;
            }
            return pos;
        }
    }
}
