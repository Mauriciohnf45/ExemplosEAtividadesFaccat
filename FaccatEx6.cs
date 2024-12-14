using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos
{
    internal class FaccatEx6
    {
        public static void Main(string[] args)
        {
            // Solicita a base do retângulo
            Console.Write("Digite a base do retângulo: ");
            double baseRetangulo = double.Parse(Console.ReadLine());

            // Solicita a altura do retângulo
            Console.Write("Digite a altura do retângulo: ");
            double alturaRetangulo = double.Parse(Console.ReadLine());

            // Calcula a área
            double area = baseRetangulo * alturaRetangulo;

            // Exibe o resultado
            Console.WriteLine($"A área do retângulo é: {area}");

            // Pausa o console para leitura
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}