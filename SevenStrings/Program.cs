using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string StringDemo1, StringDemo2;
            StringDemo1 = "AAa";
            StringDemo2 = "bbb";
            string StringFull = string.Concat(StringDemo1," ",StringDemo2);

            Console.WriteLine($"Stringul creat este: '{StringFull}'");

            string LowerCaseStringFull = StringFull.ToLower();
            Console.WriteLine($"Stringul cu litere mici: {LowerCaseStringFull}");

            if (string.IsNullOrEmpty(StringFull))
            {
                Console.WriteLine("String null sau gol.");
            }
            else
            {
                int CountVowels = 0;
                
                string VowelsList = "a,e,i,o,u,A,E,I,O,U";
                string[] SplitVowel = VowelsList.Split(',');
                
                for (int ii = 0; ii < LowerCaseStringFull.Length; ii++)
                { 
                    for (int jj = 0; jj < 10; jj++)
                    {
                        
                        if (LowerCaseStringFull[ii] == VowelsList[jj])
                        {
                            CountVowels++;
                        }
                    }

                }

                Console.WriteLine($"Stringul are o lungime de {StringFull.Length} caractere din care {CountVowels} sunt vocale.");
            }

            string ReplaceStringFull = StringFull.Replace("a", "b");
            Console.WriteLine($"Stringul dupa inlocuirea lui 'a' cu 'b': {ReplaceStringFull}");

            if (string.Compare(StringFull, LowerCaseStringFull, true) == 0)
            {
                Console.WriteLine("Cele doua string-uri sunt identice");
            }
            else
            {
                Console.WriteLine("Cele doua string-uri sunt diferite");
            }

            if (StringFull.Contains("a"))
            {
                int indexOfa = StringFull.IndexOf('a');
                Console.WriteLine($"Contine 'a' si apare pe pozitia: {indexOfa}");
            }
            else
            {
                Console.WriteLine("Nu contine 'a'.");
            }
        }
    }
}
