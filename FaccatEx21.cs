using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos
{
    internal class FaccatEx21
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite a hora de início do jogo: ");
            int horaInicio = int.Parse(Console.ReadLine());

            Console.Write("Digite a hora de término do jogo: ");
            int horaFim = int.Parse(Console.ReadLine());

            int duracao;

            if (horaFim > horaInicio)
            {
                duracao = horaFim - horaInicio;
            }
            else
            {
                duracao = (24 - horaInicio) + horaFim;
            }

            Console.WriteLine($"A duração do jogo foi de {duracao} horas.");
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
   
