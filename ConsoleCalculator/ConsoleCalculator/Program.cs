namespace ConsoleCalculator
{
    internal class Program
    {

        static void Main(string[] args)
        {
            String option;
            do
            {
                
                double num1 = 0;
                double num2 = 0;
                double result = 0;

                Console.WriteLine("-------------------");
                Console.WriteLine("Calculator program");
                Console.WriteLine("--------------------");

                Console.Write("Enter first number : ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter second number: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("OPERATIONS: ");
                Console.WriteLine("\t+ : Add");
                Console.WriteLine("\t- : Subtract");
                Console.WriteLine("\t* : Multiply");
                Console.WriteLine("\t/ : Divide");

                Console.Write("Enter an option: ");


                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Your result: {num1} + {num2} = " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Your result: {num1} - {num2} = " + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Your result: {num1} * {num2} = " + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"Your result: {num1} / {num2} = " + result);
                        break;

                    default:
                        Console.WriteLine("Not a valid option.");
                        break;
                }
                Console.WriteLine("Would you like to continue again?");
                Console.WriteLine("Click Y to continue");
                option = Console.ReadLine().ToString().ToUpper();

            } while (option == "Y") ;
        }
    }
}