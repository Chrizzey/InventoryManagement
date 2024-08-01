using InventoryManagement.Services.CrudServices;

namespace InventoryManagement.Services.ArticleUpdate;

public abstract class ShoeUpdater : ArticleUpdater
{
    protected ShoeUpdater(ShoeCrudService shoeCrudService) 
        : base(shoeCrudService)
    {
    }
}