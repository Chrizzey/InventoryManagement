using InventoryManagement.Models.Articles;

namespace InventoryManagement.Contracts;

/// <summary>
/// Represents the storage of articles
/// </summary>
public interface IArticleRepository
{
    /// <summary>
    /// Adds a new article to the repository
    /// </summary>
    /// <param name="article">The article to add</param>
    void AddArticle(Article article);

    /// <summary>
    /// Updates an article in the repository
    /// </summary>
    /// <param name="article">The article to update</param>
    void UpdateArticle(Article article);

    /// <summary>
    /// Gets a single Article from the repository based on its <param name="id"></param>
    /// </summary>
    /// <param name="id">The unique number of the article, see <see cref="Article.Id"/></param>
    /// <returns>The article matching the given <param name="id"></param></returns>
    Article GetArticle(int id);

    /// <summary>
    /// Gets a collection containing all articles in the repository
    /// </summary>
    /// <returns>A collection of all articles in the repository</returns>
    IEnumerable<Article> GetAllArticles();

    /// <summary>
    /// Removes an article from the repository
    /// </summary>
    /// <param name="article">The article to be removed</param>
    void DeleteArticle(Article article);

    /// <summary>
    /// Removes an article from the repository based on its <param name="id"></param>
    /// </summary>
    /// <param name="id">The unique number of the article, see <see cref="Article.Id"/></param>
    void DeleteArticle(int id);
}