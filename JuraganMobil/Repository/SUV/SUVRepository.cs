using JuraganMobil.Collection;
using JuraganMobil.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.Repository.SUV
{
    internal class SUVRepository : ISUVRepository
    {
        private IVehiclesCollection _data;

        public SUVRepository(IVehiclesCollection data)
        {
            _data = (IVehiclesCollection?)data.FetchAll().Where(x => x.GetType().Name == "SUV").ToList();
            
        }
        public List<Vehicle> GetSUV()
        {
            //Try Read
            return (List<Vehicle>)_data;
        }

        //public Vehicle GetSUV(string noPol)
        //{
        //    //Try ReadById
        //    //foreach (var item in (List<Vehicle>)_data)
        //    //{
        //    //    if (item.NoPolice == noPol) return (Vehicle)item;
                
        //    //    return (Vehicle)item;
        //    //}


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

        public Vehicle GetSUV(string noPol)
        {
            throw new NotImplementedException();
        }
    }
}
