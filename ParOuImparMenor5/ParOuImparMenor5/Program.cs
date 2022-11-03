using System;

namespace ParOuImparMenor5 {
    internal class Program {
        static void Main(string[] args) {

            int pares = 0;
            int impares= 0;

            int qtdNum = 0;

            do
            {
                Console.WriteLine("Digite um valor inteiro: ");
                int num = int.Parse(Console.ReadLine());

                qtdNum++;
                if(num % 2 == 0)   
                {
                    pares++;
                } else
                {
                    impares++;
                };

                Console.WriteLine("Quantidade de pares: " + pares);
                Console.WriteLine("Quantidade de impares: " + impares);

            } while (pares < 5 && impares < 5);


            Console.ReadKey();

        }
    }
}
