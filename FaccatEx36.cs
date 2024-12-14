using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos
{
    internal class FaccatEx36
    {
      public  static void Main(string[] args)
        {
            Console.Write("Digite a idade do primeiro homem: ");
            int homem1 = int.Parse(Console.ReadLine());

            Console.Write("Digite a idade do segundo homem: ");
            int homem2 = int.Parse(Console.ReadLine());

            Console.Write("Digite a idade da primeira mulher: ");
            int mulher1 = int.Parse(Console.ReadLine());

            Console.Write("Digite a idade da segunda mulher: ");
            int mulher2 = int.Parse(Console.ReadLine());

            int homemMaisVelho = Math.Max(homem1, homem2);
            int homemMaisNovo = Math.Min(homem1, homem2);
            int mulherMaisVelha = Math.Max(mulher1, mulher2);
            int mulherMaisNova = Math.Min(mulher1, mulher2);

            int soma = homemMaisVelho + mulherMaisNova;
            int produto = homemMaisNovo * mulherMaisVelha;

            Console.WriteLine($"Soma das idades do homem mais velho com a mulher mais nova: {soma}");
            Console.WriteLine($"Produto das idades do homem mais novo com a mulher mais velha: {produto}");

            Console.ReadKey();
        }
    }
}
  
