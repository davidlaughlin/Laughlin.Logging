using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laughlin.Logging.Loggers;
using log4net;
using log4net.Repository.Hierarchy;
using Microsoft.Practices.Unity;

namespace Laughlin.Logging.Console
{
    internal static class Bootstrapper
    {
        private const string Log4NetPath = "log4net.config";

        public static void Setup(IUnityContainer container)
        {
            FileInfo info = new FileInfo(Log4NetPath);
            if (info.Exists)
            {
                log4net.Config.XmlConfigurator.ConfigureAndWatch(info);
            }
            else
            {
                throw new FileNotFoundException(Log4NetPath);
            }

            ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            container.RegisterType(typeof(ILoggerWrapper), typeof(Log4NetLoggingWrapper), new InjectionConstructor(logger));
        }
    }
}
