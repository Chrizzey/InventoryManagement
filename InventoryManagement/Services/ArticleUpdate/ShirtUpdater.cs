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

    protected override void AddDerivedOptions(List<PropertyMenuItem> menuItems)
    {
        menuItems.Add(new PropertyMenuItem(menuItems.Count, "Has long sleeves"));
        menuItems.Add(new PropertyMenuItem(menuItems.Count, "Pattern"));
    }
}