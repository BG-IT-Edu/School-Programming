
using LoggerExercise.Layouts;

namespace LoggerExercise.Appenders
{
    using LoggerExercise.Enums;
    using System;
    public class ConsoleAppender : IAppender
    {
        public ConsoleAppender(ILayout layout)
        {
            this.Layout = layout;
        }

        public ILayout Layout { get;}

        public ReportLevel ReportLevel { get; set; }
        public void Append(string dateTime, ReportLevel logLevel, string message)
        {
            var reportLevelValue = (int)this.ReportLevel;
            var logLevelValue = (int)logLevel;
            if (reportLevelValue <= logLevelValue)
            Console.WriteLine(Layout.Format, dateTime, logLevel, message);
        }
    }
}
