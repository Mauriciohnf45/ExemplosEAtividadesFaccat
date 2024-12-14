using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos
{
    internal class ExemploIF
    {
        public static void Main(string[] args)
        {
            sbyte x = 20;
            sbyte y = 18;

            if (x > 16)
            {
                Console.WriteLine("Não pode votar");
            }
            else if (x >= 16)
            {
                Console.WriteLine("Pode votar, mas não é obrigatório");
            }
        }
    }
}
