using InventoryManagement.Contracts;
using InventoryManagement.Services.Shell;

namespace InventoryManagement.Services.CrudServices;

/// <summary>
/// Create, Read, Update, Delete service for hats
/// </summary>
public class HatCrudService : ArticleCrudService
{
    /// <summary>
    /// Creates a new instance
    /// </summary>
    /// <param name="inputProvider">The input provider to communicate to the user</param>
    public HatCrudService(ShellInputProvider inputProvider)
        : base(inputProvider)
    {
    }

    /// <summary>
    /// Reads the hat size from the user
    /// </summary>
    public StandardSize ReadHatSize()
    {
        return InputProvider.ReadStandardSize("Size (Standard): ");
    }

    /// <summary>
    /// Reads the style from the user
    /// </summary>
    /// <returns></returns>
    public string ReadStyle()
    {
        return InputProvider.ReadNonEmptyString("Style: ");
    }
}