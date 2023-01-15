﻿using JuraganMobil.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.Model.Child
{
    internal class SUV : Vehicle
    {

        private decimal _rent;
        private decimal _driver;
        
        public SUV(string noPolice, int year, decimal price, byte seat, DateTime transactionDate, decimal rent, decimal driver) : base(noPolice, year, price, seat, transactionDate)
        {
            Rent = rent;
            Driver = driver;
            base.Total += rent + driver;
        }

        public decimal Rent { get => _rent; set => _rent = value; }
        public decimal Driver { get => _driver; set => _driver = value; }
        
        public new decimal Total { get => base.Total; set => base.Total = value; }

        public override string? ToString()
        {
            return $"{NoPolice}\t     | SUV \t    | {Year} \t| {Seat} \t| {TransactionDate.Date.ToString("d/M/yyyy")} \t\t| {Rent}    | {Driver} \t| {Total}      |";
        }
    }
}
