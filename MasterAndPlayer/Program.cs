using System;

namespace MasterAndPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pergunta ao Number Master
            Console.WriteLine("Hey Number Master give me a number from 0 to a 100!!!");
            Console.Write("Input: ");
            // Regista a solução.
            string input1 = Console.ReadLine();
            int n = int.Parse(input1);

                // Sai do programa com mensagem de erro
                if ((n < 0)||(n > 100))
            {
                    Console.WriteLine("Invalid number error! Ah!!!");
            }
            else
            {
                // Escreve 100 linhas em branco
                for (int x=1;x<=100;x++)
                {
                    Console.WriteLine("");
                }

                // Entra no ciclo.
                while (true)
                {
                    // Pergunta ao Player
                    Console.WriteLine("Player try to guess what the number from 0 to 100 is.");
                    Console.Write("Input: ");

                    // Regista a resposta.
                    string input2 = Console.ReadLine();
                    int i = int.Parse(input2);

                    // Verifica se está entre 0 e 100
                    if ((i < 0)||(i > 100))
                    {
                        Console.WriteLine("Invalid number! It must be from 0 to 100!");
                    }

                    // Verifica se é menor que n
                    else if (i < n)
                    {
                        Console.WriteLine("The number is smaller than the original.");
                    }

                    // Verifica se é maior que n
                    else if (i > n)
                    {
                        Console.WriteLine("The number is bigger than the original.");
                    }

                    // Congratula o Player se acertar
                    else if (i == n)
                    {
                        Console.WriteLine("You guessed the number congrats!");
                        break;
                    }

                }
            }
        }
    }
}
