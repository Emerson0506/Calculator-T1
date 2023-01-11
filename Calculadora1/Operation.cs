using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculadora1;

namespace Calculadora1
{

    public class Operation
    {

        public double Number { get; set; }
        public double Result { get; set; }
        public double FinalResult { get; set; }
        public double Adding(double Number1, double Number2, double Number, string facConsole)
        {
            Result = Number1 + Number2;
            return Result;

        }
        public double Subtract(double Number1, double Number2, string facConsole)
        {

            Result = Number1 - Number2;
            return Result;

        }
        public double Share(double Number1, double Number2, string facConsole)
        {

            Result = Number1 / Number2;
            return Result;

        }
        public double Multiply(double Number1, double Number2, string facConsole)
        {

            Result = Number1 * Number2;
            return Result;

        }

        public void Menu()
        {

            Console.WriteLine("Bem vindo a sua calculadora 1/3, digite '1' para iniciar ou '0' para sair.");
        }

        public static void Menu2(string facConsole)
        {
            Console.WriteLine($"\n{facConsole}\n\n1 2 3 +\n4 5 6 -\n7 8 9 /\n= 0 *");
        }
        public void MostrarCalculo(double number1, double number2, double result, char operation, string facConsole)
        {
            Console.WriteLine($" {number1} {operation} {number2} = {result}");
            Thread.Sleep(1000);
        }
        public char DescobrirOperacao(string InConsole)
        {
            Console.WriteLine("Escolha a operação:  / * - +");
            var operacao = char.Parse(Console.ReadLine());

            while (operacao != '/' && operacao != '*'
                && operacao != '-' && operacao != '+')
            {
                Console.WriteLine("Siga o padrão e escolha uma operação.\n");
                operacao = char.Parse(Console.ReadLine());
            }
            return operacao;
        }
    }
}
