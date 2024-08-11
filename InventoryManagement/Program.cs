using InventoryManagement.Services;
using InventoryManagement.Services.Shell;

namespace InventoryManagement;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Inventory Management");

        var repository = new ArticleRepository();

        var testDataFactory = new TestDataFactory(repository);
        testDataFactory.AddSocks(1);
        testDataFactory.AddMenShirts();

        var application = new Application(repository);
        application.Start();
    }
}