using InventoryManagement.Models.Articles;
using InventoryManagement.Services.ArticleCreation;

namespace InventoryManagement.Services.ArticleUpdate;

public class WomenShoeUpdater : ShoeUpdater
{
    private readonly WomenShoeCrudService _womenShoeCrudService;

    public WomenShoeUpdater(WomenShoeCrudService womenShoeCrudService)
        : base(womenShoeCrudService)
    {
        _womenShoeCrudService = womenShoeCrudService;
    }

    protected override void AddDerivedOptions(List<PropertyMenuItem> menuItems)
    {
        base.AddDerivedOptions(menuItems);
        menuItems.Add(new PropertyMenuItem(menuItems.Count, "Heel height"));
    }

    protected override void UpdateDerivedArticle(PropertyMenuItem menuItem, Article article)
    {
        var shoe = (WomenShoe)article;
        switch (menuItem.Text)
        {
            case "Heel height":
                UpdateHeelHeight(shoe);
                break;
            default:
                base.UpdateDerivedArticle(menuItem, article);
                break;
        }
    }

    private void UpdateHeelHeight(WomenShoe shoe)
    {
        _womenShoeCrudService.PrintCurrentValue("Current heel height: ", shoe.HeelHeight);
        shoe.HeelHeight = _womenShoeCrudService.ReadHeelHeight();
    }
}