using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility.Loggers
{
    public class InfoLogger : Logger
    {
        public InfoLogger(Logger _nextlogger) : base(_nextlogger)
        {

        }
        public override void log(string type,string msg)
        {
            if(type == "INFO")
            {
                Console.WriteLine($"Info Logger {msg}");
                return;
            }

            base.log(type, msg);
        }
    }
}
