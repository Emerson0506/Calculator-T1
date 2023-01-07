
using Calculadora1;

Factors factors = new Factors();
Operation operations = new Operation();
string[] operationsf = new string[4];
operationsf[0] = "/";
operationsf[1] = "+";
operationsf[2] = "-";
operationsf[3] = "*";

Console.WriteLine("Bem vindo a sua calculadora 1/3, digite '1' para iniciar ou '0' para sair.");
int iniciality = int.Parse(Console.ReadLine());

if (iniciality != 1 && iniciality != 0)

{ 
    Console.Clear();
    Console.WriteLine("Digite uma opção válida.\n");
    operations.Menu();
    iniciality = int.Parse(Console.ReadLine());
    Console.Clear();
}
else
{
    while (iniciality == 1)
    {

        Console.Clear();
        Console.WriteLine($"\n{factors.InConsole}\n\n1 2 3 +\n4 5 6 -\n7 8 9 /\n= 0 *");
        factors.Number1 = int.Parse(Console.ReadLine());
        factors.InConsole = ($"{factors.Number1}");
        Console.Clear();

        Console.WriteLine($"\n{factors.InConsole}\n\n1 2 3 +\n4 5 6 -\n7 8 9 /\n= 0 *");
        factors.ChooseOperation = char.Parse(Console.ReadLine());

        Console.Clear();

        while (factors.ChooseOperation != '/' && factors.ChooseOperation != '*' && factors.ChooseOperation != '-' && factors.ChooseOperation != '+')
        {
            Console.WriteLine("Siga o padrão e escolha uma operação.\n");
            Console.WriteLine($"\n{factors.InConsole}\n\n1 2 3 +\n4 5 6 -\n7 8 9 /\n= 0 *");
            factors.ChooseOperation = char.Parse(Console.ReadLine());
            Console.Clear();

        }

        switch (factors.ChooseOperation)
        {
            case '+':

                factors.InsertNumber2();
                operations.Adding(factors.Number1, factors.Number2, factors.InConsole);

                return;

            case '/':

                factors.InsertNumber2();
                operations.Share(factors.Number1, factors.Number2, factors.InConsole);

                return;

            case '*':

                factors.InsertNumber2();
                operations.Multiply(factors.Number1, factors.Number2, factors.InConsole);

                return;

            case '-':

                factors.InsertNumber2();
                operations.Subtract(factors.Number1, factors.Number2, factors.InConsole);

                return;

        }
    }
}