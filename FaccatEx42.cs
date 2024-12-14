using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos
{
    internal class FaccatEx42
    {
      public static void Main(string[] args)
        {
            Console.Write("Digite o número do empregado (código): ");
            int codigo = int.Parse(Console.ReadLine());

            Console.Write("Digite o ano de nascimento: ");
            int anoNascimento = int.Parse(Console.ReadLine());

            Console.Write("Digite o ano de ingresso na empresa: ");
            int anoIngresso = int.Parse(Console.ReadLine());

            int anoAtual = DateTime.Now.Year;
            int idade = anoAtual - anoNascimento;
            int tempoTrabalho = anoAtual - anoIngresso;

            Console.WriteLine($"\nCódigo do Empregado: {codigo}");
            Console.WriteLine($"Idade: {idade} anos");
            Console.WriteLine($"Tempo de Trabalho: {tempoTrabalho} anos");

            if (idade >= 65 || tempoTrabalho >= 30 || (idade >= 60 && tempoTrabalho >= 25))
            {
                Console.WriteLine("Requerer aposentadoria");
            }
            else
            {
                Console.WriteLine("Não requerer aposentadoria");
            }

            Console.ReadKey();
        }
    }
}
   
