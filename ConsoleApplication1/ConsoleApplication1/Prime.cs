using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Prime
    {
        public void prime()
            {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            bool flag = true;
            for(int i=2; i<num; i++)
            {
                if(num%i==0)
                {
                    Console.WriteLine("Not a prime number");
                    flag = false;
                    break;
                }
            }
            if (flag == true)
                Console.WriteLine("Given number is prime");
        }
    }
}
