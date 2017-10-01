using System;

namespace Permutations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert first line which contains pattern and next line which contains a text string:\n");

            string pattern = Console.ReadLine(),
                   text = Console.ReadLine();

            Console.WriteLine(Lib.CalcPattern(pattern, text));
        }
    }
}
