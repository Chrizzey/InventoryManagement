using InventoryManagement.Models.Articles;
using InventoryManagement.Services.ArticleCreation;

namespace InventoryManagement.Services.ArticleUpdate;

/// <summary>
/// Represents a worker class that updates a <see cref="WomenShoe"/>
/// </summary>
public class WomenShoeUpdater : ShoeUpdater
{
    private readonly WomenShoeCrudService _womenShoeCrudService;

    /// <summary>
    /// Creates a new updater
    /// </summary>
    /// <param name="womenShoeCrudService">The CRUD service process shoes for women</param>
    public WomenShoeUpdater(WomenShoeCrudService womenShoeCrudService)
        : base(womenShoeCrudService)
    {
        _womenShoeCrudService = womenShoeCrudService;
    }

    /// <summary>
    /// Adds menu items specific to shoes for women
    /// </summary>
    /// <param name="menuItems">The collection of all menu items available to the user</param>
    protected override void AddDerivedOptions(List<PropertyMenuItem> menuItems)
    {
        base.AddDerivedOptions(menuItems);
        menuItems.Add(new PropertyMenuItem(menuItems.Count, "Heel height"));
    }

    /// <summary>
    /// Updates a shoe based on the <paramref name="menuItem"/> chosen by the user
    /// </summary>
    /// <param name="menuItem">The menu item chosen by the user describing which property to change</param>
    /// <param name="article">The article to be updated</param>
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