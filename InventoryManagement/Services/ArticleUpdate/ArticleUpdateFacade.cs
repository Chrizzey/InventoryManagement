using InventoryManagement.Models.Articles;
using InventoryManagement.Services.ArticleCreation;
using InventoryManagement.Services.CrudServices;
using InventoryManagement.Services.Shell;

namespace InventoryManagement.Services.ArticleUpdate;

public class ArticleUpdateFacade
{
    private readonly ShellInputProvider _shellInputProvider;

    public ArticleUpdateFacade(ShellInputProvider shellInputProvider)
    {
        _shellInputProvider = shellInputProvider;
    }

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