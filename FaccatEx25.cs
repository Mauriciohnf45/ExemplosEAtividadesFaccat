using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos
{
    internal class FaccatEx25
    {
       public static void Main(string[] args)
        {
            Console.Write("Digite o número da conta do cliente: ");
            string numeroConta = Console.ReadLine();

            Console.Write("Digite o saldo: ");
            double saldo = double.Parse(Console.ReadLine());

            Console.Write("Digite o débito: ");
            double debito = double.Parse(Console.ReadLine());

            Console.Write("Digite o crédito: ");
            double credito = double.Parse(Console.ReadLine());

            double saldoAtual = saldo - debito + credito;

            Console.WriteLine($"O saldo atual da conta {numeroConta} é: R$ {saldoAtual:F2}");

            if (saldoAtual >= 0)
            {
                Console.WriteLine("Saldo Positivo.");
            }
            else
            {
                Console.WriteLine("Saldo Negativo.");
            }

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
    
