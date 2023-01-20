using JuraganMobil.OOP.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.OOP.Model.SubVehicle
{
    internal class OOPTaxi : BaseVehicle
    {
        public OOPTaxi(string? noPoliceReg, VehicleType vehicleTypeType, DateTime transactionDate, double rent, int order = 0, double orderPerKM = 0) : base(noPoliceReg, vehicleTypeType, transactionDate, rent)
        {
            Order = order;
            OrderPerKM = orderPerKM;
            Total = (order * orderPerKM) + rent;
        }

        public override string? ToString()
        {
            return $"| Nopolice : {NoPoliceReg} \t | Type : {VehicleType} \t | DateTime : {TransactionDate.Date.ToString("dd-M-yyyy")} | Rent : {Rent} \t | Driver : {Order} | OrderPerKm : {OrderPerKM} |";
        }

        public int Order { get; set; }
        public double OrderPerKM { get; set; }
        
        public double Total { get; set; }
    }
}
