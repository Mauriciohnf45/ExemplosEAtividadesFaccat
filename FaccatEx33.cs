using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos
{
    internal class FaccatEx33
    {
       public static void Main(string[] args)
        {
            Console.Write("Digite o primeiro valor: ");
            int valor1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            int valor2 = int.Parse(Console.ReadLine());

            if (valor1 == valor2)
            {
                Console.WriteLine("Números iguais.");
            }
            else if (valor1 > valor2)
            {
                Console.WriteLine("Primeiro é maior.");
            }
            else
            {
                Console.WriteLine("Segundo maior.");
            }

            Console.ReadKey();
        }
    }
}
   
