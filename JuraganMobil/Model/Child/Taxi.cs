using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.Model.Child
{
    internal class Taxi : Vehicle
    {
        private int _order;
        private decimal _orderPerKM;

        public Taxi(string noPolice, int year, decimal price, DateTime transactionDate, int order,decimal orderPerKM) : base(noPolice, year, price, transactionDate)
        {
            base.Seat = 4;
            Order = order;
            OrderPerKM = orderPerKM;
            base.Total += order * orderPerKM;
            OrderPerKM = orderPerKM;
        }

        public int Order { get => _order; set => _order = value; }
        public decimal OrderPerKM { get => _orderPerKM; set => _orderPerKM = value; }
        public new decimal Total { get => base.Total; set => base.Total = value; }

        public override string? ToString()
        {
            return $"{NoPolice}\t\t     | Taxi\t    | {Year} \t| {base.Seat} \t| {TransactionDate.Date.ToString("d/M/yyyy")} \t\t| {Order}\t    | {OrderPerKM} \t| {base.Total}      |";
        }
    }
}
