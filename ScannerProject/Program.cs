using System;

namespace ScannerProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an expression:");
            string? input = Console.ReadLine();
            if (input == null)
            {
                Console.WriteLine("No input provided.");
                return;
            }

            var lexer = new Lexer(input);
            var tokens = lexer.Tokenize();

            Console.WriteLine("\nTokens:");
            foreach (var token in tokens)
            {
                Console.WriteLine(token);
            }

            Console.WriteLine("\n-The project was implemented by Hagar Atia,\n -A student in the fourth year,\n -Department of Computer Engineering and Science,\n -Specializing in .Net web developer");
        }
    }
}
