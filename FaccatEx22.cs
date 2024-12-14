using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos
{
    internal class FaccatEx22
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite o número de horas trabalhadas no mês: ");
            int horasTrabalhadas = int.Parse(Console.ReadLine());

            Console.Write("Digite o salário por hora: ");
            double salarioPorHora = double.Parse(Console.ReadLine());

            int horasSemanais = 40;
            int horasMensais = horasSemanais * 4;

            double salarioBase = horasMensais * salarioPorHora;
            double salarioTotal;

            if (horasTrabalhadas > horasMensais)
            {
                int horasExtras = horasTrabalhadas - horasMensais;
                double valorHoraExtra = salarioPorHora * 1.5;
                salarioTotal = salarioBase + (horasExtras * valorHoraExtra);
            }
            else
            {
                salarioTotal = horasTrabalhadas * salarioPorHora;
            }

            Console.WriteLine($"O salário total do funcionário é: R$ {salarioTotal:F2}");
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
   
