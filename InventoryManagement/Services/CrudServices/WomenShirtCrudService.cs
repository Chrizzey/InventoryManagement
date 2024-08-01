using InventoryManagement.Services.Shell;

namespace InventoryManagement.Services.CrudServices;

public class WomenShirtCrudService : ShirtCrudService
{
    public WomenShirtCrudService(ShellInputProvider inputProvider)
        : base(inputProvider)
    {
    }

    public int ReadShirtSize()
    {
        return InputProvider.ReadPositiveNumber("Size: ");
    }
    public string ReadMaterial()
    {
        return InputProvider.ReadNonEmptyString("Material: ");
    }
}