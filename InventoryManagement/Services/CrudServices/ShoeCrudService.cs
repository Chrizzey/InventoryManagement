using InventoryManagement.Services.Shell;

namespace InventoryManagement.Services.CrudServices;

/// <summary>
/// Create, Read, Update, Delete service for shoes
/// </summary>
public abstract class ShoeCrudService : ArticleCrudService
{
    /// <summary>
    /// Creates a new instance
    /// </summary>
    /// <param name="inputProvider">The input provider to communicate to the user</param>
    protected ShoeCrudService(ShellInputProvider inputProvider)
        : base(inputProvider)
    {
    }

    /// <summary>
    /// Reads the shoe size from the user
    /// </summary>
    public decimal ReadShoeSize()
    {
        return InputProvider.ReadPositiveDecimal("Size: ");
    }
}