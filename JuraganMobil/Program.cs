using JuraganMobil.Base;
using JuraganMobil.Collection;
using JuraganMobil.Console;
using JuraganMobil.Model.Child;
using JuraganMobil.OOP.Enum;
using JuraganMobil.OOP.Factory;
using JuraganMobil.OOP.Model;
using JuraganMobil.OOP.Struct;
using System.Xml;

internal class Program
{
    private static void Main(string[] args)
    {
        VehiclesCollection data = new VehiclesCollection();
        Vehicle go = new Vehicle();

        //go.Run();





        IVehicleFactory _resultVehicle = new VehicleFactory();

        var sUVHolder1 = new VehicleStruct
        {
            NoPoliceReg = "D 1001 UM",
            VehicleType = JuraganMobil.OOP.Enum.VehicleType.SUV,
            TransactionDate = DateTime.Now,
            DriverFree = 150_000,
            Rent = 500_000
        };

        var suv1 = _resultVehicle.CreateSUV(sUVHolder1);

        Console.WriteLine(suv1.ToString());


        var sUVHolder2 = new VehicleRecord
        {
            NoPoliceReg = "D TAXI UM",
            VehicleType = JuraganMobil.OOP.Enum.VehicleType.Taxi,
            TransactionDate = DateTime.Now,
            DriverFree = 100_000,
            Rent = 50_000
        };

        var taxi1 = _resultVehicle.CrateTaxi(sUVHolder2);
        Console.WriteLine(taxi1);

        List<BaseVehicle> list = new() { suv1, taxi1 };

        var getResultAllVehicle = _resultVehicle.GetTotalVehicle(list, VehicleType.ALL);
        Console.WriteLine(getResultTaxi);

        var minTotalIncome = list.Min(x => x.Total);
        var maxTotalIncome = list.Max(x => x.Total);
        Console.WriteLine($"Total Vehicle : {getResultAllVehicle}");
        Console.WriteLine($"Min Total Income : {minTotalIncome}, Max Total Income : {maxTotalIncome}");

        var query = list.Where(x => x.Total > minTotalIncome && x.Total < maxTotalIncome).Select(vh =>
            new
            {
                NoPolisi = vh.NoPoliceReg,
                TahunBeli = vh.Year,
                TotalIncome = vh.Total
            }
        );

        foreach (var item in query)
        {
            Console.WriteLine(item);
        }

        //Try Read
        //var dataTemp = new VehiclesCollection().FetchAll();
        //var resData = dataTemp.Where(dataTemp => dataTemp.GetType().Name == "SUV").ToList();

        //resData.ForEach(x => Console.WriteLine(x));


        var run = new RepositoryManager(data);

        //var get = run.SUV.GetSUV();
        //read.ForEach(v => { Console.WriteLine(v); });

        //var getByNoPol = run.SUV.GetSUV("D 1001 UM");
        //Console.WriteLine(getByNoPol);

        ////Try ReadById
        //foreach (var item in resData)
        //    if (item.NoPolice == "D 1001 UM")
        //        Console.WriteLine(item);

        //Try Create

        //Try Update

        //Try Delete

    }
}

