using InventoryManagement.Services.CrudServices;
using InventoryManagement.Services.Shell;

namespace InventoryManagement.Services.ArticleCreation;

public class WomenShoeCrudService : ShoeCrudService
{
    public WomenShoeCrudService(ShellInputProvider inputProvider)
        : base(inputProvider)
    {
    }

    public decimal ReadHeelHeight()
    {
        return InputProvider.ReadPositiveDecimal("Heel height: ");
    }
}