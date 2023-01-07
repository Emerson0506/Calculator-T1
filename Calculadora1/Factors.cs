using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculadora1;

namespace Calculadora1
{
    public class Factors
    {

        public double Number1 { get; set; }
        public double Number2 { get; set; }

        public char ChooseOperation { get; set; }

        public string InConsole { get; set; }
        public void InsertNumber2()
        {
            InConsole += ($" {ChooseOperation}");
            Console.WriteLine($"\n{InConsole}\n\n1 2 3 +\n4 5 6 -\n7 8 9 /\n= 0 *");
            Number2 = double.Parse(Console.ReadLine());
            InConsole += ($" {Number2}");
            Console.Clear();
            
        }
    }
}

