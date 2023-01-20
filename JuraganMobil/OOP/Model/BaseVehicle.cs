using JuraganMobil.OOP.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.OOP.Model
{
    internal abstract class BaseVehicle
    {
        public BaseVehicle(string? noPoliceReg, VehicleType vehicleTypeType, DateTime transactionDate, double rent)
        {
            NoPoliceReg = noPoliceReg;
            VehicleType = vehicleTypeType;
            TransactionDate = transactionDate;
            Rent = rent;
        }

        public string? NoPoliceReg { get; set; }
        public VehicleType VehicleType { get; set; }
        public string Year { get; set; }
        public double Price { get; set; }
        public DateTime TransactionDate { get; set; }  
        public double Rent { get; set; }   
        public double Total { get; set; }
    }
}
