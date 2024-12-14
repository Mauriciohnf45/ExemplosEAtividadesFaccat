using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos
{
    internal class FaccatEx12
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite a temperatura em graus Fahrenheit: ");
            double fahrenheit = double.Parse(Console.ReadLine());

            // Fórmula de conversão: C = (F - 32) * 5 / 9
            double celsius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine($"A temperatura em graus Celsius é: {celsius:F2}");
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
    
