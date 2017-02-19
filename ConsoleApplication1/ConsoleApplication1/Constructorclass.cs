using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Constructorclass
    {
        string _fn, _ln;

        public Constructorclass():
            this("No FN")
        {

        }
        public Constructorclass(string FN, string LN)
        {
           this._fn = FN;
           this._ln = LN;
        }

        public Constructorclass(string FN)
        {
            _fn = FN + "YES";

        }
        public void printName()
        {
            Console.WriteLine("full name is {0} {1}", _fn, _ln);
        }
    }
}
