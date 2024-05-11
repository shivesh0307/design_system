using StrategyDesignPattern.Drive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern.Vehicle
{
    public class Vehicle
    {
        IDrive _drive;
        public Vehicle(IDrive drive)
        {
            _drive = drive;
        }
        
        public void Drive()
        {
            _drive.Drive();
        }
    }
}
