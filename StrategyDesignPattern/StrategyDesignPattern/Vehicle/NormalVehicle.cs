using StrategyDesignPattern.Drive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern.Vehicle
{
    public class NormalVehicle : Vehicle
    {
        public NormalVehicle(IDrive drive) : base(drive)
        {

        }
    }
}
