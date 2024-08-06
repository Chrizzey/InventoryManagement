using InventoryManagement.Models.Articles;
using InventoryManagement.Services.CrudServices;

namespace InventoryManagement.Services.ArticleUpdate;

/// <summary>
/// Represents a worker class that updates a <see cref="Shirt"/>
/// </summary>
public abstract class ShirtUpdater : ArticleUpdater
{
    protected readonly ShirtCrudService ShirtCrudService;

    /// <summary>
    /// Creates a new updater
    /// </summary>
    /// <param name="shirtCrudService">The CRUD service process shirts</param>
    protected ShirtUpdater(ShirtCrudService shirtCrudService)
        : base(shirtCrudService)
    {
        ShirtCrudService = shirtCrudService;
    }

    /// <summary>
    /// Adds menu items specific to shirts
    /// </summary>
    /// <param name="menuItems">The collection of all menu items available to the user</param>
    protected override void AddDerivedOptions(List<PropertyMenuItem> menuItems)
    {
        menuItems.Add(new PropertyMenuItem(menuItems.Count, "Has long sleeves"));
        menuItems.Add(new PropertyMenuItem(menuItems.Count, "Pattern"));
    }

    /// <summary>
    /// Updates a shirt based on the <paramref name="menuItem"/> chosen by the user
    /// </summary>
    /// <param name="menuItem">The menu item chosen by the user describing which property to change</param>
    /// <param name="article">The article to be updated</param>
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