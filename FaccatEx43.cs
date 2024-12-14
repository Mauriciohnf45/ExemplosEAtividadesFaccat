using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos
{
    internal class FaccatEx43
    {
      public static void Main(string[] args)
        {
            Console.Write("Digite o valor de a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de b: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de c: ");
            int c = int.Parse(Console.ReadLine());

            string mensagem;

            if ((a < b + c) && (b < a + c) && (c < a + b))
            {
                if (a == b && b == c)
                {
                    mensagem = "Triângulo Equilátero";
                }
                else if (a == b || b == c || a == c)
                {
                    mensagem = "Triângulo Isósceles";
                }
                else
                {
                    mensagem = "Triângulo Escaleno";
                }
            }
            else
            {
                mensagem = "Não é possível formar um triângulo";
            }

            Console.WriteLine($"Resultado: {mensagem}");

            Console.ReadKey();
        }
    }
}
   
