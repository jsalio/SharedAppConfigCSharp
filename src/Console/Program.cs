using Configuration;
using System;
using System.Configuration;

namespace SharedConfig
{
    class Program
    {
        static void Main(string[] args)
        {
            var iValue = ConfigurationManager.AppSettings["IValue"];
            SolutionEnvironment sharedEnvironment = new SolutionEnvironment();
            Console.WriteLine($"From External app.config => {sharedEnvironment.Label} : {sharedEnvironment.Value}");
            Console.WriteLine($"From Internal app.config => Internal label : {iValue}");
            Console.ReadKey();
        }
    }
}
