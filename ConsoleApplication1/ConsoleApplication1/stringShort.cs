using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class stringShort
    {
        public void StringShort()
        {
            string pattern = "([^A-Za-z])";
            
            Console.WriteLine("Enter input string");
            StringBuilder final = new StringBuilder();
            string input = Console.ReadLine();
            string[] str = Regex.Split(input, pattern);
            str = str.Where(s => !String.IsNullOrEmpty(s)).ToArray();            
            
            foreach (string n in str)
            {                              
                if(n.Length==1)
                {
                    final.Append(n);
                }                
                else
                {           
                  final.Append(n[0]);
                  string answer = new String((n.Substring(1, (n.Length) - 2)).Distinct().ToArray());                               
                  final.Append(answer.Length);
                  final.Append(n[(n.Length) - 1]);                      
                }

            }
            Console.WriteLine(final.ToString());           
        }
    }
}
    