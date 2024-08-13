using InventoryManagement.Services.Shell;

namespace InventoryManagement.Services.CrudServices;

/// <summary>
/// Create, Read, Update, Delete service for shirts
/// </summary>
public abstract class ShirtCrudService : ArticleCrudService
{
    /// <summary>
    /// Creates a new instance
    /// </summary>
    /// <param name="inputProvider">The input provider to communicate to the user</param>
    protected ShirtCrudService(ShellInputProvider inputProvider) 
        : base(inputProvider)
    {
    }

    /// <summary>
    /// Reads the pattern from the user
    /// </summary>
    public string ReadPattern()
    {
        return InputProvider.ReadNonEmptyString("Pattern: ");
    }

    /// <summary>
    /// Reads a flag from the user, whether the shirt has long sleeves
    /// </summary>
    /// <returns></returns>
    public bool ReadLongSleeved()
    {
        return InputProvider.ReadBoolean("Has long sleeves: ");
    }
}