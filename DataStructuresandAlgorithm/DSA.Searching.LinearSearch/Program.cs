using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Searching.LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        { 
            int[] arr = { 1, 4, 7, 2, 3, 100, 34, 23, 78 };
            Program pobj = new Program();           
            bool linearSearchUnsortedOutput = pobj.linearSearchUnsorted(arr, arr.Length, 4);
            Console.WriteLine("Linear Search UnSorted Output {0}", linearSearchUnsortedOutput);
            int[] sortedarray = { 23, 50, 67, 89, 888, 8888 };
            bool linearSearchsortedOutput = pobj.linearSearchSorted(sortedarray, sortedarray.Length, 8888);
            Console.WriteLine("Linear Search Sorted Output {0}",linearSearchsortedOutput);
            Console.ReadLine();
        }

        public  bool linearSearchUnsorted(int[] arr,int size,int value)
        {
            for (int i = 0; i < size; i++)
            {
                if(value == arr[i])
                {
                    return true;
                }

            }
            return false;

        }

        public bool linearSearchSorted(int[] arr,int size,int value)
        {
            for (int i = 0; i < size; i++)
            {
                if(value == arr[i])
                {
                    return true;
                }
                else if(value < arr[i])
                {
                    return false;
                }

            }
            return false;
        }
    }
}
