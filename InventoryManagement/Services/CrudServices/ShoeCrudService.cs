using InventoryManagement.Services.Shell;

namespace InventoryManagement.Services.CrudServices;

public abstract class ShoeCrudService : ArticleCrudService
{
    protected ShoeCrudService(ShellInputProvider inputProvider)
        : base(inputProvider)
    {
    }

    public decimal ReadShoeSize()
    {
        return InputProvider.ReadPositiveDecimal("Size: ");
    }
}