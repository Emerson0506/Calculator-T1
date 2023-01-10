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

        Factors factors = new Factors();

        public double Result { get; set; }
        public double Adding(double Number1, double Number2, string facConsole)
        {

            Result = Number1 + Number2;
            Console.WriteLine($"{facConsole} = {Result}");
            return Result;

        }
        public double Subtract(double Number1, double Number2, string facConsole)
        {

            Result = factors.Number1 - factors.Number2;
            Console.WriteLine($"{facConsole} = {Result}");
            return Result;




        }
        public double Share(double Number1, double Number2, string facConsole)
        {

            Result = factors.Number1 / factors.Number2;
            Console.WriteLine($"{facConsole} = {Result}");
            return Result;

        }
        public double Multiply(double Number1, double Number2, string facConsole)
        {

            Result = factors.Number1 * factors.Number2;
            Console.WriteLine($"{facConsole} = {Result}");
            return Result;

        }

        public string Menu()
        {
            
            Console.WriteLine("Bem vindo a sua calculadora 1/3, digite '1' para iniciar ou '0' para sair.");
            return "";
        }

    }
}
