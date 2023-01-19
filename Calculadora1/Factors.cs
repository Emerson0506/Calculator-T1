using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace Calculadora1
{
    public class Factors
    {
        Operation operations = new Operation();

        public double Number1 = 1;
        public double Number2 { get; set; }

        public double Result { get; set; }
        public char ChooseOperation { get; set; }

        public string InConsole { get; set; }
        
        public void MostrarCalculo(double result )
        {
            Result = result;
        }
        public void ChoosingOperation(string chooseOperation, double number1, double number2, string InConsole)
        {

            if (chooseOperation == "+")
            {
                double addResult = operations.Adding(number1, number2);
                MostrarCalculo(addResult);
            }

            if (chooseOperation == "/")
            {

                double divResult = operations.Share(number1, number2);
                MostrarCalculo(divResult);

            }

            if (chooseOperation == "*")
            {
                double multResult = operations.Multiply(number1, number2);
                MostrarCalculo(multResult);
            }

            if (chooseOperation == "-")
            {
                double subResult = operations.Subtract(number1, number2);
                MostrarCalculo(subResult);

            }

        }
        public string ConsoleIsNull()
        {
            string inConsole = "";
            return inConsole;
        }
    }
}



