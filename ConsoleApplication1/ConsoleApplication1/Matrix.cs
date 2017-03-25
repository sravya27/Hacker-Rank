using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Matrix
    {
        public void matrix()
        {
          
            int rows, cols, j, k;
            Console.WriteLine("Enter number of rows:");
            rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of columns:");
            cols = int.Parse(Console.ReadLine());
            int[,] i =new int[10,10];
            Console.WriteLine("Enter matrix elements");
            for(j=0;j<rows;j++)
            {
                for(k=0;k<cols;k++)
                {
                    Console.WriteLine("Enter [{0},{1}]", j, k);
                    i[j,k] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Matrix Elements are:");
            for (j = 0; j < rows; j++)
            {
                for (k = 0; k < cols; k++)
                {
                    Console.Write(i[j,k] +"\t");
                    
                }
                Console.WriteLine("");
            }

            bool flag = transposeMatrix(i, rows, cols);
            if (flag == true)
                Console.WriteLine("Given is a transpose matrix");
            else
                Console.WriteLine("Given is not a transpose matrix");
        }

        public bool transposeMatrix(int[,] matrix, int rows, int cols)
        {
            bool flag = true;
            for (int j = 0; j < rows; j++)
            {
                for (int k = 0; k < cols; k++)

                {
                    if (matrix[j, k] != matrix[k, j])
                    {
                        flag = false;
                        break;  
                    }

                }
            }
            return flag;
        }

    }
}
