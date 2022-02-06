
namespace WebSchoolApp.Data;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        // instance of our dbContext built by the host/injector, disposable by itself as well
        var context = serviceProvider.GetRequiredService<WebSchoolAppContext>();

        Initialize(context);
    }

    public static void Initialize(WebSchoolAppContext context)
    { 
        // Look for customers
        if (context.Students.Any())
        {
            Console.WriteLine("Database exist!");
            return; // DB has already been seeded.
        }

        Console.WriteLine("Database not found! Seeding process Initiated.");

        //context.Payees.AddRange(
        //    new Payee
        //    {
        //        Name = "Optus",
        //        Address = "373 Collins St",
        //        Suburb = "Melbourne",
        //        State = "VIC",
        //        Postcode = 3000,
        //        Phone = "(03) 7022 8500"
        //    },
        //    new Payee
        //    {
        //        Name = "Telstra",
        //        Address = "242 Exhibition St",
        //        Suburb = "Melbourne",
        //        State = "VIC",
        //        Postcode = 3000,
        //        Phone = "(03) 2222 2222"
        //    },
        //    new Payee
        //    {
        //        Name = "Vodafone",
        //        Address = "204/25 Main St",
        //        Suburb = "Greensborough",
        //        State = "VIC",
        //        Postcode = 3088,
        //        Phone = "(03) 3333 3333"
        //    }
        //);


        context.SaveChanges();
    }
}
