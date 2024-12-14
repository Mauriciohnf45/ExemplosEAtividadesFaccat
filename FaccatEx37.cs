using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos
{
    internal class FaccatEx37
    {
       public static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de morangos (em Kg): ");
            double morangos = double.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade de maçãs (em Kg): ");
            double macas = double.Parse(Console.ReadLine());

            double precoMorangos = morangos <= 5 ? 2.50 : 2.20;
            double precoMacas = macas <= 5 ? 1.80 : 1.50;

            double total = (morangos * precoMorangos) + (macas * precoMacas);
            double pesoTotal = morangos + macas;

            if (pesoTotal > 8 || total > 25.00)
            {
                total *= 0.90; // Desconto de 10%
            }

            Console.WriteLine($"O valor a ser pago é R$ {total:F2}");
            Console.ReadKey();
        }
    }
}
   
