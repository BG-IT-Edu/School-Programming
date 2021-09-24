namespace LoggerExercise.Loggers
{
using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class LogFile : ILogFile
    {
        private const string LogFilePath = "../../../log.txt";
        public int Size
        => File.ReadAllText(LogFilePath).Where(char.IsLetter).Sum(c => c);

        public void Write(string message)
        {
            File.AppendAllText(LogFilePath, message);
            File.AppendAllText(LogFilePath, "\n");
           //Console.WriteLine();
        }

    }
}
