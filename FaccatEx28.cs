using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos
{
    internal class FaccatEx28
    {
       public static void Main(string[] args)
        {
            Console.Write("Digite o primeiro valor: ");
            int valor1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            int valor2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro valor: ");
            int valor3 = int.Parse(Console.ReadLine());

            int maior;

            if (valor1 > valor2 && valor1 > valor3)
            {
                maior = valor1;
            }
            else if (valor2 > valor1 && valor2 > valor3)
            {
                maior = valor2;
            }
            else
            {
                maior = valor3;
            }

            Console.WriteLine($"O maior valor é: {maior}");

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
   
