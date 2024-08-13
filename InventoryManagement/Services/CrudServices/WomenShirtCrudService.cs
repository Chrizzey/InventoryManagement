using InventoryManagement.Services.Shell;

namespace InventoryManagement.Services.CrudServices;

/// <summary>
/// Create, Read, Update, Delete service for shirts for women
/// </summary>
public class WomenShirtCrudService : ShirtCrudService
{
    /// <summary>
    /// Creates a new instance
    /// </summary>
    /// <param name="inputProvider">The input provider to communicate to the user</param>
    public WomenShirtCrudService(ShellInputProvider inputProvider)
        : base(inputProvider)
    {
    }

    /// <summary>
    /// Reads the size from the user
    /// </summary>
    public int ReadShirtSize()
    {
        return InputProvider.ReadPositiveNumber("Size: ");
    }

    /// <summary>
    /// Reads the material from the user
    /// </summary>
    public string ReadMaterial()
    {
        return InputProvider.ReadNonEmptyString("Material: ");
    }
}