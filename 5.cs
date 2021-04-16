using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //напечатать без повторение слова текста, у которых первая и последняя буква совпадают
            string s = "";
            Console.Write("Напечатать без повторение слова текста, у которых первая и последняя буква совпадают : ");
            s = Console.ReadLine();
            string[] words = s.Split(' ');

            foreach (var word in words)
            {
                if (word[0] == word[word.Length - 1])
                {
                    Console.WriteLine(word);
                }

            }
        }
    }
}
