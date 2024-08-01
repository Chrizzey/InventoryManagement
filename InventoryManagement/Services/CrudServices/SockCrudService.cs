using InventoryManagement.Services.Shell;

namespace InventoryManagement.Services.CrudServices;

public class SockCrudService : ArticleCrudService
{
    public SockCrudService(ShellInputProvider inputProvider)
        : base(inputProvider)
    {
    }

    public int ReadNumberOfPairs()
    {
        return InputProvider.ReadPositiveNumber("Number of pairs: ");
    }

    public string ReadSockSize()
    {
        return InputProvider.ReadNonEmptyString("Size: ");
    }
}