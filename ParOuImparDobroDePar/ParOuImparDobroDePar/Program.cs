using System;

namespace ParOuImparDobroDePar {
    internal class Program {
        static void Main(string[] args) {

            int pares = 0;
            int impares = 0;

            do
            {
                Console.WriteLine("Entre com um número inteiro:");
                int num = int.Parse(Console.ReadLine());

                if(num % 2 == 0)
                {
                    pares++;
                } else impares++;

                Console.WriteLine("Quantidade de pares: " + pares);
                Console.WriteLine("Quantidade de impares: " + impares);
            } while (impares * 2 != pares);

            if(x > y)
            {
                cw("X é maior")
            }
        }
    }
}
