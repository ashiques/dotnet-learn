namespace Sample
{
    class OperationClass
    {
        public static void whileLoop(string[] texts)
        {
            int i = 0;
            while (i != texts.Length)
            {
                System.Console.WriteLine(texts[i]);
                i++;
            }

        }

        public static void nameGuessGame(string name)
        {

            while (name == "Tessa")
            {
                System.Console.WriteLine("You Win Guessing!!");
                break;
            }
        }


    }

}

