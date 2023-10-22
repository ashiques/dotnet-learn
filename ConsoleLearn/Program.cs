

using System.Security.Cryptography;

namespace Sample{
    
    class Program{
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
            int[] testArray= {1,2,3,4,5,6,7,8};
            for (int i = testArray.Length - 1; i >= 0 ; i--)
            {
                System.Console.WriteLine(testArray[i]);
            }

            System.Console.WriteLine(handler("Value"));
            Value sample =  Value.TEST;
            if (sample==Value.TEST)
            {
                System.Console.WriteLine($"inside {Value.TEST}");
            }else if (sample==Value.TEST1)
            {
                System.Console.WriteLine($"inside {Value.TEST1}");
            }else
            {
                System.Console.WriteLine($"inside {Value.TEST2}");
            }
        }

        static String handler(string value){
            return value.ToUpper();

        }
    }
}