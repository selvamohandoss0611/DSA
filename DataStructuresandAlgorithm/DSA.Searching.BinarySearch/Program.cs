using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Searching.BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Program pbj = new Program();
            

        }

        public bool BinarySearch(int[] arr,int size,int value)
        {
            int low = 0, high = size - 1, mid;
            while(low <= high)
            {
                mid = low + (high - low) / 2;
                if (arr[mid] == value)
                {
                    return true;
                }
                else if (arr[mid] < value)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }

            }
            return false;


        }
   
    }
}
