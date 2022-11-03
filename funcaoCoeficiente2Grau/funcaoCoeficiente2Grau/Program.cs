using System;

namespace funcaoCoeficiente2Grau {
    internal class Program {

        static int calculaDelta(int a, int b, int c) {
            return (b * b - 4 * a * c);
        }

        static int calculaRaizes(int a, int b, int c) {

        }
        
        static void Main(string[] args) {
            Console.WriteLine("Informe o coeficiente A");
            double a = double.Parse(Console.ReadLine());  
        }
    }
}
