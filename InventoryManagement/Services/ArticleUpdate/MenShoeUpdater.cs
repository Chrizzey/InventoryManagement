using InventoryManagement.Models.Articles;
using InventoryManagement.Services.CrudServices;

namespace InventoryManagement.Services.ArticleUpdate;

/// <summary>
/// Represents a worker class that updates a <see cref="MenShoe"/>
/// </summary>
public class MenShoeUpdater : ShoeUpdater
{
    private readonly MenShoeCrudService _menShoeCrudService;

    /// <summary>
    /// Creates a new updater
    /// </summary>
    /// <param name="menShoeCrudService">The CRUD service process shoes for men</param>
    /// <param name="menuService">A service used to print the property update menu</param>
    public MenShoeUpdater(MenShoeCrudService menShoeCrudService, IMenuService menuService) 
        : base(menShoeCrudService, menuService)
    {
        _menShoeCrudService = menShoeCrudService;
    }

    /// <summary>
    /// Adds menu items specific to shoes for men
    /// </summary>
    /// <param name="menuItems">The collection of all menu items available to the user</param>
    protected override void AddDerivedOptions(List<PropertyMenuItem> menuItems)
    {
        base.AddDerivedOptions(menuItems);

        menuItems.Add(new PropertyMenuItem(menuItems.Count, "Has steel toes"));
    }

    /// <summary>
    /// Updates a shoe based on the <paramref name="menuItem"/> chosen by the user
    /// </summary>
    /// <param name="menuItem">The menu item chosen by the user describing which property to change</param>
    /// <param name="article">The article to be updated</param>
    protected override void UpdateDerivedArticle(PropertyMenuItem menuItem, Article article)
    {
        var menShoe = (MenShoe) article;
        switch (menuItem.Text)
        {
            case "Has steel toes":
                UpdateSteelToed(menShoe);
                break;
            default:
                base.UpdateDerivedArticle(menuItem, article);
                break;
        }
    }

    private void UpdateSteelToed(MenShoe shoe)
    {
        _menShoeCrudService.PrintCurrentValue("Has currently steel toes: ", shoe.HasSteelToes);
        shoe.HasSteelToes = _menShoeCrudService.ReadHasSteelToes();
    }
}