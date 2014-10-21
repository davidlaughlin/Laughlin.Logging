using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace Laughlin.Logging.Console
{
    /// <summary>
    /// Console application allows interactive testing of logging functionality.
    /// </summary>
    class Program
    {
        private static readonly IUnityContainer Container = new UnityContainer();
        private const string PromptText = "Enter text to log (type 'exit' to end):";

        static void Main(string[] args)
        {
            Bootstrapper.Setup(Container);

            System.Console.WriteLine(PromptText);
            string text = System.Console.ReadLine();
            while (String.Compare(text, "exit", StringComparison.CurrentCultureIgnoreCase) != 0)
            {
                ILoggerWrapper logger = Container.Resolve<ILoggerWrapper>();
                LogMessage message = new LogMessage(LogLevel.Info, text);
                logger.Write(message);

                System.Console.WriteLine(PromptText);
                text = System.Console.ReadLine();
            }
        }


    }
}
