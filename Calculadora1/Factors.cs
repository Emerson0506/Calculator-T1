using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculadora1;

namespace Calculadora1
{
    public class Factors
    {
        Operation operations = new Operation();
        public double Number1 { get; set; }
        public double Number2 { get; set; }


        public char ChooseOperation { get; set; }

        public string InConsole { get; set; }

        public void InsertNumber2()
        {
            {

                InConsole += ($" {ChooseOperation}");
                Console.WriteLine($"\n{InConsole}\n\n1 2 3 +\n4 5 6 -\n7 8 9 /\n= 0 *");
                Number2 = InvalidMessage(Console.ReadLine());
                InConsole += ($" {Number2}");
                Console.Clear();
            }
        }
        public int InvalidMessage(string n1)
        {
            while (true)
            {
                if (String.IsNullOrEmpty(n1))
                {
                    Console.Clear();
                    Console.WriteLine("Número inválido, tente novamente.");
                    Operation.Menu2(InConsole);
                    n1 = Console.ReadLine();
                }
                else
                {
                    break;
                }

            }
            return Convert.ToInt32(n1);
        }
        public void ChoosingOperation(char chooseOperation, double number1, double number2)
        {
            switch (chooseOperation)
            {
                case '+':

                    //InsertNumber2();
                    var resultadoAdição = operations.Adding(number1, number2, operations.Number, InConsole);
                    operations.MostrarCalculo(number1, number2, resultadoAdição, '+', InConsole);

                    return;

                case '/':

                    //InsertNumber2();
                    var resultadoDivisao = operations.Share(number1, number2, InConsole);
                    operations.MostrarCalculo(number1, number2, resultadoDivisao, '/', InConsole);

                    return;

                case '*':

                    //InsertNumber2();
                    var resultadoMult = operations.Multiply(number1, number2, InConsole);
                    operations.MostrarCalculo(number1, number2, resultadoMult, '*', InConsole);

                    return;

                case '-':

                    //InsertNumber2();
                    var resultadoSub = operations.Subtract(number1, number2, InConsole);
                    operations.MostrarCalculo(number1, number2, resultadoSub, '-', InConsole);

                    return;
            }

        }


    }


}


