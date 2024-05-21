using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility.Loggers
{
    public abstract class Logger
    {
        Logger _nextLogger;
        public Logger(Logger nextLogger)
        {
            _nextLogger = nextLogger;
        }
        public virtual void log(string type,string msg)
        {
            if(_nextLogger!=null)
            {
                _nextLogger.log(type, msg);
            }
        }

    }
}
