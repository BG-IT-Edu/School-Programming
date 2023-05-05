
using LoggerExercise.Enums;
using LoggerExercise.Layouts;
using LoggerExercise.Loggers;

namespace LoggerExercise.Appenders
{
    public class FileAppender : IAppender
    {
        private ILogFile logFile;

        public FileAppender(ILayout layout, ILogFile logFile)
        {
            Layout = layout;
            this.logFile = logFile;
        }


        public void Append(string dateTime, ReportLevel logLevel, string message)
        {
           // var message = $"{Layout.Format}", dateTime, logLevel, message;
            this.logFile.Write(string.Format(Layout.Format, dateTime, logLevel, message));
        }

        public ILayout Layout { get; }
    }
}
