using System.Configuration;

namespace Configuration
{
    public class SolutionEnvironment
    {
        public  string Value { get; }
        public  string Label { get; }

        public SolutionEnvironment()
        {
            Value = ConfigurationManager.AppSettings["Value"];
            Label = ConfigurationManager.AppSettings["Label"];
        }
    }
}
