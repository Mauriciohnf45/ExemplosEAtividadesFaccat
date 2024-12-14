using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos
{
    internal class FaccatEx11
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite o salário fixo do vendedor: ");
            double salarioFixo = double.Parse(Console.ReadLine());

            Console.Write("Digite o número de carros vendidos: ");
            int carrosVendidos = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor total das vendas: ");
            double valorTotalVendas = double.Parse(Console.ReadLine());

            Console.Write("Digite a comissão fixa por carro vendido: ");
            double comissaoPorCarro = double.Parse(Console.ReadLine());

            double comissaoCarros = carrosVendidos * comissaoPorCarro;
            double comissaoPercentual = valorTotalVendas * 0.05;
            double salarioFinal = salarioFixo + comissaoCarros + comissaoPercentual;

            Console.WriteLine($"O salário final do vendedor é: {salarioFinal:F2}");
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
   
