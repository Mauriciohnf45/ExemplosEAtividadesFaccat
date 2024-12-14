using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos
{
    internal class FaccatEx8
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite o número total de eleitores: ");
            int totalEleitores = int.Parse(Console.ReadLine());

            Console.Write("Digite o número de votos brancos: ");
            int votosBrancos = int.Parse(Console.ReadLine());

            Console.Write("Digite o número de votos nulos: ");
            int votosNulos = int.Parse(Console.ReadLine());

            Console.Write("Digite o número de votos válidos: ");
            int votosValidos = int.Parse(Console.ReadLine());

            double percBrancos = (votosBrancos / (double)totalEleitores) * 100;
            double percNulos = (votosNulos / (double)totalEleitores) * 100;
            double percValidos = (votosValidos / (double)totalEleitores) * 100;

            Console.WriteLine($"Percentual de votos brancos: {percBrancos:F2}%");
            Console.WriteLine($"Percentual de votos nulos: {percNulos:F2}%");
            Console.WriteLine($"Percentual de votos válidos: {percValidos:F2}%");
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
   
