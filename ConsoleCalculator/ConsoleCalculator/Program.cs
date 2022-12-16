namespace ConsoleCalculator
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var option = "n";
            do
            {             
                double num1 = 0;
                double num2 = 0;
                double result = 0;

                Console.WriteLine("-------------------");
                Console.WriteLine("Calculator program");
                Console.WriteLine("--------------------");

                num1 = readOne(num1);
                num2 = readTwo(num2);


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
                Console.WriteLine("\nDo you want to run once more? (y/n)");
                option = Console.ReadLine();


            } while (option.ToUpper() == "Y") ;

            Console.WriteLine("Ba-Bye");
        }
        
        static double readOne(double n1)
        {
            try
            {
                Console.Write("Enter first number : ");
                n1 = Convert.ToDouble(Console.ReadLine());
                return n1;
            }
            catch (Exception)
            {
                Console.WriteLine("Enter numbers only.");
                return readOne(n1);
            }
        }
        static double readTwo(double n2)
        {
            try
            {
                Console.Write("Enter second number : ");
                n2 = Convert.ToDouble(Console.ReadLine());
                return n2;
            }
            catch (Exception)
            {
                Console.WriteLine("Enter numbers only.");
                return readOne(n2);
            }
        }
    }
}