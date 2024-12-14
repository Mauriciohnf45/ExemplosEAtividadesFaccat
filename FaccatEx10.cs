using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos
{
    internal class FaccatEx10
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite o custo de fábrica do carro: ");
            double custoFabrica = double.Parse(Console.ReadLine());

            double distribuidor = custoFabrica * 0.28;
            double impostos = custoFabrica * 0.45;
            double custoFinal = custoFabrica + distribuidor + impostos;

            Console.WriteLine($"O custo final ao consumidor é: {custoFinal:F2}");
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}

