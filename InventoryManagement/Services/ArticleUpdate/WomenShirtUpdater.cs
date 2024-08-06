using InventoryManagement.Models.Articles;
using InventoryManagement.Services.CrudServices;

namespace InventoryManagement.Services.ArticleUpdate;

public class WomenShirtUpdater : ShirtUpdater
{
    private readonly WomenShirtCrudService _womenShirtCrudService;

    public WomenShirtUpdater(WomenShirtCrudService womenShirtCrudService) 
        : base(womenShirtCrudService)
    {
        _womenShirtCrudService = womenShirtCrudService;
    }

    public override void UpdateDerivedArticle(Article article)
    {
        throw new NotImplementedException();
    }

    protected override void AddDerivedOptions(List<PropertyMenuItem> menuItems)
    {
        base.AddDerivedOptions(menuItems);

        menuItems.Add(new PropertyMenuItem(menuItems.Count, "Size"));
        menuItems.Add(new PropertyMenuItem(menuItems.Count, "Material"));
    }
}