
using knowledgecheck2;
using System.Text.Json;




Console.WriteLine("How many Meatlovers to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());

var recordList = new List<MeatLovers>();
for (int i = 0; i < numberOfRecords; i++)
{
    // In this loop, populate the object's properties using Console.ReadLine()
    var meatlovers = new MeatLovers();

    Console.WriteLine("What type of Crust?");
    meatlovers.Crust = Console.ReadLine();

    Console.WriteLine("What type of Sauce?");
    meatlovers.Sauce = Console.ReadLine();

    
    Console.WriteLine("What type of Cheese?");
    meatlovers.Cheese = Console.ReadLine();

    Console.WriteLine("What type of Pepperoni?");
    meatlovers.Pepperoni = Console.ReadLine();

    Console.WriteLine("What type of Sausage?");
    meatlovers.Sausage = Console.ReadLine();

    Console.WriteLine("What type of Bacon?");
    meatlovers.Bacon = Console.ReadLine();  

    Console.WriteLine("What type of Ham?");
    meatlovers.Ham = Console.ReadLine();

    Console.WriteLine(JsonSerializer.Serialize(meatlovers));

    recordList.Add(meatlovers);
}

// Print out the list of records using Console.WriteLine()
