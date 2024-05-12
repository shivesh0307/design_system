using AbstractFactory.VehicleFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    public class Factory
    {
        public IVehicleFactory GetVehicleFactory(int type)
        {
            if (type==0)
                return new OrdinaryFactory();
            return new LuxuryFactory();
        }
    }
}
