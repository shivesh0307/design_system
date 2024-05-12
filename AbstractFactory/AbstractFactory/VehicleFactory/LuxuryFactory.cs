using AbstractFactory.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.VehicleFactory
{
    public class LuxuryFactory : IVehicleFactory
    {
        public IVehicle GetVehicle(string name)
        {
            if (name == "BMW")
                return new BMW();
            return new Mercedes();
        }
    }
}
