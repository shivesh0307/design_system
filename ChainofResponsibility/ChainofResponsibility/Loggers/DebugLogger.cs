using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility.Loggers
{
    public class DebugLogger : Logger
    {
        public DebugLogger(Logger _nextlogger) : base(_nextlogger)
        {

        }
        public override void log(string type, string msg)
        {
            if (type == "DEBUG")
            {
                Console.WriteLine($"Debug Logger {msg}");
                return;
            }

            base.log(type,msg);
        }
    }
}
