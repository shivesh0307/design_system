using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern.Drive
{
    public class NormalDrive : IDrive
    {
        public void Drive()
        {
            Console.WriteLine("Normal driving functionality");
        }
    }
}
