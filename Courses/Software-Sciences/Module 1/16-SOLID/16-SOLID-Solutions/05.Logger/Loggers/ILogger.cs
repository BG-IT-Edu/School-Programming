using LoggerExercise.Appenders;
namespace LoggerExercise.Loggers
{
    public interface ILogger
    {
        public IAppender[] Appenders { get;}

        void Error(string dateTime, string message);

        void Info(string dateTime, string message);
    }
}
