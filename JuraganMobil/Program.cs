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
        var dataTemp = new VehiclesCollection().FetchAll();
        var resData = dataTemp.Where(dataTemp => dataTemp.GetType().Name == "SUV").ToList();

        resData.ForEach(x => Console.WriteLine(x));

        //Try ReadById
        foreach (var item in resData)
            if (item.NoPolice == "D 1001 UM")
                Console.WriteLine(item);

        //Try Create

        //Try Update

        //Try Delete

    }
}

