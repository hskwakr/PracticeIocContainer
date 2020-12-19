
using System;

namespace PracticeAutofac.GetStarted
{
    public class TodayWriter : IDateWriter
    {
        private IOutput _output;

        public TodayWriter(IOutput output)
        {
            _output = output;
        }

        public void WriteDate()
        {
            _output.Write(DateTime.Today.ToString());
        }
    }
}
