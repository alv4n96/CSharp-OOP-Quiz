using JuraganMobil.Collection;
using JuraganMobil.Model;
using JuraganMobil.Model.Child;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.Repository.SUV
{
    internal class SUVRepository : ISUVRepository
    {
        private IVehiclesCollection _data;
        private object _sUVData;

        public SUVRepository(IVehiclesCollection data)
        {
            _data = data;
            _sUVData = _data.FetchAll()
                .Where(x => x.GetType().Name == "SUV")
                .OrderBy(x => x.NoPolice)
                .ToList();
        }
        public List<Vehicle> GetSUV()
        {
            List<Vehicle> res = (List<Vehicle>)_sUVData;
            //Try Read
            return res;
        }

        public Vehicle GetSUV(string noPol)
        {
            Vehicle? res = _data[1];
            //Try ReadById
            foreach (var item in (List<Vehicle>)_data)
            {
                if (item.NoPolice == noPol)
                {
                    res = item;
                    return res;
                }
                else res = null;
            }

            return res;
        }

        //    //Try Create

        //    //Try Update

        //    //Try Delete
        //}

        public int CreateSUV(List<Vehicle> list)
        {
            throw new NotImplementedException();
        }

        public int DeleteSUV(string noPol)
        {
            throw new NotImplementedException();
        }


        public int UpdateSUV(string noPol, List<Vehicle> data)
        {
            throw new NotImplementedException();
        }

    }
}
