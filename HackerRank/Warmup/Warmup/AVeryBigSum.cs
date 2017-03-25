//You are given an array of integers of size.You need to print the sum of the elements in the array, keeping in mind that some of those integers may be quite large.
//Input Format
//The first line of the input consists of an integer.The next line contains  space-separated integers contained in the array.
//Output Format
//Print a single value equal to the sum of the elements in the array.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmup
{
    class AVeryBigSum
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            long sum = 0;
            for (int i = 0; i < n; i++)
                sum = sum + arr[i];
            Console.WriteLine(sum);
        }
    }
}
