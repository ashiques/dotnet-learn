

using System.ComponentModel.Design;
using System.Reflection;

namespace program
{
    class Program
    {
        delegate void LogDel(string text);
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter Username: ");
            Log log = new Log();
            var name = Console.ReadLine();

            //Multi delegate usage
            LogDel LogTextToScreenDel, LogTextToFileDel;
            LogTextToScreenDel = new LogDel(log.LogTextToScreen);
            LogTextToFileDel = new LogDel(log.LogTextToFile);

            LogDel multiLogDel = LogTextToFileDel + LogTextToScreenDel;
            LogText(multiLogDel, name);
            Console.ReadKey();
        }

        static void LogText(LogDel logDel, string text)
        {
            logDel(text);
        }

    }

    //Delegates with class methods
    class Log
    {

        public void LogTextToScreen(string text)
        {
            System.Console.WriteLine($"{DateTime.Now}: {text}");
        }

        public void LogTextToFile(string text)
        {
            using (StreamWriter sw = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log.txt"), true))
            {
                sw.WriteLine($"{DateTime.Now}: {text}");
            }

        }

    }
}