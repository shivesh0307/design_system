﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Vehicle
{
    public class Mercedes : IVehicle
    {
        public void drive()
        {
            Console.WriteLine("Driving Mercedes");
        }
    }
}
