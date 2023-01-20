using JuraganMobil.OOP.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.OOP.Model.SubVehicle
{
    internal class OOPSUV : BaseVehicle
    {

        public OOPSUV(string? noPoliceReg, VehicleType vehicleTypeType, DateTime transactionDate, double rent, double driver = 0) : base(noPoliceReg, vehicleTypeType, transactionDate, rent)
        {
            Driver = driver;
            Total = driver + rent;
        }

        public double Driver { get; set; }

        public double Total { get; set; }

        public override string? ToString()
        {
            return $"| Nopolice : {NoPoliceReg} \t | Type : {VehicleType} \t | DateTime : {TransactionDate.Date.ToString("dd-M-yyyy")} \t | Rent : {Rent} \t  | driver : {Driver} |";
        }
    }


}
