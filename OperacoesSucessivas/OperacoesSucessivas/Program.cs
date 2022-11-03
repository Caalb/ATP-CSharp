using System;

namespace OperacoesSucessivas {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Digite o valor de X");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de Y");
            int y = int.Parse(Console.ReadLine());

            int adicaoSucessiva = 0;
            for(int i = 0; i < y; i++)
            {
                adicaoSucessiva += x;
            }

            Console.WriteLine($"A adiçãoSucessiva entre esses dois valores é: {adicaoSucessiva}");

            int multiplicacaoSucessivas = 1;
            for(int i = 0; i < y; i++)
            {
                multiplicacaoSucessivas *= x;
            }

            Console.WriteLine($"A multiplicacaoSucessiva entre esses dois valores é: {multiplicacaoSucessivas}");

            int fatorial = 1;

            for (int i = x; i >= 1; i--)
            {
                fatorial = fatorial * i;
            }

            Console.WriteLine($"A fatorial de {x} é: {fatorial}");

            Console.ReadLine();
        }
    }
}
