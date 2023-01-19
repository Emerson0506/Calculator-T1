
using Calculadora1;
using System;
using System.Net.WebSockets;
using System.Text.RegularExpressions;

Factors factors = new Factors();
Operation operations = new Operation();
Validates validate = new Validates();

string operacao;
var infinity = "";

Console.WriteLine("Bem vindo a sua calculadora 1/3, digite '1' para iniciar ou '0' para sair.");
string iniciality = Console.ReadLine();
iniciality = validate.InvalidIniciality(iniciality);

while (iniciality == "1")
{
    while (infinity != "Potatoes")
    {
        factors.InConsole = factors.ConsoleIsNull();
        Operation.Menu2(factors.InConsole);
        factors.Number1 = validate.NumbersInvalidMessage(Console.ReadLine());

        if (factors.Number1 == 30062000)
        {
            factors.InConsole = factors.ConsoleIsNull();
            break;
        }
        factors.InConsole = ($"{factors.Number1}");

        Operation.Menu2(factors.InConsole);

        string operacao1 = operations.SearchOperation(factors.InConsole) ;
        factors.InConsole += ($" {operacao1}");
        if (operacao1 == "c")
        {
            factors.InConsole = factors.ConsoleIsNull();
            break;
        }
        Operation.Menu2(factors.InConsole);

        factors.Number2 = validate.NumbersInvalidMessage(Console.ReadLine());
        factors.InConsole += ($" {factors.Number2}");
        if (factors.Number2 == 30062000)
        {
            factors.InConsole = factors.ConsoleIsNull();
            break;
        }
        Operation.Menu2(factors.InConsole);
        factors.ChoosingOperation(operacao1, factors.Number1, factors.Number2, factors.InConsole);
        operacao = operations.SearchOperation2(factors.InConsole);
        if (operacao == "c")
        {
            factors.InConsole = factors.ConsoleIsNull();
            break;
        }
        if (operacao != "=")
        {
            while (operacao != "=")
            {
                if (operacao == "-" || operacao == "/" || operacao == "*" || operacao == "+")
                {
                    factors.Number1 = factors.Result;
                    factors.InConsole = ($"{factors.Number1} {operacao}");
                    Operation.Menu2(factors.InConsole);
                    factors.Number2 = validate.NumbersInvalidMessage(Console.ReadLine());
                    if (factors.Number2 == 30062000)
                    {
                        factors.InConsole = factors.ConsoleIsNull();
                        break;
                    }

                    factors.InConsole += ($" {factors.Number2}");
                    Operation.Menu2(factors.InConsole);
                    factors.ChoosingOperation(operacao, factors.Number1, factors.Number2, factors.InConsole);
                    operacao1 = operacao;
                    operacao = operations.SearchOperation2(factors.InConsole);
                    if (operacao == "c")
                    {
                        factors.InConsole = factors.ConsoleIsNull();
                        break;
                    }

                    if (operacao == "=")
                    {
                        Operation.ResultMenu(factors.Result);
                        Console.ReadKey();
                    }
                    
                }
                if (operacao == "%" || operacao1 == "%")
                {
                    if (operacao1 == "-" || operacao1 == "+")
                    {
                        factors.Number2 = factors.Number1 * (factors.Number2 / 100);
                        factors.InConsole = $"{factors.Number1} {operacao1} {factors.Number2}";
                        Operation.Menu2(factors.InConsole);
                        operacao = operacao1;
                        factors.ChoosingOperation(operacao, factors.Number1, factors.Number2, factors.InConsole);
                        operacao = operations.SearchOperation2(factors.InConsole);
                        if (operacao == "c")
                        {
                            factors.InConsole = factors.ConsoleIsNull();
                            break;
                        }
                    }
                    if(operacao1 == "*" || operacao1 == "/")
                    {
                        factors.Number2 = factors.Number2 / 100;
                        factors.InConsole = $"{factors.Number1} {operacao1} {factors.Number2}";
                        Operation.Menu2(factors.InConsole);
                        operacao = operacao1;
                        factors.ChoosingOperation(operacao, factors.Number1, factors.Number2, factors.InConsole);
                        operacao = operations.SearchOperation2(factors.InConsole);
                        if (operacao == "c")
                        {
                            factors.InConsole = factors.ConsoleIsNull();
                            break;
                        }
                    }
                }
            }
        }
        if(operacao == "=")
        {
            Operation.ResultMenu(factors.Result);
            Console.ReadKey();
        }
            
    }
}