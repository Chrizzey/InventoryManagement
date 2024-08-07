using InventoryManagement.Models.Articles;
using InventoryManagement.Services.CrudServices;

namespace InventoryManagement.Services.ArticleCreation;

/// <summary>
/// Represents a generalized class responsible for creating articles
/// </summary>
public abstract class ArticleFactory
{
    /// <summary>
    /// Gets a service used for performing CRUD operations for an article
    /// </summary>
    protected readonly ArticleCrudService ArticleCrudService;

    /// <summary>
    /// Creates a new instance
    /// </summary>
    protected ArticleFactory(ArticleCrudService articleCrudService)
    {
        ArticleCrudService = articleCrudService;
    }

    /// <summary>
    /// Creates and initializes a new article
    /// </summary>
    /// <param name="id">The unique ID of the article</param>
    /// <returns>The newly created article</returns>
    public abstract Article Create(int id);
    
    /// <summary>
    /// Initializes generalized <paramref name="article"/> properties from the CRUD service
    /// </summary>
    /// <param name="article">The article to be initialized</param>
    protected void ReadArticleProperties(Article article)
    {
        article.Name = ArticleCrudService.ReadName();
        article.Brand = ArticleCrudService.ReadBrand();
        article.Color = ArticleCrudService.ReadColor();
        article.Price = ArticleCrudService.ReadPrice();
    }

    /// <summary>
    /// Initializes properties related to the inventory of given <paramref name="article"/>
    /// </summary>
    /// <param name="article">The article to be initialized</param>
    protected void ReadInventoryProperties(Article article)
    {
        article.Description = ArticleCrudService.ReadDescription();
        article.ItemsInStock = ArticleCrudService.ReadItemsInStock();
    }
}