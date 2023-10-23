using inheritance;
using filehandling;

namespace Sample


{

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

            // Guessing Operant
            OperationClass.nameGuessGame("Guess");
            OperationClass.nameGuessGame("Tessa");

            // object oriented
            Book book = new Book();
            book.author = "JK Rowling";
            book.title = "Harry Potter";
            book.pages = 400;

            Book book1 = new Book();
            book1.author = "George RR Martin";
            book1.title = "Game Of Thrones";
            book1.pages = 600;

            // With constructor
            Book book2 = new Book(author: "Me", title: "Salmon Life", pages: 150);
            System.Console.WriteLine(book2.title);

            System.Console.WriteLine(book.author);
            System.Console.WriteLine(book1.author);


            Student student = new Student("Jim", "business", 2.7);
            Student student1 = new Student("Pam", "art", 4.5);

            System.Console.WriteLine(student.toString());
            System.Console.WriteLine(student1.toString());


            Movie movie = new Movie("Shawshank Redemtion", "Kevin", "PG");


            Movie movie1 = new Movie("Avatar 2", "James", "R");

            System.Console.WriteLine(movie.Rating);

            // static attributes
            Song song = new Song("Holiday", "Green Day", 200);
            Song song1 = new Song("Kashmir", "Led Zeppelin", 150);

            System.Console.WriteLine($"Song count: {Song.songCount}");

            // inheritance
            Chef chef = new Chef();
            chef.MakeChicken();

            // method overriding
            Chef chef2 = new ItalianChef();
            chef2.MakeSpecialDish();


            //Abstract class
            AbstractCar abstractCar = new HondaCar();
            abstractCar.Honk();
            abstractCar.move();

            // implements handling
            Pig pig = new Pig();
            pig.animalSound();
            pig.run();


            Cat cat = new Cat();
            cat.animalSound();
            cat.run();

            // file handling and static methods usage
            var filename = "filename.txt";
            //writing into file
            FileHandler.writeToFile(filename, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam eget ex at neque tincidunt elementum eget id felis. Nam tempus semper quam id consectetur. Nulla odio risus, sodales eu cursus eu, venenatis ac justo. Nam porta enim ut venenatis vulputate. Nulla in eros sapien. Vivamus mollis fringilla elit quis pretium. Suspendisse a feugiat ante. Suspendisse a blandit erat, id iaculis erat. Mauris posuere mattis iaculis. Suspendisse at luctus urna. Fusce tristique tempor gravida. Etiam nisi quam, facilisis in urna in, euismod pulvinar felis. Donec ac convallis arcu, ac feugiat dolor. Praesent eu lacus sed nulla congue laoreet. Aenean vel venenatis.");

            //reading from file
            FileHandler.readFromFile(filename);
        }

        static String handler(string value)
        {
            return value.ToUpper();

        }

        // static method example
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