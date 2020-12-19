
namespace PracticeAutofac.GetStarted
{
    public class ConsoleOutput : IOutput
    {
        public void Write(string content)
        {
            System.Console.WriteLine(content);
        }
    }
}
