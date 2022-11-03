using System;

namespace procedimentoPripeirosPositivosPares {
    internal class Program {

        static void MostrarPrimeirosPositvosPares(int x) {
            int i;

            Console.WriteLine($"\n {x} primeiros positivos pares: ");
            for(i = 1; i <= x; i++)
            {
                Console.WriteLine($"A posição é: {Par(i)},");
            }
        }

        static int Par(int x) {
            return x * 2;
        }
        static void Main(string[] args) {
            Console.WriteLine("Informe um valor");
            int n = int.Parse(Console.ReadLine());

            MostrarPrimeirosPositvosPares(n);
        }
    }
}
