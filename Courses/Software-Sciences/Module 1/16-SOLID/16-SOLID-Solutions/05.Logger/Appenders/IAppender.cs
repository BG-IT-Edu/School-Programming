
using LoggerExercise.Enums;
using LoggerExercise.Layouts;

namespace LoggerExercise.Appenders
{
    public interface IAppender
    {
        public ILayout Layout { get;}

        void Append(string dateTime, ReportLevel logLevel, string message);
    }
}
