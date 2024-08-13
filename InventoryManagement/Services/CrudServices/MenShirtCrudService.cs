using InventoryManagement.Contracts;
using InventoryManagement.Services.Shell;

namespace InventoryManagement.Services.CrudServices;
/// <summary>
/// Create, Read, Update, Delete service for shirts for men
/// </summary>
public class MenShirtCrudService : ShirtCrudService
{
    /// <summary>
    /// Creates a new instance
    /// </summary>
    /// <param name="inputProvider">The input provider to communicate to the user</param>
    public MenShirtCrudService(ShellInputProvider inputProvider)
        : base(inputProvider)
    {
    }

    /// <summary>
    /// Reads the shirt size from the user
    /// </summary>
    public StandardSize ReadShirtSize()
    {
        return InputProvider.ReadStandardSize("Size: ");
    }
}