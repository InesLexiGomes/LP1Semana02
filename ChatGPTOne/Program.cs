using System;

namespace ChatGPTOne
{
    class Program
    {
        private static void Main(string[] args)
        {
            // Inicialização da variável response.
            string question, response;

            question = "Start.";

            while (question != "Quit")
            {
                // Questionar o utilizador
                Console.Write("Place your question? ");
                question = Console.ReadLine();

                // Verifica as perguntas e responde de acordo
                switch (question)
                {
                    case "Are you gay?":
                        response = "Yes.";
                        break;
                    case "Are you french?":
                        response = "Nein, ich bin Deutch";
                        break;
                    case "Hello World?":
                        response = "Programmed to work and not to feeeel-";
                        break;
                    case "Are you addicted to video games?":
                        response = "Obviously!";
                        break;

                    case "Quit":
                        continue;
                        
                    default:
                        response = "I am not programmed to answer your question.";
                        break;
                }
            // Print da resposta
            Console.WriteLine(response);
            }
        }
    }
}
