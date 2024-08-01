using InventoryManagement.Services.Shell;

namespace InventoryManagement.Services.CrudServices;

public abstract class ShirtCrudService : ArticleCrudService
{
    protected ShirtCrudService(ShellInputProvider inputProvider) 
        : base(inputProvider)
    {
    }
    public string ReadPattern()
    {
        return InputProvider.ReadNonEmptyString("Pattern: ");
    }

    public bool ReadLongSleeved()
    {
        return InputProvider.ReadBoolean("Has long sleeves: ");
    }
}