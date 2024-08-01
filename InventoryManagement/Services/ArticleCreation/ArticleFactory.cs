using InventoryManagement.Models.Articles;
using InventoryManagement.Services.CrudServices;

namespace InventoryManagement.Services.ArticleCreation;

public abstract class ArticleFactory
{
    protected ArticleCrudService ArticleCrudService;

    protected ArticleFactory(ArticleCrudService articleCrudService)
    {
        ArticleCrudService = articleCrudService;
    }

    public abstract Article Create(int id);
    
    protected void ReadArticleProperties(Article article)
    {
        article.Name = ArticleCrudService.ReadName();
        article.Brand = ArticleCrudService.ReadBrand();
        article.Color = ArticleCrudService.ReadColor();
        article.Price = ArticleCrudService.ReadPrice();
    }

    protected void ReadInventoryProperties(Article article)
    {
        article.Description = ArticleCrudService.ReadDescription();
        article.ItemsInStock = ArticleCrudService.ReadItemsInStock();
    }
}