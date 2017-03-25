using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MergeSort
    {
        public void declareArray()
        {
            Console.WriteLine("Enter Array Size");
            int size = int.Parse(Console.ReadLine());
            int[] unsort = new int[size];
            Console.WriteLine("Enter Array elements");
            for (int i = 0; i < size; i++)
            {
                
                unsort[i] = int.Parse(Console.ReadLine());
            }
            mergeSort(unsort);
            Console.WriteLine("Elements after sorting");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(unsort[i]);
            }
        }
       

        public  void mergeSort(int[] A)
        {
            if (A.Length < 2)
            { }
            else
            {
                int mid = (A.Length) / 2;
                int[] left = new int[mid];
                int[] right = new int[A.Length - mid];

                for (int i = 0; i < mid; i++)
                {
                    left[i] = A[i];
                }
                for (int i = mid; i < A.Length; i++)
                {
                    right[i - mid] = A[i];
                }
                mergeSort(left);
                mergeSort(right);
                merge(left, right, A);
            }

        }

        public void merge(int[] left, int[] right, int[] A)
        {
            int nl = left.Length;
            int nr = right.Length;
            int i = 0, j = 0, k = 0;
            for(; i < nl && j < nr; k++)
            {
                if (left[i] <= right[j])
                {
                    A[k] = left[i];                    
                    i++;
                }
                else
                {
                    A[k] = right[j];                    
                    j++;
                }
            }
            for (; i < nl; i++,k++)
            {
                A[k] = left[i];                
            }
            for (; j < nr; j++,k++)
            {
                A[k] = right[j];                
            }
        }
    }
}