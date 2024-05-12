using AbstractFactory.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.VehicleFactory
{
    public class OrdinaryFactory: IVehicleFactory
    {
        public IVehicle GetVehicle(string name)
        {
            if (name == "Hyundai")
                return new Hyundai();
            return new Suzuki();
        }
    }
}
