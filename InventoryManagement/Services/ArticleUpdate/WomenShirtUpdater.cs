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

    protected override void AddDerivedOptions(List<PropertyMenuItem> menuItems)
    {
        base.AddDerivedOptions(menuItems);

        menuItems.Add(new PropertyMenuItem(menuItems.Count, "Size"));
        menuItems.Add(new PropertyMenuItem(menuItems.Count, "Material"));
    }

    protected override void UpdateDerivedArticle(PropertyMenuItem menuItem, Article article)
    {
        var shirt = (WomenShirt) article;
        switch (menuItem.Text)
        {
            case "Size":
                UpdateSize(shirt);
                break;
            case "Material":
                UpdateMaterial(shirt);
                break;
            default:
                base.UpdateDerivedArticle(menuItem, article);
                break;
        }
    }

    private void UpdateSize(WomenShirt shirt)
    {
        _womenShirtCrudService.PrintCurrentValue("Current Size: ", shirt.Size);
        shirt.Size = _womenShirtCrudService.ReadShirtSize();
    }

    private void UpdateMaterial(WomenShirt shirt)
    {
        _womenShirtCrudService.PrintCurrentValue("Current Material: ", shirt.Material);
        shirt.Material = _womenShirtCrudService.ReadMaterial();
    }
}