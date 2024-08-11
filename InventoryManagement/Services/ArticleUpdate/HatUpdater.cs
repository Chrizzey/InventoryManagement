using InventoryManagement.Models.Articles;
using InventoryManagement.Services.CrudServices;

namespace InventoryManagement.Services.ArticleUpdate;

/// <summary>
/// Represents a worker class that updates a <see cref="Hat"/>
/// </summary>
public class HatUpdater : ArticleUpdater
{
    private readonly HatCrudService _hatCrudService;

    /// <summary>
    /// Creates a new updater
    /// </summary>
    /// <param name="hatCrudService">The CRUD service process hats</param>
    /// <param name="menuService">A service used to print the property update menu</param>
    public HatUpdater(HatCrudService hatCrudService, IMenuService menuService) 
        : base(hatCrudService, menuService)
    {
        _hatCrudService = hatCrudService;
    }

    /// <summary>
    /// Adds menu items specific to hats
    /// </summary>
    /// <param name="menuItems">The collection of all menu items available to the user</param>
    protected override void AddDerivedOptions(List<PropertyMenuItem> menuItems)
    {
        menuItems.Add(new PropertyMenuItem(menuItems.Count, "Size"));
        menuItems.Add(new PropertyMenuItem(menuItems.Count, "Style"));
    }

    /// <summary>
    /// Updates a hat based on the <paramref name="menuItem"/> chosen by the user
    /// </summary>
    /// <param name="menuItem">The menu item chosen by the user describing which property to change</param>
    /// <param name="article">The article to be updated</param>
    protected override void UpdateDerivedArticle(PropertyMenuItem menuItem, Article article)
    {
        var hat = (Hat) article;
        switch (menuItem.Text)
        {
            case "Size":
                UpdateSize(hat);
                break;
            case "Style":
                UpdateStyle(hat);
                break;
        }
    }
    
    private void UpdateStyle(Hat hat)
    {
        _hatCrudService.PrintCurrentValue("Current size: ", hat.Size);
        hat.Size = _hatCrudService.ReadHatSize();
    }

    private void UpdateSize(Hat hat)
    {
        _hatCrudService.PrintCurrentValue("Current style: ", hat.Style);
        hat.Style = _hatCrudService.ReadStyle();
    }
}