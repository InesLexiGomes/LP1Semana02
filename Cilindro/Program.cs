using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a altura? ");
            string input1 = Console.ReadLine();
            float h = float.Parse(input1);
            Console.Write("Qual é o raio?");
            string input2 = Console.ReadLine();
            float r = float.Parse(input2);
            
            // Volume do cilindro.
            Console.WriteLine($"V = {MathF.PI * MathF.Pow(r,2) * h}");
            
            // Área de superfície.
            Console.WriteLine($"Sa = {2 * MathF.PI * r * (r+h)}");

        }
    }
}
