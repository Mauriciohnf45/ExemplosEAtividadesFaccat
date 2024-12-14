using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos
{
    internal class FaccatEx26
    {
       public static void Main(string[] args)
        {
            Console.Write("Digite a quantidade atual em estoque: ");
            int quantidadeAtual = int.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade máxima em estoque: ");
            int quantidadeMaxima = int.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade mínima em estoque: ");
            int quantidadeMinima = int.Parse(Console.ReadLine());

            double quantidadeMedia = (quantidadeMaxima + quantidadeMinima) / 2.0;

            Console.WriteLine($"Quantidade média: {quantidadeMedia:F2}");

            if (quantidadeAtual >= quantidadeMedia)
            {
                Console.WriteLine("Não efetuar compra.");
            }
            else
            {
                Console.WriteLine("Efetuar compra.");
            }

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
   
