using System;

namespace SequenciaFibonacci {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Forneça a quantidade de números exibidos: ");
            int num = int.Parse(Console.ReadLine());

            int inicial = 1;
            int fibo = 0;
            for(int i = 0; i < num; i++)
            {
                int soma = inicial + fibo;
                inicial = fibo;
                fibo = soma;   
                Console.WriteLine(soma);
            }
        }
    }
}
