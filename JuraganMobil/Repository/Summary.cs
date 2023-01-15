using JuraganMobil.Base;
using JuraganMobil.Collection;
using JuraganMobil.Model;
using JuraganMobil.Model.Child;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.Repository
{
    internal class Summary : ISummary
    {
        private IVehiclesCollection? _data;

        public Summary(IVehiclesCollection collection)
        {
            _data = collection;
        }
        
        public decimal GetTotalIncomeVehicle()
        {
            decimal res = 0M;

            _data.FetchAll().ForEach(item => res += item.Total);

            return res;
        }

        int ISummary.GetTotalVehicles()
        {
            return _data.FetchAll().Count();
        }

        public int GetTotalVehicles(string type)
        {
            var res = 0;

            foreach (var data in _data.FetchAll())
                if (data.GetType().Name == type) res++;

            return res;
        }

        public decimal GetTotalIncomeVehicle(string type)
        {
            var res = 0M;

            foreach (var data in _data.FetchAll())
                if (data.GetType().Name == type)
                    res = res + data.Total;

            return res;
        }
    }
}
