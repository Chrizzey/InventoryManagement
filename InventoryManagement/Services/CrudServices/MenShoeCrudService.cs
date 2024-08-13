using InventoryManagement.Services.Shell;

namespace InventoryManagement.Services.CrudServices;

/// <summary>
/// Create, Read, Update, Delete service for shoes for men
/// </summary>
public class MenShoeCrudService : ShoeCrudService
{
    /// <summary>
    /// Creates a new instance
    /// </summary>
    /// <param name="inputProvider">The input provider to communicate to the user</param>
    public MenShoeCrudService(ShellInputProvider inputProvider)
        : base(inputProvider)
    {
    }

    /// <summary>
    /// Reads a flag from the user, whether the shoe has steel toes
    /// </summary>
    public bool ReadHasSteelToes()
    {
        return InputProvider.ReadBoolean("Has steel toes: ");
    }
}