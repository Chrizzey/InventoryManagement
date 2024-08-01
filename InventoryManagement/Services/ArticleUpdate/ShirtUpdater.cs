using InventoryManagement.Services.CrudServices;

namespace InventoryManagement.Services.ArticleUpdate;

public abstract class ShirtUpdater : ArticleUpdater
{
    protected readonly ShirtCrudService ShirtCrudService;

    protected ShirtUpdater(ShirtCrudService shirtCrudService) 
        : base(shirtCrudService)
    {
        ShirtCrudService = shirtCrudService;
    }
}