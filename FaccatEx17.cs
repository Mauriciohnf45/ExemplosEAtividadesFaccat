using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos
{
    internal class FaccatEx17
    {
       public static void Main(string[] args)
        {
            Console.Write("Digite a nota da 1ª avaliação: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a nota da 2ª avaliação: ");
            double nota2 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2) / 2;

            if (media >= 6)
            {
                Console.WriteLine($"Aluno aprovado com média {media:F2}.");
            }
            else
            {
                Console.WriteLine($"Aluno reprovado com média {media:F2}.");
            }

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
   
