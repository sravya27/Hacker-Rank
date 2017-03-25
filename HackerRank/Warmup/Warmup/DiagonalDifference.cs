//Given a square matrix of size, calculate the absolute difference between the sums of its diagonals.
//Input Format
//The first line contains a single integer, . The next  lines denote the matrix's rows, with each line containing space-separated integers describing the columns.
//Output Format
//Print the absolute difference between the two sums of the matrix's diagonals as a single integer.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmup
{
    class DiagonalDifference
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = int.Parse(a_temp[j]);
                }
            }
            int ld = 0, rd = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                        ld = ld + a[i, j];
                    if (i == n - j - 1)
                        rd = rd + a[i, j];
                }
            }
            int d = Math.Abs(ld - rd);
            Console.WriteLine(d);
        }
    }
}
