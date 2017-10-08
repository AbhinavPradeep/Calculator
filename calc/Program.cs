using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;
            double number1, number2, result;
            string strnumber1, strnumber2;
            Calculator calc = new Calculator();

            do
            {
                Console.WriteLine("What do you want to do ? (A)dd, (S)ubtract, (M)ultiply, (D)ivide or (Q)uit");
                choice = Console.ReadLine();

                if (choice == "A" || choice == "a")
                {
                    Console.WriteLine("Enter Number 1");
                    strnumber1 = Console.ReadLine();
                    double.TryParse(strnumber1, out number1);

                    Console.WriteLine("Enter Number 2");
                    strnumber2 = Console.ReadLine();
                    double.TryParse(strnumber2, out number2);

                    result = calc.Add(number1 , number2);
                    Console.WriteLine("Result is " + result);
                }
                else if (choice == "S" || choice == "s")
                {
                    Console.WriteLine("Enter Number 1");
                    strnumber1 = Console.ReadLine();
                    double.TryParse(strnumber1, out number1);

                    Console.WriteLine("Enter Number 2");
                    strnumber2 = Console.ReadLine();
                    double.TryParse(strnumber2, out number2);

                    result = calc.Subtract(number1, number2);
                    Console.WriteLine("Result is " + result);
                }
                else if (choice == "M" || choice == "m")
                {
                    Console.WriteLine("Enter Number 1");
                    strnumber1 = Console.ReadLine();
                    double.TryParse(strnumber1, out number1);

                    Console.WriteLine("Enter Number 2");
                    strnumber2 = Console.ReadLine();
                    double.TryParse(strnumber2, out number2);

                    result = calc.Multiply(number1, number2);
                    Console.WriteLine("Result is " + result);
                }
                else if (choice == "D" || choice == "d")
                {
                    Console.WriteLine("Enter Number 1");
                    strnumber1 = Console.ReadLine();
                    double.TryParse(strnumber1, out number1);

                    Console.WriteLine("Enter Number 2");
                    strnumber2 = Console.ReadLine();
                    double.TryParse(strnumber2, out number2);

                    result = calc.Divide(number1, number2);
                    Console.WriteLine("Result is " + result);
                }
            } while ((choice != "Q") && (choice != "q"));

            Environment.Exit(0);

        }

        
    }
}
