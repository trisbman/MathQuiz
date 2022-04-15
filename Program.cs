using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int a = rnd.Next(100);
            int b = rnd.Next(100);
            Console.WriteLine(a + " + " + b);
            int result = a + b;

            Console.Write("Answer: ");
            string input = Console.ReadLine();

            Console.WriteLine(result == int.Parse(input));

            // pause
            Console.ReadKey();
        }
    }
}
