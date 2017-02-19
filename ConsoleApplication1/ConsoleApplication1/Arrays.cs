using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
/// <summary>
///class for arrays declaration 
/// </summary>
    class Arrays
    {
        public void arrayClass()
        {            
            string choice=null; 
            do
            {
                int start = 1;
                Console.WriteLine("enter target value:");
                int target = int.Parse(Console.ReadLine());
                while (start <= target)
                {
                    Console.Write(start + "\t");
                    start = start * 2;
                }
                do
                {
                    Console.WriteLine("Do you want to continue: ");
                    choice = Console.ReadLine().ToUpper();
                    if (choice != "YES" && choice != "NO")
                        Console.WriteLine("Please enter a valid input:");
                } while (choice != "YES" && choice != "NO");
            } while (choice == "YES");
        }
    }
}
