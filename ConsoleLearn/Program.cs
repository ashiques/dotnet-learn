namespace Sample


{
    using Operation;
    partial class Program
    {
        enum Value
        {
            TEST,
            TEST1,
            TEST2
        }
        static void Main(string[] args)
        {
            string numberString = "45";
            System.Console.WriteLine(Convert.ToInt16(numberString));
            int[] testArray = { 1, 2, 3, 4, 5, 6, 7, 8 };
            for (int i = testArray.Length - 1; i >= 0; i--)
            {
                System.Console.WriteLine(testArray[i]);
            }

            System.Console.WriteLine(handler("Value"));
            // if else if else simple logic
            Value sample = Value.TEST;
            if (sample == Value.TEST)
            {
                System.Console.WriteLine($"inside {Value.TEST}");
            }
            else if (sample == Value.TEST1)
            {
                System.Console.WriteLine($"inside {Value.TEST1}");
            }
            else
            {
                System.Console.WriteLine($"inside {Value.TEST2}");
            }

            // switch case simple syntax
            switch (sample)
            {
                case Value.TEST:
                    System.Console.WriteLine($"inside {Value.TEST}");
                    break;
                case Value.TEST1:
                    System.Console.WriteLine($"inside {Value.TEST1}");
                    break;
                default:
                    System.Console.WriteLine($"inside {Value.TEST2}");
                    break;
            };

            // using calculator
            try
            {
                System.Console.WriteLine(Calculator(4, 2, "0"));
            }
            catch (DivideByZeroException)
            {
                System.Console.WriteLine("Division by zero invalid operation!");
            }
            catch (InvalidOperationException)
            {
                System.Console.WriteLine("Invalid operation");
            };

            string[] texts = { "Mazda", "Volvo", "Ford", "BMW" };
            OperationClass.whileLoop(texts);

        }

        static String handler(string value)
        {
            return value.ToUpper();

        }


        static Double Calculator(int val1, int val2, string op)
        {
            if (val2 == 0)
            {
                throw new DivideByZeroException();
            }
            else
            {
                switch (op)
                {
                    case "+":
                        return val1 + val2;
                    case "-":
                        return val1 - val2;
                    case "*":
                        return val1 * val2;
                    case "/":
                        return Convert.ToDouble(val1 / val2);
                    default:
                        throw new InvalidOperationException();
                }
            }
        }
    }


}