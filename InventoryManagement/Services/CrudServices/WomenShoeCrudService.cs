using InventoryManagement.Services.Shell;

namespace InventoryManagement.Services.CrudServices;

/// <summary>
/// Create, Read, Update, Delete service for articles
/// </summary>
public class WomenShoeCrudService : ShoeCrudService
{
    /// <summary>
    /// Creates a new instance
    /// </summary>
    /// <param name="inputProvider">The input provider to communicate to the user</param>
    public WomenShoeCrudService(ShellInputProvider inputProvider)
        : base(inputProvider)
    {
    }

    /// <summary>
    /// Reads the heel height from the user
    /// </summary>
    public decimal ReadHeelHeight()
    {
        return InputProvider.ReadPositiveDecimal("Heel height: ");
    }
}