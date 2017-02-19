using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Params
    {
        public void arrayParams(params int[] i)
        {
            foreach (int j in i)
            {
                Console.WriteLine("items are {0}" ,j);
            }
        }
    }
}
