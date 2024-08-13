using InventoryManagement.Services;

namespace InventoryManagement;

/// <summary>
/// Hosts the main entry point into the application
/// </summary>
internal class Program
{
    /// <summary>
    /// The main entry point of the application
    /// </summary>
    static void Main()
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