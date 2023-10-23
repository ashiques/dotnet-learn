namespace filehandling
{
    class FileHandler
    {

        public static void writeToFile(string filename, string text)
        {
            File.WriteAllText(filename, text);
        }

        public static void readFromFile(string filename)
        {
            System.Console.WriteLine(File.ReadAllText(filename));
        }


    }
}