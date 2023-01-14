
using Calculadora1;
using System;

Factors factors = new Factors();
Operation operations = new Operation();
string[] operationsf = new string[4];
operationsf[0] = "/";
operationsf[1] = "+";
operationsf[2] = "-";
operationsf[3] = "*";

Console.WriteLine("Bem vindo a sua calculadora 1/3, digite '1' para iniciar ou '0' para sair.");
string iniciality = Console.ReadLine();

while (iniciality != "1" && iniciality != "0" || String.IsNullOrEmpty(iniciality))

{
    Console.Clear();
    Console.WriteLine("Digite uma opção válida.\n");
    operations.Menu();
    iniciality = Console.ReadLine();
    Console.Clear();
}

Operation.Menu2(factors.InConsole);
factors.Number1 = factors.InvalidMessage(Console.ReadLine());
factors.InConsole = ($"{factors.Number1}");

Operation.Menu2(factors.InConsole);

var operacao1 = operations.DescobrirOperacao();
factors.InConsole += ($" {operacao1}");
Operation.Menu2(factors.InConsole);

factors.Number2 = factors.InvalidMessage(Console.ReadLine());
factors.InConsole += ($" {factors.Number2}");
Operation.Menu2(factors.InConsole);
factors.ChoosingOperation2(operacao1, factors.Number1, factors.Number2, factors.InConsole);
char operacao = operations.DescobrirOperacao2();

while (operacao != '=')
{
    if (operacao == '-' || operacao == '/' || operacao == '*' || operacao == '+')
    {
        factors.Number1 = factors.Result;
        factors.InConsole = ($"{factors.Number1} {operacao}");
        Operation.Menu2(factors.InConsole);
        factors.Number2 = factors.InvalidMessage(Console.ReadLine());
        factors.InConsole += ($" {factors.Number2}");
        Operation.Menu2(factors.InConsole);
        factors.ChoosingOperation2(operacao, factors.Number1, factors.Number2, factors.InConsole);
        operacao = operations.DescobrirOperacao2();

        if (operacao == '=')
        {
            Operation.ResultMenu(factors.Result);
            operacao = '=';
            Thread.Sleep(5000);
            Console.ReadKey();
        }

    }
}
        
        //factors.ChoosingOperation(operacao1, factors.Number1, factors.Number2, factors.InConsole);
        //operacao = '=';
        //string teste = Console.ReadLine();
        //Console.ReadKey();





