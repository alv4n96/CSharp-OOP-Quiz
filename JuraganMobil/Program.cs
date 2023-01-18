using JuraganMobil.Base;
using JuraganMobil.Collection;
using JuraganMobil.Console;
using JuraganMobil.Model.Child;
using System.Xml;

internal class Program
{
    private static void Main(string[] args)
    {
        VehiclesCollection data  = new VehiclesCollection();
        Vehicle go = new Vehicle();

        //go.Run();

        //Try Read
        //var dataTemp = new VehiclesCollection().FetchAll();
        //var resData = dataTemp.Where(dataTemp => dataTemp.GetType().Name == "SUV").ToList();

        //resData.ForEach(x => Console.WriteLine(x));


        var run = new RepositoryManager(data);

        //var get = run.SUV.GetSUV();
        //read.ForEach(v => { Console.WriteLine(v); });

        var getByNoPol = run.SUV.GetSUV("D 1001 UM");
        Console.WriteLine(getByNoPol);

        ////Try ReadById
        //foreach (var item in resData)
        //    if (item.NoPolice == "D 1001 UM")
        //        Console.WriteLine(item);

        //Try Create

        //Try Update

        //Try Delete

    }
}

