using InventoryManagement.Services.Shell;

namespace InventoryManagement.Services.CrudServices;

public class MenShoeCrudService : ShoeCrudService
{
    public MenShoeCrudService(ShellInputProvider inputProvider)
        : base(inputProvider)
    {
    }

    public bool ReadHasSteelToes()
    {
        return InputProvider.ReadBoolean("Has steel toes: ");
    }
}