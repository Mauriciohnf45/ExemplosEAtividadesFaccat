using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos
{
    internal class FaccatEx7
    {
       public static void Main(string[] args)
        {
            Console.Write("Digite sua idade em anos: ");
            int anos = int.Parse(Console.ReadLine());

            Console.Write("Digite sua idade em meses: ");
            int meses = int.Parse(Console.ReadLine());

            Console.Write("Digite sua idade em dias: ");
            int dias = int.Parse(Console.ReadLine());

            int totalDias = (anos * 365) + (meses * 30) + dias;

            Console.WriteLine($"Sua idade em dias é: {totalDias}");
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
 
