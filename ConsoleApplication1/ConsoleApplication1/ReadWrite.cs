using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ReadWrite
    {
        public void personDetails()
        {
            Console.WriteLine("Enter your first name ");
            String fname = Console.ReadLine();
            Console.WriteLine("Enter your last name ");
            String lname = Console.ReadLine();
            Console.WriteLine("Your name is {0} {1}", fname, lname);
        }
    }
}
