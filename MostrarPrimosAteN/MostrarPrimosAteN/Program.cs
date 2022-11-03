using System;
using System.Numerics;

namespace MostrarPrimosAteN {
    internal class Program {
        static void Main(string[] args) {
            int n;
            do
            {
                Console.WriteLine("Informe um valor inteiro");
                n = int.Parse(Console.ReadLine());
            } while (n < 2);

            int primos = 0;

            for (int i = 2; i <= n; i++)
            {
                int divisores = 0;
                for(int j = 1; j <= i; j++)
                {
                    if(i % j == 0)
                    {
                        divisores++;
                    }

                    if(divisores == 2)
                    {
                        Console.WriteLine(i);
                        primos++;
                    }
                }
            }

            Console.WriteLine("Quantidade de números primos: " + n);
        }
    }
}
