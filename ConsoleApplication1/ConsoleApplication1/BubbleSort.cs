using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class BubbleSort
    {
        public void bubbleSort()
        {
            Console.WriteLine("Enter Array Size");
            int size = int.Parse(Console.ReadLine());
            int[] unsort = new int[size];            
            Console.WriteLine("Enter List values");
            for(int i=0 ; i<size ; i++)
                {
                unsort[i] = 0;
                unsort[i] = int.Parse(Console.ReadLine());
            }
                        

            for(int i=0; i<size-1; i++)
            {
                for( int j=0; j<size-1-i; j++)
                {
                    if (unsort[j] < unsort[j+1])
                    {
                        int temp = unsort[j];
                        unsort[j] = unsort[j + 1];
                        unsort[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(unsort[i]);
            }

        }
    }
}
