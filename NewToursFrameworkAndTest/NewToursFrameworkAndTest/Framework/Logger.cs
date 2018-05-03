using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewToursFrameworkAndTest.Framework
{
    public class Logger
    {
        private static ILog _xmlLogger;

        public static ILog GetXmlLogger(Type type)
        {
            if (_xmlLogger != null)
                return _xmlLogger;
            XmlConfigurator.Configure();
            _xmlLogger = LogManager.GetLogger(type);
            return _xmlLogger;
        }
    }
}
