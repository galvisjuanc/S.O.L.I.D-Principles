using System.Text;

namespace DependencyInversion
{
    public class Logbook : ILogBook
    {
        public void Add(string description)
        {
            File.AppendAllText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logbook.txt"), $"{description}\n", Encoding.Unicode);
        }
    }

    public interface ILogBook
    {
        void Add(string description);
    }
}