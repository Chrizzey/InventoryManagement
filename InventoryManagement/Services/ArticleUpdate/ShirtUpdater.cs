using InventoryManagement.Models.Articles;
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

    protected override void UpdateDerivedArticle(PropertyMenuItem menuItem, Article article)
    {
        var shirt = (Shirt)article;
        switch (menuItem.Text)
        {
            case "Has long sleeves":
                UpdateHasLongSleeves(shirt);
                break;
            case "Pattern":
                UpdatePattern(shirt);
                break;
        }
    }

    private void UpdatePattern(Shirt shirt)
    {
        ShirtCrudService.PrintCurrentValue("Current pattern: ", shirt.Pattern);
        shirt.Pattern = ShirtCrudService.ReadPattern();
    }

    private void UpdateHasLongSleeves(Shirt shirt)
    {
        ShirtCrudService.PrintCurrentValue("Has currently long sleeves: ", shirt.HasLongSleeves);
        shirt.HasLongSleeves = ShirtCrudService.ReadLongSleeved();
    }
}