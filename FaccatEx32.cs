using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos
{
    internal class FaccatEx32
    {
      public  static void Main(string[] args)
        {
            Console.Write("Digite o nome do primeiro time: ");
            string time1 = Console.ReadLine();

            Console.Write("Digite o número de gols do primeiro time: ");
            int golsTime1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do segundo time: ");
            string time2 = Console.ReadLine();

            Console.Write("Digite o número de gols do segundo time: ");
            int golsTime2 = int.Parse(Console.ReadLine());

            if (golsTime1 > golsTime2)
            {
                Console.WriteLine($"O vencedor é o time {time1}.");
            }
            else if (golsTime2 > golsTime1)
            {
                Console.WriteLine($"O vencedor é o time {time2}.");
            }
            else
            {
                Console.WriteLine("EMPATE.");
            }

            Console.ReadKey();
        }
    }
}
    
