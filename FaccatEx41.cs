using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos
{
    internal class FaccatEx41
    {
       public static void Main(string[] args)
        {
            Console.Write("Digite a nota N1: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a nota N2: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a nota N3: ");
            double n3 = double.Parse(Console.ReadLine());

            Console.Write("Digite a média dos exercícios: ");
            double mediaExercicios = double.Parse(Console.ReadLine());

            double mediaAproveitamento = (n1 + n2 * 2 + n3 * 3 + mediaExercicios) / 7;
            char conceito;

            if (mediaAproveitamento >= 9.0)
            {
                conceito = 'A';
            }
            else if (mediaAproveitamento >= 7.5)
            {
                conceito = 'B';
            }
            else if (mediaAproveitamento >= 6.0)
            {
                conceito = 'C';
            }
            else
            {
                conceito = 'D';
            }

            Console.WriteLine($"\nMédia de Aproveitamento: {mediaAproveitamento:F2}");
            Console.WriteLine($"Conceito: {conceito}");

            Console.ReadKey();
        }
    }
}
   
