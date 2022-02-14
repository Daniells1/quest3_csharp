/*
 Escreva um algoritmo para calcular e escrever o valor de S, sendo S dado pela fórmula:
S = 1 + 1/2 + 1/3 + … + 1/100.

Entrada
Não há nenhuma entrada neste problema.

Saída
A saída contém um valor correspondente ao valor de S.
O valor deve ser impresso com dois dígitos após o ponto decimal.
 */

using System;


namespace quest3_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 1;
            double s = 0;



            while (a <= 100)
            {
                s = s + 1 / a;
                a++;


            }
            Console.WriteLine(Math.Round(s, 2));
            Console.ReadLine();

        }
    }
}
