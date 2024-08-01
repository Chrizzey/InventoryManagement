using InventoryManagement.Models.Articles;
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
                return new HatUpdater();
            case Socks:
                return new SockUpdater();
            case MenShirt:
                return new MenShirtUpdater();
            case WomenShirt:
                return new WomenShirtUpdater();
            case MenShoe:
                return new MenShoeUpdater();
            case WomenShoe:
                return new WomenShoeUpdater();
            default:
                throw new NotSupportedException();
        }
    }
}

public abstract class ArticleUpdater
{
    protected readonly ArticleCrudService ArticleCrudService;

    protected ArticleUpdater(ArticleCrudService articleCrudService)
    {
        ArticleCrudService = articleCrudService;
    }

    public abstract void UpdateArticle(Article article);
}