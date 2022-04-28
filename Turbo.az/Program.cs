using Turbo.az.adServices;
using Turbo.az.adMain;


adServices services = new();

Start:
Console.WriteLine("1. Ads");
Console.WriteLine("2. Car search");
Console.WriteLine("3. To add an advert");
Console.WriteLine("4. Delete ad");

var menu = Console.ReadLine();

switch (Convert.ToInt32(menu))
{
    case 1:
        foreach (var ads in services.GetAds())
        {
            Console.WriteLine(ads.Id + " " + ads.Name + " " + ads.Model + " " + ads.Year + " " + ads.Mileage + " " + ads.Price + "AZN" + " " + ads.View);
        }

        Console.WriteLine("Choose ad");
        var chooseAd = Console.ReadLine();

        var ad = services.GetOne(Convert.ToInt32(chooseAd));
        {
            Console.WriteLine(ad.Id + " " + ad.Name + " " + ad.Model + " " + ad.Year + " " + ad.Mileage + " " + " Engine:" + ad.Engine + " " + ad.Price + "AZN" + " " + "City:" + " " + ad.City + " " + ad.View);
        }


        goto Start;
        break;


    case 2:

        Console.WriteLine("Car name:");
        var carSearch = Console.ReadLine();

        foreach (var ads in services.GetName(carSearch))
        {
            Console.WriteLine(ads.Id + " " + ads.Name + " " + ads.Model + " " + ads.Year);
        }

        goto Start;
        break;


    case 3:
        Console.WriteLine("Write the Id:");
        var id = Console.ReadLine();
        Console.WriteLine("Write the Name:");
        var addName = Console.ReadLine();
        Console.WriteLine("Write the Model:");
        var model = Console.ReadLine();
        Console.WriteLine("Write the City:");
        var city = Console.ReadLine();
        Console.WriteLine("Write the Engine:");
        var engine = Console.ReadLine();
        Console.WriteLine("Write the Mileage:");
        var mil = Console.ReadLine();
        Console.WriteLine("Write the Year:");
        var addYear = Console.ReadLine();
        Console.WriteLine("Write the Price:");
        var price = Console.ReadLine();

        Ad newAd = new()
        {
            Id = Convert.ToInt32(id),
            Name = addName,
            Model = Convert.ToString(model),
            City = city,
            Engine = Convert.ToDouble(engine),
            Mileage = Convert.ToInt32(mil),
            Year = Convert.ToInt32(addYear),
            Price = Convert.ToInt32(price),
            PublishDate = DateTime.Now,
            UpdatedDate = DateTime.Now,
            View = 0,

        };

        services.AddAd(newAd);
        goto Start;
        break;

    case 4:

        Console.WriteLine("Write ID to delete:");
        var removeId = Console.ReadLine();

        services.RemoveAd(Convert.ToInt32(removeId));
        Console.WriteLine("Ad removed");

        goto Start;
        break;
}












