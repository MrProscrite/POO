using System;
using System.Collections.Generic;
using System.Text;

namespace POO.Poli
{
    public class Polimorfismo
    {
        public void Execucao()
        {
            Console.WriteLine("Digite o primeiro número: ");
            var numero1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Digite o segundo número: ");
            var numero2 = Convert.ToInt16(Console.ReadLine());

            var ChamarMetodo = Somar(numero1, numero2);

        }

        public int Somar(int numero1, int numero2)
        {
            var result = numero1 + numero2;

            return result;
        }

        public int Somar(int valor1, int valor2, int valor3)
        {
            var result = valor1 + valor2 + valor3;

            return result;
        }
    }
}
