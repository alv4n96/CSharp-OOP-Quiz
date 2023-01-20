using JuraganMobil.OOP.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.OOP.Model.SubVehicle
{
    internal class OOPPrivateJet : BaseVehicle
    {
        public OOPPrivateJet(string? noPoliceReg, VehicleType vehicleTypeType, DateTime transactionDate, double rent, double orderPerHours = 0) : base(noPoliceReg, vehicleTypeType, transactionDate, rent)
        {
            OrderPerHours = orderPerHours;
            Total = rent + orderPerHours;
        }

        public double OrderPerHours { get; set; }
        public double Total { get; set; }
    }
}
