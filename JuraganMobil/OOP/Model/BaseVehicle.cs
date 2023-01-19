using JuraganMobil.OOP.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.OOP.Model
{
    internal class BaseVehicle
    {
        public string? NoPoliceReg { get; set; }
        public VehicleType VehicleTypeType { get; set; }
        public string Year { get; set; }
        public double price { get; set; }
    }
}
