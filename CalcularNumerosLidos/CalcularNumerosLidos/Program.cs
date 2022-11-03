using System;
using System.Collections.Generic;
using System.Linq;

namespace CalcularNumerosLidos {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Infome a quantidade números: ");
            int qtdNum = int.Parse(Console.ReadLine());

            int soma = 0;
            int maior = int.MinValue;
            int menor = int.MaxValue; ;
            int qtdNumPos = 0;
            int qtdNumNeg = 0;
            int qtdNumNul = 0;
            
            for(int i = 1; i <= qtdNum; i++)
            {
                Console.Write($"Informe o {i} número: ");
                int num = int.Parse(Console.ReadLine());

                soma += num;

                if(num > maior)
                {
                    maior = num; 
                }
                if(num < menor)
                {
                    menor = num;
                }


                if (num > 0)
                {
                    qtdNumPos++;
                }
                else if (num < 0)
                {
                    qtdNumNeg++;
                }
                else qtdNumNul++;
            }

            Console.WriteLine("Soma: " + soma);
            Console.WriteLine("Media: " + (soma / qtdNum));
            Console.WriteLine("Maior número fornecido: " + maior);
            Console.WriteLine("Menor número fornecido: " + menor);
            Console.WriteLine("Quantidade de números positivos: " + qtdNumPos);
            Console.WriteLine("Quantidade de números negativos: " + qtdNumNeg);
            Console.WriteLine("Quantidade de números nulos: " + qtdNumNul);

        }
    }
}
