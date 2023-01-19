using JuraganMobil.OOP.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.OOP.Model.SubVehicle
{
    internal class SUV : BaseVehicle
    {
        public SUV(string? noPoliceReg, VehicleType vehicleTypeType, DateTime transactionDate, double rent, double driver = 0) : base(noPoliceReg, vehicleTypeType, transactionDate, rent)
        {
            Driver = driver;
        }

        public double Driver { get; set; }
    }
}
