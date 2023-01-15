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
        

        public void MostrarCalculo(double result, string Inconsole)
        {
            Result = result;
            Inconsole += ($" = {Result}");
            Operation.Menu2(Inconsole);
        }
        public void MostrarCalculo2(double result, string Inconsole)
        {
            Result = result;
            Inconsole += ($" = {Result.ToString("F2")}");
        }


        public void ChoosingOperation(char chooseOperation, double number1, double number2, string InConsole)
        {

            if (chooseOperation == '+')
            {
               double addResult = operations.Adding(number1, number2);
               MostrarCalculo(addResult, InConsole);       
            }

            if (chooseOperation == '/')
            {

               double divResult = operations.Share(number1, number2);
               MostrarCalculo(divResult, InConsole);

            }

            if (chooseOperation == '*')
            { 
               double multResult = operations.Multiply(number1, number2);
               MostrarCalculo(multResult, InConsole);
            }

            if (chooseOperation == '-')
            {
               double subResult = operations.Subtract(number1, number2);
               MostrarCalculo(subResult, InConsole);

            }
            
        }
        public void ChoosingOperation2(char chooseOperation, double number1, double number2, string InConsole)
        {

            if (chooseOperation == '+')
            {
                double addResult = operations.Adding(number1, number2);
                MostrarCalculo2(addResult, InConsole);
            }

            if (chooseOperation == '/')
            {

                double divResult = operations.Share(number1, number2);
                MostrarCalculo2(divResult, InConsole);

            }

            if (chooseOperation == '*')
            {
                double multResult = operations.Multiply(number1, number2);
                MostrarCalculo2(multResult, InConsole);
            }

            if (chooseOperation == '-')
            {
                double subResult = operations.Subtract(number1, number2);
                MostrarCalculo2(subResult, InConsole);

            }

        }
        public string ConsoleIsNull()
        {
            string inConsole = "";
            return inConsole;
        }
    }
}



