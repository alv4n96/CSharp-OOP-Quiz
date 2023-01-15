using JuraganMobil.Base;
using JuraganMobil.Collection;
using JuraganMobil.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.Console
{
    internal class Vehicle
    {
        public void Run()
        {
            var collection = new VehiclesCollection();
            var repoManager = new RepositoryManager(collection);

            Vehicle resVal = new Vehicle();

            resVal.FindAll(repoManager);
            resVal.RunAll(repoManager);

        }

        private void FindAll(RepositoryManager config)
        {
            var data = new VehiclesCollection();

            var resVehicles = data.FetchAll();

            System.Console.WriteLine("=======================================================================================================================");
            System.Console.WriteLine($"NoPolice\\NoRegister  | Vehicle Type | Year \t| Seat \t| TransactionDate \t| Rent      | Driver \t| Total       |");
            System.Console.WriteLine("=======================================================================================================================");
            foreach (var item in resVehicles) System.Console.WriteLine(item);
            System.Console.WriteLine("=======================================================================================================================");
        }

        private string GetTotalIncome(RepositoryManager config)
        {
            var resGetTotalIncome = string.Format("{0:n0}", config.Master.GetTotalIncomeVehicle());

            return resGetTotalIncome;
        }

        private string GetTotalIncome(RepositoryManager config, string type)
        {
            var getTotalIncomeByType = string.Format("{0:n0}", config.Master.GetTotalIncomeVehicle(type));

            return getTotalIncomeByType;
        }

        private string GetTotalVehicle(RepositoryManager config)
        {
            var resGetTotalVehicle = config.Master.GetTotalVehicles();

            return Convert.ToString(resGetTotalVehicle);
        }

        private string GetTotalVehicle(RepositoryManager config, string type)
        {
            var resGetTotalVehicle = config.Master.GetTotalVehicles(type);

            return Convert.ToString(resGetTotalVehicle);
        }

        private void RunAll(RepositoryManager config)
        {
            Vehicle display = new Vehicle();

            System.Console.WriteLine("+=========================================================================================+");
            System.Console.WriteLine("|===================================== Info Summary ======================================|");
            System.Console.WriteLine("+============================================ + ==========================================+");
            System.Console.WriteLine("|            Interface Method                 |                  Return Value             |");
            System.Console.WriteLine("+============================================ + ==========================================+");
            System.Console.WriteLine("| GetTotalVehicle()                           |  \t\t\t\t\t{0} |", display.GetTotalVehicle(config));
            System.Console.WriteLine("| GetTotalVehicle(SUV)                        |  \t\t\t\t\t{0} |", display.GetTotalVehicle(config, "SUV"));
            System.Console.WriteLine("| GetTotalallincomeVehicle(SUV)               |  \t\t\t\t{0:n0} |", display.GetTotalIncome(config, "SUV"));
            System.Console.WriteLine("| GetTotalallincomeVehicle(TAXI)              |  \t\t\t\t  {0:n0} |", display.GetTotalIncome(config, "Taxi"));
            System.Console.WriteLine("| GetTotalallincomeVehicle(PRIVATE)           |  \t\t\t      {0:n0} |", display.GetTotalIncome(config, "PrivateJet"));
            System.Console.WriteLine("| GetTotalllIncome(SUV)                       |  \t\t\t      {0:n0} |", display.GetTotalIncome(config));
            System.Console.WriteLine("+============================================ + ==========================================+");
        }
    }
}
