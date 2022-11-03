using System;

namespace ParesOrdenados {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre com um número positivo: ");
            int num = int.Parse(Console.ReadLine());

            int count = 0;
            for (int i = 0; i <= num; i++)
            {
                for(int j = 0; j <= num; j++)
                {
                    Console.WriteLine($"({i}, {j})");
                    count++;
                }
            }

            Console.WriteLine("Quantidade: " + count);
        }
    }
}
