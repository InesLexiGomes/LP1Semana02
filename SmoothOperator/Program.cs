using System;

namespace SmoothOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insere número inteiro não-negativo: ");
            string input = Console.ReadLine();
            int n = int.Parse(input);
            n--;
            Console.WriteLine(n);
            n++;
            Console.WriteLine(n);

        }
    }
}
