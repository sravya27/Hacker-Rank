using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class stringShorten
    {
        public void StringShorten()
        {
            
            string str = Console.ReadLine();
            StringBuilder final = new StringBuilder();
            StringBuilder temp = new StringBuilder();
            StringBuilder temp2 = new StringBuilder();
            StringBuilder temp3 = new StringBuilder();

            int n = str.Length;

            for (int i = 0; i < n; i++)
            {

                if (Char.IsLetter(str[i]) && i != n - 1)
                {
                    temp.Append(str[i]);
                }
                else if (i != n - 1)
                {
                    for (int j = 0; j < temp.Length; j++)
                    {
                        if (j == 0)
                        {
                            temp2.Append(temp[j]);
                        }
                        else if (j == temp.Length - 1)
                        {
                            string t2 = temp3.ToString();
                            string answer = new String(t2.Distinct().ToArray());
                            temp2.Append(answer.Length);
                            temp2.Append(temp[j]);

                        }
                        else
                        {
                            temp3.Append(temp[j]);
                        }
                    }
                    final.Append(temp2.ToString());
                    temp = null;
                    temp2 = null;
                    temp3 = null;
                    final.Append(str[i]);
                }
                else
                {
                    if (Char.IsLetter(str[i]))
                    {
                        temp.Append(str[i]);
                        for (int j = 0; j < temp.Length; j++)
                        {
                            if (j == 0)
                            {
                                temp2.Append(temp[j]);
                            }
                            else if (j == temp.Length - 1)
                            {
                                string t2 = temp3.ToString();
                                string answer = new String(t2.Distinct().ToArray());
                                temp2.Append(answer.Length);
                                temp2.Append(temp[j]);

                            }
                            else
                            {
                                temp3.Append(temp[j]);
                            }
                        }
                        final.Append(temp2.ToString());
                        temp = null;
                        temp2 = null;
                        temp3 = null;
                    }
                    else
                    {
                        if (temp.Length == 0)
                        {
                            final.Append(str[i]);
                        }
                        else
                        {

                            for (int j = 0; j < temp.Length; j++)
                            {
                                if (j == 0)
                                {
                                    temp2.Append(temp[j]);
                                }
                                else if (j == temp.Length - 1)
                                {
                                    string t2 = temp3.ToString();
                                    string answer = new String(t2.Distinct().ToArray());
                                    temp2.Append(answer.Length);
                                    temp2.Append(temp[j]);

                                }
                                else
                                {
                                    temp3.Append(temp[j]);
                                }
                            }
                            final.Append(temp2.ToString());
                            temp = null;
                            temp2 = null;
                            temp3 = null;
                            final.Append(str[i]);
                        }

                    }

                }
            }          

            Console.WriteLine(final.ToString());
        }       
    }
}
