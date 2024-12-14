using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos
{
    internal class Sucessor { 
    public static void Main(string[] args)
    {
        Console.Write("Digite um número: ");
        int valor = int.Parse(Console.ReadLine());
        int antecessor = valor + 1;
        Console.WriteLine($"O antecessor de {valor} é {antecessor}.");
    }
}
}
