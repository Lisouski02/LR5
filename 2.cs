using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            char ss = ' ';
            string s = " ";
            int n = 0, b = 0;
            Console.Write("Введитие специальный символ который будет встречаться в строке : ");
            ss = Convert.ToChar(Console.ReadLine());

            Console.Write("Введитие строку в которой встречается специальный символ : ");
            s = Convert.ToString(Console.ReadLine());


            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ss)
                {
                    b++;

                }
            }
            Console.WriteLine(ss);
            Console.WriteLine("Специальный символ встречается " + b + " раз.");


        }
    }
}
