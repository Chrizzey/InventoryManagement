using InventoryManagement.Models.Articles;
using InventoryManagement.Services.CrudServices;

namespace InventoryManagement.Services.ArticleUpdate;

/// <summary>
/// Represents a worker class that updates a <see cref="Hat"/>
/// </summary>
public class SockUpdater : ArticleUpdater
{
    private readonly SockCrudService _sockCrudService;

    /// <summary>
    /// Creates a new updater
    /// </summary>
    /// <param name="sockCrudService">The CRUD service process socks</param>
    /// <param name="menuService">A service used to print the property update menu</param>
    public SockUpdater(SockCrudService sockCrudService, IMenuService menuService)
        : base(sockCrudService, menuService)
    {
        _sockCrudService = sockCrudService;
    }

    /// <summary>
    /// Adds menu items specific to socks
    /// </summary>
    /// <param name="menuItems">The collection of all menu items available to the user</param>
    protected override void AddDerivedOptions(List<PropertyMenuItem> menuItems)
    {
        menuItems.Add(new PropertyMenuItem(menuItems.Count, "Size"));
        menuItems.Add(new PropertyMenuItem(menuItems.Count, "Number of pairs"));
    }

    /// <summary>
    /// Updates socks based on the <paramref name="menuItem"/> chosen by the user
    /// </summary>
    /// <param name="menuItem">The menu item chosen by the user describing which property to change</param>
    /// <param name="article">The article to be updated</param>
    protected override void UpdateDerivedArticle(PropertyMenuItem menuItem, Article article)
    {
        var socks = (Socks)article;
        switch (menuItem.Text)
        {
            case "Size":
                UpdateSize(socks);
                break;
            case "Number of pairs":
                UpdateNumberOfPairs(socks);
                break;
        }
    }

    private void UpdateSize(Socks socks)
    {
        _sockCrudService.PrintCurrentValue("Current size: ", socks.Size);
        socks.Size = _sockCrudService.ReadSockSize();
    }

    private void UpdateNumberOfPairs(Socks socks)
    {
        _sockCrudService.PrintCurrentValue("Current number of pairs per unit: ", socks.NumberOfPairs);
        socks.NumberOfPairs = _sockCrudService.ReadNumberOfPairs();
    }
}