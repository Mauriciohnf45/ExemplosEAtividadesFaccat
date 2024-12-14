using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos
{
    internal class FaccatEx30
    {
       public static void Main(string[] args)
        {
            Console.Write("Digite o primeiro valor: ");
            int valor1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            int valor2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro valor: ");
            int valor3 = int.Parse(Console.ReadLine());

            int menor, meio, maior;

            // Determinar a ordem dos valores
            if (valor1 < valor2 && valor1 < valor3)
            {
                menor = valor1;
                if (valor2 < valor3)
                {
                    meio = valor2;
                    maior = valor3;
                }
                else
                {
                    meio = valor3;
                    maior = valor2;
                }
            }
            else if (valor2 < valor1 && valor2 < valor3)
            {
                menor = valor2;
                if (valor1 < valor3)
                {
                    meio = valor1;
                    maior = valor3;
                }
                else
                {
                    meio = valor3;
                    maior = valor1;
                }
            }
            else
            {
                menor = valor3;
                if (valor1 < valor2)
                {
                    meio = valor1;
                    maior = valor2;
                }
                else
                {
                    meio = valor2;
                    maior = valor1;
                }
            }

            Console.WriteLine($"Valores em ordem crescente: {menor}, {meio}, {maior}");
            Console.ReadKey();
        }
    }
}
  
