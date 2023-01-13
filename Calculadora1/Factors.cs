using System.Runtime.InteropServices;

namespace Calculadora1
{
    public class Factors
    {
        Operation operations = new Operation();
        public double Number1 { get; set; }
        public double Number2 { get; set; }

        public double Result { get; set; }
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

        public void MostrarCalculo(double result, string Inconsole)
        {
            Result = result;
            Inconsole += ($" = {Result}");
            Operation.Menu2(Inconsole);
        }
        public void MostrarCalculo2(double result, string Inconsole)
        {
            Result = result;
            Inconsole += ($" = {Result}");
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
    }
}



