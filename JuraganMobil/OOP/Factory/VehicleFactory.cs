using JuraganMobil.Model.Child;
using JuraganMobil.OOP.Enum;
using JuraganMobil.OOP.Model;
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

        public OOPTaxi CrateTaxi(VehicleRecord vehicleRecord)
        {
            return new OOPTaxi(vehicleRecord.NoPoliceReg, vehicleRecord.VehicleType, vehicleRecord.TransactionDate, vehicleRecord.Rent);
        }

        public OOPSUV CreateSUV(VehicleStruct vehicleStruct)
        {
            return new OOPSUV(vehicleStruct.NoPoliceReg, vehicleStruct.VehicleType, vehicleStruct.TransactionDate, vehicleStruct.Rent);
        }

        public void DisplayVehicle<T>(List<T> listVehicle)
        {
            listVehicle.ForEach(x => System.Console.WriteLine(x));
        }

        public int GetTotalVehicle<T>(List<T> vehicles)
        {
            return vehicles.Count();
        }

        public int GetTotalVehicle<T>(List<T> vehicles, VehicleType vehicleType)
        {
            var res = 0;

            if (vehicleType == VehicleType.ALL) res = vehicles.Count();
            else res = vehicles.OfType<BaseVehicle>().Where(x => x.VehicleType == vehicleType).Count();

            return res;
        }
    }
}
