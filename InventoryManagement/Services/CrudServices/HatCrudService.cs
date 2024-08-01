using InventoryManagement.Contracts;
using InventoryManagement.Services.Shell;

namespace InventoryManagement.Services.CrudServices;

public class HatCrudService : ArticleCrudService
{
    public HatCrudService(ShellInputProvider inputProvider)
        : base(inputProvider)
    {
    }

    public StandardSize ReadHatSize()
    {
        return InputProvider.ReadStandardSize("Size (Standard): ");
    }

    public string ReadStyle()
    {
        return InputProvider.ReadNonEmptyString("Style: ");
    }
}