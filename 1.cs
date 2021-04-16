using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {

        static void Main(string[] args)
        {
            string s = " ";
            int w = 1;

            Console.Write("Введите строку :");
            s = Convert.ToString(Console.ReadLine());

            string s1 = "";
            if (s[0] == ' ')
            {
                s1 = s.Remove(0, 1);
            }
            else
            {
                s1 = s;
            }


            string s2 = s1.Replace("  ", " ");

            Console.WriteLine(s2);

            for (int i = 0; i < s2.Length; i++)
            {


                if (s2[i] == ' ')
                {
                    w++;

                }

            }
            Console.WriteLine("Колличество слов :" + w);
            string[] words = s2.Split(' ');

            int p = 0;
            char a = 'а';
            foreach (var Lit in words)
            {

                for (int i = 0; i < Lit.Length; i++)
                {
                    if (a == Lit[i])
                    {
                        p++;

                    }

                }
                if (p == 3)
                {
                    p = 0;
                    Console.WriteLine(Lit);
                }
            }
        }
    }
}
