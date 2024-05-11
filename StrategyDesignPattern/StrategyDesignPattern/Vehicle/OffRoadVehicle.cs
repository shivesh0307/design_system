using StrategyDesignPattern.Drive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern.Vehicle
{
    public class OffRoadVehicle:Vehicle
    {
        public OffRoadVehicle(IDrive drive) : base(drive)
        {

        }
    }
}
