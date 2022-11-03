using System;

namespace PontuacaoPorJogos {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Digite a quantidade de jogos realizados por uma equipe:  ");
            int qtdJogos = int.Parse(Console.ReadLine());

            int pontuacao = 0;

            for(int i = 0; i < qtdJogos; i++)
            {
                Console.WriteLine("(1 para vitória, 2 para derrota ou 3 para empate)");
                Console.Write("Escreva o resultado: ");
                string result = Console.ReadLine();

                if(result == "1")
                {
                    pontuacao += 3;
                } else if(result == "3")
                {
                    pontuacao++;
                }

            }

            Console.WriteLine("A pontuação é: " + pontuacao);

            Console.ReadKey();

        }
    }
}
