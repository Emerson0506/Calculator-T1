
using Calculadora1;
using System.Text.RegularExpressions;

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
while (iniciality == "1")
{
    Console.Clear();
    Operation.Menu2(factors.InConsole);
    factors.Number1 = factors.InvalidMessage(Console.ReadLine());
    factors.InConsole = ($"{factors.Number1}");

   var operacao = operations.DescobrirOperacao(factors.InConsole);

    Operation.Menu2(factors.InConsole);

    factors.Number2 = factors.InvalidMessage(Console.ReadLine());

    factors.InConsole = "";
    factors.InConsole = ($" {factors.Number1} {operacao} {factors.Number2}");

    factors.ChoosingOperation(operacao, factors.Number1, factors.Number2);
}