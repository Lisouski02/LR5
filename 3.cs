using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LAb_2
{
    class Program
    {

        static void Main(string[] args)
        {
            string s = " ";
            int w = 0;

            Console.Write("Введите строку :");
            s = Convert.ToString(Console.ReadLine());

            string[] words = s.Split(' ');

            foreach (var word in words)
            {
                //System.Console.WriteLine($"<{word}>");
                for (int i = 0; i < word.Length; i++)
                {
                    if (Char.IsLetter(word[i]))
                    {
                        w++;
                    }
                    if (w == word.Length)
                    {
                        Console.WriteLine(word);
                        w = 0;
                    }



                }


            }
        }
    }
}
