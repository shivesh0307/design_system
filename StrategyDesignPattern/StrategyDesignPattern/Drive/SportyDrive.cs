using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern.Drive
{
    public class SportyDrive : IDrive
    {
        public void Drive() {
            Console.WriteLine("SportyDrive functionality");
        }
    }
}
