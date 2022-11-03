using System;
using System.Data;

namespace CalcularSaldoConta {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Forneça o saldo da conta: ");
            double saldoConta = double.Parse(Console.ReadLine());

            Console.Write("Quantidade de lançamentos realizados: ");
            int qtdLanca = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtdLanca; i++)
            {
                Console.WriteLine("1 PARA DÉBITO e 2 PARA CRÉDITO");
                string debOrCred = Console.ReadLine();

                Console.Write("VALOR: ");
                double valor = double.Parse(Console.ReadLine());  

                if (debOrCred == "1")
                {
                    saldoConta -= valor;
                } else
                {
                    saldoConta += valor;
                }
            }

            Console.WriteLine("O VALOR FINAL DA CONTA É: " + saldoConta);   
        }
    }
}
