using LoggerExercise.Appenders;

using LoggerExercise.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoggerExercise.Loggers
{
    public class Logger : ILogger
    {
        public Logger(params IAppender[] appenders)
        {
            Appenders = appenders;
        }

        public IAppender[] Appenders { get; }

        public void Error(string dateTime, string message)
        {
            foreach (var item in this.Appenders)
            {
            item.Append(dateTime, ReportLevel.Error, message);
            }
        }

        public void Info(string dateTime, string message)
        {
            foreach (var item in this.Appenders)
            {
                item.Append(dateTime, ReportLevel.Info, message);
            }
        }

        public void Warning(string dateTime, string message)
        {
            foreach (var item in this.Appenders)
            {
                item.Append(dateTime, ReportLevel.Warning, message);
            }
        }

        public void Critical(string dateTime, string message)
        {
            foreach (var item in this.Appenders)
            {
                item.Append(dateTime, ReportLevel.Critical, message);
            }
        }

        public void Fatal(string dateTime, string message)
        {
            foreach (var item in this.Appenders)
            {
                item.Append(dateTime, ReportLevel.Fatal, message);
            }
        }
    }
}
