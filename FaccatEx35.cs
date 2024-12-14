using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos
{
    internal class FaccatEx35
    {
       public static void Main(string[] args)
        {
            Console.Write("Digite o número de litros vendidos: ");
            double litros = double.Parse(Console.ReadLine());

            Console.Write("Digite o tipo de combustível (A para álcool, G para gasolina): ");
            char tipo = char.ToUpper(Console.ReadLine()[0]);

            double precoPorLitro = tipo == 'A' ? 2.90 : 3.30;
            double desconto = 0;

            if (tipo == 'A') // Álcool
            {
                desconto = litros <= 20 ? 0.03 : 0.05;
            }
            else if (tipo == 'G') // Gasolina
            {
                desconto = litros <= 20 ? 0.04 : 0.06;
            }
            else
            {
                Console.WriteLine("Tipo de combustível inválido!");
                return;
            }

            double totalSemDesconto = litros * precoPorLitro;
            double totalComDesconto = totalSemDesconto - (totalSemDesconto * desconto);

            Console.WriteLine($"O valor a ser pago é R$ {totalComDesconto:F2}");
            Console.ReadKey();
        }
    }
}
   
