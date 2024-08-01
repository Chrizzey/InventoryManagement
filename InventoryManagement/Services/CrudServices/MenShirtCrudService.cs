using InventoryManagement.Contracts;
using InventoryManagement.Services.Shell;

namespace InventoryManagement.Services.CrudServices;

public class MenShirtCrudService : ShirtCrudService
{
    public MenShirtCrudService(ShellInputProvider inputProvider)
        : base(inputProvider)
    {
    }

    public StandardSize ReadShirtSize()
    {
        return InputProvider.ReadStandardSize("Size: ");
    }
}