using JuraganMobil.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.Repository
{
    internal interface ISummary
    {
        int GetTotalVehicles();
        int GetTotalVehicles(string type);
        decimal GetTotalIncomeVehicle();
        decimal GetTotalIncomeVehicle(string type);

    }
}
