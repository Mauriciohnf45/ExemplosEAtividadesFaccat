using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos
{
    internal class FaccatEx31
    {
       public static void Main(string[] args)
        {
            Console.Write("Digite o valor do lado A: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor do lado B: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor do lado C: ");
            int c = int.Parse(Console.ReadLine());

            if (a < b + c && b < a + c && c < a + b)
            {
                Console.WriteLine("Os valores formam um triângulo.");
            }
            else
            {
                Console.WriteLine("Os valores não formam um triângulo.");
            }

            Console.ReadKey();
        }
    }
}
   
