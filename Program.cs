using System;



namespace ConsoleCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    decimal sum;
                    string num1, num2;

                    Console.WriteLine("===============================================================");
                    Console.WriteLine("Welcome to my first Calculator Program");
                    Console.WriteLine("===============================================================");
                    Console.WriteLine();
                    Console.WriteLine("Please put 2 numbers and the operators by following the prompt");
                    Console.WriteLine("Type 'exit' to exit the program");
                    Console.WriteLine();
                    Console.WriteLine("---------------------------------------------------------------");

                    Console.Write("Please enter your first number: ");
                    num1 = Console.ReadLine();
                    if (num1 == "exit")
                    {
                        break;
                    }

                    Console.WriteLine();

                    Console.WriteLine("'+' for Addition");
                    Console.WriteLine("'-' for Subtraction");
                    Console.WriteLine("'*' for Multiplication");
                    Console.WriteLine("'/' for Division");
                    Console.WriteLine("operator: ");
                    string ops = Console.ReadLine();
                    if (ops == "exit")
                    {
                        break;
                    }

                    Console.WriteLine();

                    Console.Write("Please enter your second number: ");
                    num2 = Console.ReadLine();
                    if (num2 == "exit")
                    {
                        break;
                    }

                    Console.WriteLine();

                    switch (ops)
                    {
                        case "+":
                            sum = Calculator.Addition(decimal.Parse(num1),decimal.Parse(num2));
                            Console.WriteLine("The answer is: {0}", sum);
                            Console.WriteLine();
                            break;

                        case "-":
                            sum = Calculator.Subtraction(decimal.Parse(num1),decimal.Parse(num2));
                            Console.WriteLine("The answer is: {0}", sum);
                            Console.WriteLine();
                            break;

                        case "*":
                            sum = Calculator.Multiplication(decimal.Parse(num1),decimal.Parse(num2));
                            Console.WriteLine("The answer is: {0}", sum);
                            Console.WriteLine();
                            break;
                        case "/":
                            sum = Calculator.Division(decimal.Parse(num1), decimal.Parse(num2));
                            Console.WriteLine("The answer is: {0}", sum);
                            Console.WriteLine();
                            break;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            




        }
    }
}