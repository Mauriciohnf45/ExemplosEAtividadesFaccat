using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos
{
    internal class FaccatEx27
    {
       public static void Main(string[] args)
        {
            Console.Write("Digite um valor: ");
            int valor = int.Parse(Console.ReadLine());

            if (valor > 0)
            {
                Console.WriteLine("O valor é positivo.");
            }
            else if (valor < 0)
            {
                Console.WriteLine("O valor é negativo.");
            }
            else
            {
                Console.WriteLine("O valor é zero.");
            }

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
   
