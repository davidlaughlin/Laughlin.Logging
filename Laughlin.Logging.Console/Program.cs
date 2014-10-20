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

        static void Main(string[] args)
        {
            Bootstrapper.Setup(Container);

            string text = System.Console.ReadLine();
            while (!string.IsNullOrEmpty(text))
            {
                ILoggerWrapper logger = Container.Resolve<ILoggerWrapper>();
                LogMessage message = new LogMessage(LogLevel.Info, text);
                logger.Write(message);

                text = System.Console.ReadLine();
            }
        }


    }
}
