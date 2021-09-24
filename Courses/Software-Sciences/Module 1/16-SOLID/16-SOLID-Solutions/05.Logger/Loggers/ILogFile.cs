
namespace LoggerExercise.Loggers
{
    public interface ILogFile
    {
        void Write(string message);

        int Size { get; }
    }
}
