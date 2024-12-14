using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos
{
    internal class FaccatEx40
    {
      public static void Main(string[] args)
        {
            Console.Write("Digite a descrição do produto: ");
            string descricao = Console.ReadLine();

            Console.Write("Digite a quantidade adquirida: ");
            int quantidade = int.Parse(Console.ReadLine());

            Console.Write("Digite o preço unitário: ");
            double precoUnitario = double.Parse(Console.ReadLine());

            double total = quantidade * precoUnitario;
            double desconto = 0;

            if (quantidade <= 5)
            {
                desconto = total * 0.02;
            }
            else if (quantidade <= 10)
            {
                desconto = total * 0.03;
            }
            else
            {
                desconto = total * 0.05;
            }

            double totalAPagar = total - desconto;

            Console.WriteLine($"\nProduto: {descricao}");
            Console.WriteLine($"Total: R$ {total:F2}");
            Console.WriteLine($"Desconto: R$ {desconto:F2}");
            Console.WriteLine($"Total a pagar: R$ {totalAPagar:F2}");

            Console.ReadKey();
        }
    }
}
   
