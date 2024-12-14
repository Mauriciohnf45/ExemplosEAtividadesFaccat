using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos
{
    internal class FaccatEx16
    {
       public static void Main(string[] args)
        {
            Console.Write("Digite o número de maçãs compradas: ");
            int quantidade = int.Parse(Console.ReadLine());

            double preco = quantidade >= 12 ? 1.00 : 1.30;
            double custoTotal = quantidade * preco;

            Console.WriteLine($"O custo total da compra é: R$ {custoTotal:F2}");
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
   
