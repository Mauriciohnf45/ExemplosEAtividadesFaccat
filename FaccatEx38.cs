using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos
{
    internal class FaccatEx38
    {
      public  static void Main(string[] args)
        {
            const int codigoCorreto = 1234;
            const int senhaCorreta = 9999;

            Console.Write("Digite o código do usuário: ");
            int codigoUsuario = int.Parse(Console.ReadLine());

            if (codigoUsuario != codigoCorreto)
            {
                Console.WriteLine("Usuário inválido!");
            }
            else
            {
                Console.Write("Digite a senha: ");
                int senha = int.Parse(Console.ReadLine());

                if (senha != senhaCorreta)
                {
                    Console.WriteLine("Senha incorreta!");
                }
                else
                {
                    Console.WriteLine("Acesso permitido.");
                }
            }

            Console.ReadKey();
        }
    }
}
   
