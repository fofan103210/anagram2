using System;

namespace anagram2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string:");
            string text = Console.ReadLine();
            string[] words = text.Split(new char[] { ' ' });
            string rezult = "";
           
            foreach(string s in words)
            { string sOut  = "";
              string sOut1  = "";                                   
                for (int i = 0;  i < s.Length; i++)
                {
                    if (char.IsLetter(s[i]))
                    {
                        sOut += s[i];                     
                    }                                        
                }
                    char[] c = sOut.ToCharArray();
                     
                int k = 0;
                    for (int i = 0; i < s.Length; i++)
                    {                  
                        if (char.IsLetter(s[i]) == false)
                        {
                            sOut1 += s[i];                                                      
                        }
                        else
                        {  sOut1 += c[c.Length -1 - k];
                            k++;
                        }
                    }
                sOut1 = sOut1 + " ";
                rezult += sOut1;                                   
            }
            Console.WriteLine(rezult.Trim());
            Console.ReadKey();
        }
    }
}
