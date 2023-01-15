using JuraganMobil.Model;
using JuraganMobil.Model.Child;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.Collection
{
    internal class VehiclesCollection : IVehiclesCollection
    {
        private readonly List<Vehicle> _dataVehicles;

        
        public VehiclesCollection()
        {
            _dataVehicles = new List<Vehicle>(){
                /* SUV */
                new SUV("D 1001 UM", 2010, 350_000_000, 4, new DateTime(day: 10, month: 1, year: 2023), 500_000, 150_000)
                ,new SUV("D 1003 UM", 2015, 350_000_000, 5, new DateTime(day: 12, month: 1, year: 2023), 500_000, 150_000)
                ,new SUV("D 1004 UM", 2015, 350_000_000, 5, new DateTime(day: 13, month: 1, year: 2023), 500_000, 150_000)
                ,new SUV("D 1002 UM", 2010, 350_000_000, 4, new DateTime(day: 10, month: 1, year: 2023), 500_000, 150_000)
                ,new Taxi("D 11 UK", 2002, 175_000_000, new DateTime(2023, 1, 12), 45, 4_500)
                ,new Taxi("D 12 UK", 2015, 225_000_000, new DateTime(2023, 1, 13), 75, 4_500)
                ,new Taxi("D 13 UK", 2020, 275_000_000, new DateTime(2023, 1, 13), 90, 4_500)
                ,new PrivateJet("ID8089", 2015, 150_000_000_000, 12, new DateTime(2023, 12, 23), 35_000_000, 15_000_000)
                ,new PrivateJet("ID8099", 2018, 175_000_000_000, 15, new DateTime(2023, 12, 25), 55_000_000, 25_000_000)
            };
        }

        public List<Vehicle> FetchAll()
        {
            return _dataVehicles;
        }
    
    }
}
