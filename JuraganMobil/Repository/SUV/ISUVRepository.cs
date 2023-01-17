using JuraganMobil.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.Repository.SUV
{
    internal interface ISUVRepository
    {
        List<Vehicle> GetSUV();
        Vehicle GetSUV(String noPol);
        int CreateSUV(List<Vehicle> list);
        int UpdateSUV(string noPol, List<Vehicle> data);
        int DeleteSUV(string noPol);


    }
}
