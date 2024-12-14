using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos
{
    internal class FaccatEx15
    {
       public static void Main(string[] args)
        {
            Console.Write("Digite um valor: ");
            double valor = double.Parse(Console.ReadLine());

            if (valor >= 0)
            {
                Console.WriteLine("O valor é POSITIVO!");
            }
            else
            {
                Console.WriteLine("O valor é NEGATIVO!");
            }

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
  
