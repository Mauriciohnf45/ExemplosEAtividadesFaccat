using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos
{
    internal class FaccatEx29
    {
       public static void Main(string[] args)
        {
            Console.Write("Digite o primeiro valor: ");
            int valor1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            int valor2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro valor: ");
            int valor3 = int.Parse(Console.ReadLine());

            int menor;

            // Determinar o menor valor
            if (valor1 < valor2 && valor1 < valor3)
            {
                menor = valor1;
            }
            else if (valor2 < valor1 && valor2 < valor3)
            {
                menor = valor2;
            }
            else
            {
                menor = valor3;
            }

            // Soma dos dois maiores valores
            int soma = valor1 + valor2 + valor3 - menor;

            Console.WriteLine($"A soma dos dois maiores valores é: {soma}");

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
  
