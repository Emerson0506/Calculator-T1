using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Buffers;
using System.Xml.Schema;
using System.Security.Cryptography.X509Certificates;

namespace Calculadora1
{
    public class Validates
    {
        Factors factors = new Factors();
        Operation operations = new Operation();
        string pattern = @"\d[0-9]{0,}";
        bool regex = false;
        bool validNumber;
        public string InvalidIniciality(string iniciality)
        {
            while (iniciality != "1" && iniciality != "0" || String.IsNullOrEmpty(iniciality))

            {
                Console.Clear();
                Console.WriteLine("Digite uma opção válida.\n");
                operations.Menu();
                iniciality = Console.ReadLine();
                Console.Clear();
            }
            return iniciality;
        }

        public int NumbersInvalidMessage(string n1)
        {
            while (validNumber == false)
            {
                while (true)
                {
                    if (String.IsNullOrEmpty(n1))
                    {
                        Operation.Menu2(factors.InConsole);
                        Console.WriteLine("Por favor, digite algo para que possa ser realizado o cálculo.");
                        n1 = Console.ReadLine();
                    }
                    else
                    {
                        validNumber = true;
                        break;
                    }
                }

                Match match = Regex.Match(n1, pattern);

                while (match.Success == false)
                {
                    validNumber = false;
                    Operation.Menu2(factors.InConsole);
                    Console.WriteLine($" '{n1}' não é um número, tente novamente.");
                    n1 = Console.ReadLine();
                    match = Regex.Match(n1, pattern);

                    if (String.IsNullOrEmpty(n1))
                    {
                        break;
                    }
                }
            }
            if (n1 == "c")
            {
                n1 = "30062000";
            }
            return Convert.ToInt32(n1);

        }

    }
}
