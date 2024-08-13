using InventoryManagement.Contracts;
using InventoryManagement.Models.Articles;
using InventoryManagement.Services.CrudServices;

namespace InventoryManagement.Services.ArticleUpdate;

/// <summary>
/// Represents a worker class that updates a <see cref="MenShirt"/>
/// </summary>
public class MenShirtUpdater : ShirtUpdater
{
    private readonly MenShirtCrudService _menShirtCrudService;

    /// <summary>
    /// Creates a new updater
    /// </summary>
    /// <param name="menShirtCrudService">The CRUD service process shirts for men</param>
    /// <param name="menuService">A service used to print the property update menu</param>
    public MenShirtUpdater(MenShirtCrudService menShirtCrudService, IMenuService menuService)
        : base(menShirtCrudService, menuService)
    {
        _menShirtCrudService = menShirtCrudService;
    }

    /// <summary>
    /// Adds menu items specific to shirts for men
    /// </summary>
    /// <param name="menuItems">The collection of all menu items available to the user</param>
    protected override void AddDerivedOptions(List<PropertyMenuItem> menuItems)
    {
        base.AddDerivedOptions(menuItems);

        menuItems.Add(new PropertyMenuItem(menuItems.Count, "Size"));
    }

    /// <summary>
    /// Updates a shirt based on the <paramref name="menuItem"/> chosen by the user
    /// </summary>
    /// <param name="menuItem">The menu item chosen by the user describing which property to change</param>
    /// <param name="article">The article to be updated</param>
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