using InventoryManagement.Models.Articles;
using InventoryManagement.Services.CrudServices;

namespace InventoryManagement.Services.ArticleUpdate;

/// <summary>
/// Represents a worker class that updates a <see cref="Shoe"/>
/// </summary>
public abstract class ShoeUpdater : ArticleUpdater
{
    protected readonly ShoeCrudService ShoeCrudService;

    /// <summary>
    /// Creates a new updater
    /// </summary>
    /// <param name="shoeCrudService">The CRUD service process shoes</param>
    /// <param name="menuService">A service used to print the property update menu</param>
    protected ShoeUpdater(ShoeCrudService shoeCrudService, IMenuService menuService) 
        : base(shoeCrudService, menuService)
    {
        ShoeCrudService = shoeCrudService;
    }

    /// <summary>
    /// Adds menu items specific to shoes
    /// </summary>
    /// <param name="menuItems">The collection of all menu items available to the user</param>
    protected override void AddDerivedOptions(List<PropertyMenuItem> menuItems)
    {
        menuItems.Add(new PropertyMenuItem(menuItems.Count, "Shoe size"));
    }

    /// <summary>
    /// Updates a shoe based on the <paramref name="menuItem"/> chosen by the user
    /// </summary>
    /// <param name="menuItem">The menu item chosen by the user describing which property to change</param>
    /// <param name="article">The article to be updated</param>
    protected override void UpdateDerivedArticle(PropertyMenuItem menuItem, Article article)
    {
        var shoe = (Shoe)article;
        switch (menuItem.Text)
        {
            case "Shoe size":
                UpdateShoeSize(shoe);
                break;
        }
    }

    private void UpdateShoeSize(Shoe shoe)
    {
        ShoeCrudService.PrintCurrentValue("Current shoe size: ", shoe.ShoeSize);
        shoe.ShoeSize = ShoeCrudService.ReadShoeSize();
    }
}