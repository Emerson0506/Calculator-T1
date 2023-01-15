using System;
using System.Text.RegularExpressions;

namespace Calculadora1
{

    public class Operation
    {

        public double Number { get; set; }
        public double Result { get; set; }
        
        public double Adding(double Number1, double Number2)
        {
            double resultOp = Number1 + Number2;
            Result = resultOp;
            return Result;

        }
        public double Subtract(double Number1, double Number2)
        {
            Result = Number1 - Number2;
            return Result;
        }
        public double Share(double Number1, double Number2)
        {
            Result = Number1 / Number2;
            return Result;
        }
        public double Multiply(double Number1, double Number2)
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
            Console.Clear();
            Console.WriteLine($"\n\n{facConsole}\n\n  % c <\n1 2 3 +\n4 5 6 -\n7 8 9 /\n  0 * =");
        }

        public static void ResultMenu(double result)
        {
            Console.Clear();
            Console.WriteLine($"\n{$"Resultado : {result}"}\n\n  % c <\n1 2 3 +\n4 5 6 -\n7 8 9 /\n  0 * =");
        }
        public char SearchOperation()
        {
            var operacao = char.Parse(Console.ReadLine());
            
            while (operacao != '/' && operacao != '*'
                && operacao != '-' && operacao != '+' && operacao != 'c')
            {
                Console.WriteLine("Não há como obter um resultado sem ao menos 2 fatores!\n");
                operacao = char.Parse(Console.ReadLine());
            }
            return operacao;
        }
        public char SearchOperation2()
        {
            var operacao = char.Parse(Console.ReadLine());

            while (operacao != '/' && operacao != '*'
                && operacao != '-' && operacao != '+' && operacao != '=' && operacao != 'c')
            {
                Console.WriteLine("Digite uma operação ou ' = ' para receber seu resultado.");
                operacao = char.Parse(Console.ReadLine());
            }
            
            return operacao;
        }
    }
}
