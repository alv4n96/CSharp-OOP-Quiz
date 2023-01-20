using JuraganMobil.Console;
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
    internal interface IVehicleFactory
    {
        public OOPSUV CreateSUV(VehicleStruct vehicleStruct);
        public OOPTaxi CrateTaxi(VehicleRecord vehicleRecord);

        public void DisplayVehicle <T>(List<T> listVehicle);

        public int GetTotalVehicle<T>(List<T> vehicles);
        public int GetTotalVehicle<T>(List<T> vehicles, VehicleType vehicleType);
    }
}
