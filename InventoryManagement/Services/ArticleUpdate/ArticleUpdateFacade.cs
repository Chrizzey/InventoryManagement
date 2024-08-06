using InventoryManagement.Models.Articles;
using InventoryManagement.Services.ArticleCreation;
using InventoryManagement.Services.CrudServices;
using InventoryManagement.Services.Shell;

namespace InventoryManagement.Services.ArticleUpdate;

/// <summary>
/// Represents the entry point for article manipulation
/// </summary>
public class ArticleUpdateFacade
{
    private readonly ShellInputProvider _shellInputProvider;

    /// <summary>
    /// Creates a new instance of the facade
    /// </summary>
    /// <param name="shellInputProvider">A provider abstracting user inputs</param>
    public ArticleUpdateFacade(ShellInputProvider shellInputProvider)
    {
        _shellInputProvider = shellInputProvider;
    }

    /// <summary>
    /// Lets the user update a given <paramref name="article"/>
    /// </summary>
    /// <param name="article">The article to be updated</param>
    public void UpdateArticle(Article article)
    {
        var updater = GetArticleUpdater(article);
        updater.UpdateArticle(article);
    }

    private ArticleUpdater GetArticleUpdater(Article article)
    {
        switch (article)
        {
            case Hat:
                var hatCrudService = new HatCrudService(_shellInputProvider);
                return new HatUpdater(hatCrudService);
            case Socks:
                var sockCrudService = new SockCrudService(_shellInputProvider);
                return new SockUpdater(sockCrudService);
            case MenShirt:
                var menShirtCrudService = new MenShirtCrudService(_shellInputProvider);
                return new MenShirtUpdater(menShirtCrudService);
            case WomenShirt:
                var womenShirtCrudService = new WomenShirtCrudService(_shellInputProvider);
                return new WomenShirtUpdater(womenShirtCrudService);
            case MenShoe:
                var menShoeCrudService = new MenShoeCrudService(_shellInputProvider);
                return new MenShoeUpdater(menShoeCrudService);
            case WomenShoe:
                var womenShoeCrudService = new WomenShoeCrudService(_shellInputProvider);
                return new WomenShoeUpdater(womenShoeCrudService);
            default:
                throw new NotSupportedException();
        }
    }
}