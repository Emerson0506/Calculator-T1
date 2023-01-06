
using Calculadora1;
using System.Globalization;

Factors factors = new Factors();

Operation operations = new Operation();

Console.WriteLine("Bem vindo a sua calculadora 1/3, digite '1' para iniciar ou '0' para sair.");
int iniciality = int.Parse(Console.ReadLine());

if (iniciality != 1 && iniciality != 0) {

    Console.Clear();
    Console.WriteLine("Digite uma opção válida.\n");
    operations.Menu();
    iniciality = int.Parse(Console.ReadLine());
    Console.Clear(); 
}
else {
    while (iniciality == 1) {

        Console.Clear();
        Console.WriteLine($"\n{factors.Console}\n\n1 2 3 +\n4 5 6 -\n7 8 9 /\n= 0 *");
        factors.Number1 = int.Parse(Console.ReadLine());
        factors.Console = ($"{factors.Number1}");
        Console.Clear();

        Console.WriteLine($"\n{factors.Console}\n\n1 2 3 +\n4 5 6 -\n7 8 9 /\n= 0 *");
        factors.Operation = Console.ReadLine();
        factors.Console += ($" {factors.Operation}");
        Console.Clear();

        switch (factors.Operation) {

            case "+":

                Console.WriteLine($"\n{factors.Console}\n\n1 2 3 +\n4 5 6 -\n7 8 9 /\n= 0 *");
                factors.Number2 = int.Parse(Console.ReadLine());
                factors.Console += ($" {factors.Number2}");
                Console.Clear();

                operations.Adding(factors.Number1, factors.Number2);
                Console.WriteLine($"{factors.Console} = {operations.Result}");

                return;

            case "/":

                Console.WriteLine($"\n{factors.Console}\n\n1 2 3 +\n4 5 6 -\n7 8 9 /\n= 0 *");
                factors.Number2 = int.Parse(Console.ReadLine());
                factors.Console += ($" {factors.Number2}");
                Console.Clear();

                operations.Share(factors.Number1, factors.Number2);
                Console.WriteLine($"{factors.Console} = {operations.Result}");

                return;

            case "*":

                Console.WriteLine($"\n{factors.Console}\n\n1 2 3 +\n4 5 6 -\n7 8 9 /\n= 0 *");
                factors.Number2 = int.Parse(Console.ReadLine());
                factors.Console += ($" {factors.Number2}");
                Console.Clear();

                operations.Multiply(factors.Number1, factors.Number2);
                Console.WriteLine($"{factors.Console} = {operations.Result}");

                return;

            case "-":

                Console.WriteLine($"\n{factors.Console}\n\n1 2 3 +\n4 5 6 -\n7 8 9 /\n=  0  *");
                factors.Number2 = int.Parse(Console.ReadLine());
                factors.Console += ($" {factors.Number2}");
                Console.Clear();

                operations.Subtract(factors.Number1, factors.Number2);
                Console.WriteLine($"{factors.Console} = {operations.Result}");

                return;

        }

    }
}
