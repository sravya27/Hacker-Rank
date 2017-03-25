using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class StringReverse
    {
        public void stringReverse()
        {
            Console.WriteLine("Enter a string to reverse and check if palindrome or not");
            string item = Console.ReadLine();
            string rev ="";
            bool flag = true;

            for(int i=item.Length-1; i>=0; i--)
            {
                rev = rev + item[i];
            }
            Console.WriteLine("Reverse string is " + rev);
           
            for(int i=0,j =item.Length-1; i<j; i++,j--)
            {
                if (item[i] != item[j])
                {
                    Console.WriteLine("Given String is not a pallindrome");
                    flag = false;
                    break;
                }            
                
            }

            if (flag == true)
                Console.WriteLine("Given String is a pallindrome ");
        }   
        

    }
}
