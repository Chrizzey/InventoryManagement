using InventoryManagement.Services.Shell;

namespace InventoryManagement.Services.CrudServices;

/// <summary>
/// Create, Read, Update, Delete service for socks
/// </summary>
public class SockCrudService : ArticleCrudService
{
    /// <summary>
    /// Creates a new instance
    /// </summary>
    /// <param name="inputProvider">The input provider to communicate to the user</param>
    public SockCrudService(ShellInputProvider inputProvider)
        : base(inputProvider)
    {
    }

    /// <summary>
    /// Reads the number of pairs per sales unit from the user
    /// </summary>
    public int ReadNumberOfPairs()
    {
        return InputProvider.ReadPositiveNumber("Number of pairs: ");
    }

    /// <summary>
    /// Reads the size from the user
    /// </summary>
    public string ReadSockSize()
    {
        return InputProvider.ReadNonEmptyString("Size: ");
    }
}