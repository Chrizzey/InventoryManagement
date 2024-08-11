using InventoryManagement.Models.Articles;
using InventoryManagement.Services.CrudServices;

namespace InventoryManagement.Services.ArticleUpdate;

/// <summary>
/// A base class for updating articles
/// </summary>
public abstract class ArticleUpdater
{
    protected readonly ArticleCrudService ArticleCrudService;
    private readonly IMenuService _menuService;

    /// <summary>
    /// Creates a new instance
    /// </summary>
    /// <param name="articleCrudService">A CRUD service used to manipulate articles</param>
    /// <param name="menuService">A service used to print the property update menu</param>
    protected ArticleUpdater(ArticleCrudService articleCrudService, IMenuService menuService)
    {
        ArticleCrudService = articleCrudService;
        _menuService = menuService;
    }

    /// <summary>
    /// Updates a given <paramref name="article"/>
    /// </summary>
    /// <param name="article">The article to be updated</param>
    public void UpdateArticle(Article article)
    {
        var menuItems = new List<PropertyMenuItem>();
        BuildMenu(menuItems);
        
        var choice = _menuService.PrintMenuAndReadUserChoice(menuItems);

        HandleUpdate(choice, article);
    }

    /// <summary>
    /// When overridden, updates a single property of the current <paramref name="article"/>
    /// based on the <paramref name="menuItem"/> chosen by the user
    /// </summary>
    /// <param name="menuItem">The menu item chosen by the user describing which property to change</param>
    /// <param name="article">The article to be updated</param>
    protected abstract void UpdateDerivedArticle(PropertyMenuItem menuItem, Article article);

    /// <summary>
    /// Processes the update of a property based on the users choice
    /// </summary>
    /// <param name="menuItem">The menu item chosen by the user describing which property to change</param>
    /// <param name="article">The article to be updated</param>
    protected void HandleUpdate(PropertyMenuItem menuItem, Article article)
    {
        // todo: implement chain of responsibility 
        switch (menuItem.Text)
        {
            case "Id":
                UpdateId(article);
                break;
            case "Name":
                UpdateName(article);
                break;
            case "Price":
                UpdatePrice(article);
                break;
            case "Brand":
                UpdateBrand(article);
                break;
            case "Color":
                UpdateColor(article);
                break;
            case "Description":
                UpdateDescription(article);
                break;
            case "Items in Stock":
                UpdateItemsInStock(article);
                break;
            default:
                UpdateDerivedArticle(menuItem, article);
                break;
        }
    }

    private void UpdateId(Article article)
    {
        ArticleCrudService.PrintCurrentValue("Current id: ", article.Id);
        article.Id = ArticleCrudService.ReadId();
    }

    private void UpdateName(Article article)
    {
        ArticleCrudService.PrintCurrentValue("Current name: ", article.Name);
        article.Name = ArticleCrudService.ReadName();
    }

    private void UpdatePrice(Article article)
    {
        ArticleCrudService.PrintCurrentValue("Current price: ", article.Price);
        article.Price = ArticleCrudService.ReadPrice();
    }

    private void UpdateBrand(Article article)
    {
        ArticleCrudService.PrintCurrentValue("Current brand: ", article.Brand);
        article.Brand = ArticleCrudService.ReadBrand();
    }

    private void UpdateColor(Article article)
    {
        ArticleCrudService.PrintCurrentValue("Current color: ", article.Color);
        article.Color = ArticleCrudService.ReadColor();
    }

    private void UpdateDescription(Article article)
    {
        ArticleCrudService.PrintCurrentValue("Current description: ", article.Description);
        article.Description = ArticleCrudService.ReadDescription();
    }

    private void UpdateItemsInStock(Article article)
    {
        ArticleCrudService.PrintCurrentValue("Current items in stock: ", article.ItemsInStock);
        article.ItemsInStock = ArticleCrudService.ReadItemsInStock();
    }

    /// <summary>
    /// Fills a given collection <paramref name="menuItems"/> with menu items to let
    /// the user choose which property to change
    /// </summary>
    /// <param name="menuItems">The collection of options for the user</param>
    protected void BuildMenu(List<PropertyMenuItem> menuItems)
    {
        menuItems.Add(new PropertyMenuItem(1, "Id"));
        menuItems.Add(new PropertyMenuItem(2, "Name"));
        menuItems.Add(new PropertyMenuItem(3, "Price"));
        menuItems.Add(new PropertyMenuItem(4, "Brand"));
        menuItems.Add(new PropertyMenuItem(5, "Color"));
        menuItems.Add(new PropertyMenuItem(6, "Description"));
        menuItems.Add(new PropertyMenuItem(7, "Items in stock"));

        AddDerivedOptions(menuItems);
    }

    /// <summary>
    /// When overriden, add specific menu items based on the derived article type
    /// </summary>
    /// <param name="menuItems">The collection of options for the user</param>
    protected abstract void AddDerivedOptions(List<PropertyMenuItem> menuItems);
}