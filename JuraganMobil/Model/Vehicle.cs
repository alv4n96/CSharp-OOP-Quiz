using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.Model
{
    abstract class Vehicle
    {
        private string noPolice;
        private int year;
        private decimal price;
        private decimal? tax;
        private byte seat;
        private DateTime transactionDate;
        private decimal total;

        public string NoPolice { get => noPolice; set => noPolice = value; }
        protected int Year { get => year; set => year = value; }
        protected decimal Price { get => price; set => price = value; }
        protected decimal? Tax { get => tax; set => tax = value; }
        protected byte Seat { get => seat; set => seat = value; }
        protected DateTime TransactionDate { get => transactionDate; set => transactionDate = value; }
        public decimal Total { get => total; set => total = value; }

        protected Vehicle(string noPolice, int year, decimal price, byte seat, DateTime transactionDate)
        {
            NoPolice = noPolice;
            Year = year;
            Price = price;
            Tax = price * 10/100;
            Seat = seat;
            TransactionDate = transactionDate;
            Total = 0;
        }

        protected Vehicle(string noPolice, int year, decimal price, DateTime transactionDate)
        {
            NoPolice = noPolice;
            Year = year;
            Seat = 0;
            Price = price;
            Tax = price * 10/100;
            TransactionDate = transactionDate;
        }
    }
}
