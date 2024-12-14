using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos
{
    internal class FaccatEx18
    {
       public static void Main(string[] args)
        {
            Console.Write("Digite o ano atual: ");
            int anoAtual = int.Parse(Console.ReadLine());

            Console.Write("Digite o ano de nascimento: ");
            int anoNascimento = int.Parse(Console.ReadLine());

            int idade = anoAtual - anoNascimento;

            if (idade >= 16)
            {
                Console.WriteLine("Você pode votar este ano.");
            }
            else
            {
                Console.WriteLine("Você NÃO pode votar este ano.");
            }

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
    
