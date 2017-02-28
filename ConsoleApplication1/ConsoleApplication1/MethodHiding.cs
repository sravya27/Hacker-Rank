using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MethodHiding
    {
       String name;
      public virtual void printName()
        {
            
            Console.WriteLine("Parent Class");
        }  
    }
    class A : MethodHiding
    {
        int salary;
        public new void printName()
        {
            Console.WriteLine("Child class");
        }

    }
}
