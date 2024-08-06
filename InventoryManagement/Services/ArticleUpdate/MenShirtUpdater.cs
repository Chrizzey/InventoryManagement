using InventoryManagement.Models.Articles;
using InventoryManagement.Services.CrudServices;

namespace InventoryManagement.Services.ArticleUpdate;

public class MenShirtUpdater : ShirtUpdater
{
    private readonly MenShirtCrudService _menShirtCrudService;

    public MenShirtUpdater(MenShirtCrudService menShirtCrudService)
        : base(menShirtCrudService)
    {
        _menShirtCrudService = menShirtCrudService;
    }

    protected override void AddDerivedOptions(List<PropertyMenuItem> menuItems)
    {
        base.AddDerivedOptions(menuItems);

        menuItems.Add(new PropertyMenuItem(menuItems.Count, "Size"));
    }

    protected override void UpdateDerivedArticle(PropertyMenuItem menuItem, Article article)
    {
        var menShirt = (MenShirt)article;
        switch (menuItem.Text)
        {
            case "Size":
                UpdateSize(menShirt);
                break;
            default:
                base.UpdateDerivedArticle(menuItem, article);
                break;
        }
    }

    private void UpdateSize(MenShirt menShirt)
    {
        _menShirtCrudService.PrintCurrentValue("Current size:", menShirt.ShirtSize);
        menShirt.ShirtSize = _menShirtCrudService.ReadShirtSize();
    }
}