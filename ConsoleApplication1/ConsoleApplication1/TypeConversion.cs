using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class TypeConversion
    {
        public void stringToInt()
        {
            int result = 0;         
            Console.WriteLine("Enter string number");
            string strnum = Console.ReadLine();
            bool isStrringconvetable = int.TryParse(strnum, out result);
            if (isStrringconvetable)
                Console.WriteLine(result);
            else
                Console.WriteLine("enter valid string number");         

        }
    }
}
