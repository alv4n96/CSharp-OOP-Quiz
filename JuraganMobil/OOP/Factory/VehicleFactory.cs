using JuraganMobil.Model.Child;
using JuraganMobil.OOP.Model.SubVehicle;
using JuraganMobil.OOP.Struct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.OOP.Factory
{
    internal class VehicleFactory : IVehicleFactory
    {
        public OOPSUV CreateSUV(VehicleStruct vehicleStruct)
        {
            return new OOPSUV(vehicleStruct.NoPoliceReg, vehicleStruct.VehicleType, vehicleStruct.TransactionDate, vehicleStruct.Rent);
        }
    }
}
