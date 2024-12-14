using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos
{
    internal class FaccatEx24
    {
       public static void Main(string[] args)
        {
            Console.Write("Digite o salário fixo do vendedor: ");
            double salarioFixo = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor total das vendas efetuadas: ");
            double vendas = double.Parse(Console.ReadLine());

            double comissao;
            if (vendas <= 1500)
            {
                comissao = vendas * 0.03;
            }
            else
            {
                comissao = 1500 * 0.03 + (vendas - 1500) * 0.05;
            }

            double salarioTotal = salarioFixo + comissao;

            Console.WriteLine($"O salário total do vendedor é: R$ {salarioTotal:F2}");
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
   
