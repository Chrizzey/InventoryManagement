using InventoryManagement.Contracts;
using InventoryManagement.Models.Articles;
using InventoryManagement.Services.CrudServices;

namespace InventoryManagement.Services.ArticleUpdate;

/// <summary>
/// Represents a worker class that updates a <see cref="WomenShirt"/>
/// </summary>
public class WomenShirtUpdater : ShirtUpdater
{
    private readonly WomenShirtCrudService _womenShirtCrudService;

    /// <summary>
    /// Creates a new updater
    /// </summary>
    /// <param name="womenShirtCrudService">The CRUD service process shirts for women</param>
    /// <param name="menuService">A service used to print the property update menu</param>
    public WomenShirtUpdater(WomenShirtCrudService womenShirtCrudService, IMenuService menuService) 
        : base(womenShirtCrudService, menuService)
    {
        _womenShirtCrudService = womenShirtCrudService;
    }

    /// <summary>
    /// Adds menu items specific to shirts for women
    /// </summary>
    /// <param name="menuItems">The collection of all menu items available to the user</param>
    protected override void AddDerivedOptions(List<PropertyMenuItem> menuItems)
    {
        base.AddDerivedOptions(menuItems);

        menuItems.Add(new PropertyMenuItem(menuItems.Count, "Size"));
        menuItems.Add(new PropertyMenuItem(menuItems.Count, "Material"));
    }

    /// <summary>
    /// Updates a shirt based on the <paramref name="menuItem"/> chosen by the user
    /// </summary>
    /// <param name="menuItem">The menu item chosen by the user describing which property to change</param>
    /// <param name="article">The article to be updated</param>
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