using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = false;
            string s = "";
            Console.Write("Введите строку со скобками : ");
            s = Console.ReadLine();

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i; j < s.Length; j++)
                {
                    if (s[i] == '(' & s[j] == ')')
                    {
                        check = true;
                        break;
                    }
                    if (s[i] == '(' & s[j] != ')')
                    {
                        check = false;
                    }
                }

            }
            Console.WriteLine(check);
            Console.ReadKey();
        }
    }
}
