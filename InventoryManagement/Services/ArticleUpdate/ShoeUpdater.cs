using InventoryManagement.Services.CrudServices;

namespace InventoryManagement.Services.ArticleUpdate;

public abstract class ShoeUpdater : ArticleUpdater
{
    protected ShoeUpdater(ShoeCrudService shoeCrudService) 
        : base(shoeCrudService)
    {
    }

    protected override void AddDerivedOptions(List<PropertyMenuItem> menuItems)
    {
        menuItems.Add(new PropertyMenuItem(menuItems.Count, "Shoe size"));
    }
}