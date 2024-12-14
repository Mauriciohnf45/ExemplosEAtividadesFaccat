using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos
{
    internal class FaccatEx34
    {
       public static void Main(string[] args)
        {
            Console.Write("Digite o valor de X: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de Y: ");
            int y = int.Parse(Console.ReadLine());

            int z = (x * y) + 5;
            string resposta;

            if (z <= 0)
            {
                resposta = "A";
            }
            else if (z <= 100)
            {
                resposta = "B";
            }
            else
            {
                resposta = "C";
            }

            Console.WriteLine($"Z = {z}, Resposta = {resposta}");
            Console.ReadKey();
        }
    }
}
   
