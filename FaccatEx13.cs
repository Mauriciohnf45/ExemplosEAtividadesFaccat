using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos
{
    internal class FaccatEx13
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite a primeira nota (peso 2): ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota (peso 3): ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a terceira nota (peso 5): ");
            double nota3 = double.Parse(Console.ReadLine());

            // Cálculo da média ponderada
            double mediaFinal = (nota1 * 2 + nota2 * 3 + nota3 * 5) / 10;

            Console.WriteLine($"A média final do aluno é: {mediaFinal:F2}");
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
   
