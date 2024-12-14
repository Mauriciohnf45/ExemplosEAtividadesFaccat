using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos
{
    internal class FaccatEx14
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite um valor: ");
            double valor = double.Parse(Console.ReadLine());

            if (valor > 10)
            {
                Console.WriteLine("É MAIOR QUE 10!");
            }
            else
            {
                Console.WriteLine("NÃO É MAIOR QUE 10!");
            }

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
   
