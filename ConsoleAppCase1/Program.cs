using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCase1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o 1º número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 2º número: ");
           double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a operação: ");
            string op = Console.ReadLine();

            switch (op)
            {
                case "+":
                    double result = num1 + num2;
                    Console.WriteLine("O resultado da operação é " + result);
                    break;

                case "-":
                    result = num1 - num2;
                    Console.WriteLine("O resultado da operação é " + result);
                    break;

                case "*":
                    result = num1 * num2;
                    Console.WriteLine("O resultado da operação é " + result);
                    break;

                case "/":
                    result = num1 / num2;
                    Console.WriteLine("O resultado da operação é " + result);
                    break;

                default:
                    Console.WriteLine("Opção Inválida");
                    break;

            }

            Console.ReadKey();
        }
    }
}
