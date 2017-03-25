﻿//Given an array of N integers, can you find the sum of its elements?
//Input Format
//The first line contains an integer,N , denoting the size of the array.
//The second line contains N space-separated integers representing the array's elements.
//Output Format
//Print the sum of the array's elements as a single integer.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmup
{
    class SimpleArraySum
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum = sum + arr[i];
            }
            Console.WriteLine(sum);
        }
    }
}
