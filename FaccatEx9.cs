using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos
{
    internal class FaccatEx9
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite o salário atual do funcionário: ");
            double salarioAtual = double.Parse(Console.ReadLine());

            Console.Write("Digite o percentual de reajuste (%): ");
            double percentualReajuste = double.Parse(Console.ReadLine());

            double novoSalario = salarioAtual + (salarioAtual * percentualReajuste / 100);

            Console.WriteLine($"O novo salário é: {novoSalario:F2}");
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
   
