using InventoryManagement.Models.Articles;

namespace InventoryManagement.Contracts;

public interface IUserInputProcessor
{
    /// <summary>
    /// Lists all articles to the output media
    /// </summary>
    void ListAllArticles();

    /// <summary>
    /// Displays a given <paramref name="article"/> in the output media
    /// </summary>
    /// <param name="article">The article to show</param>
    void ShowArticleDetails(Article article);

    /// <summary>
    /// Creates a new article using data provided by the input media
    /// </summary>
    void CreateNewArticle();

    /// <summary>
    /// Updates a given <paramref name="article"/> from the input media
    /// </summary>
    /// <param name="article">The article to be updated</param>
    void UpdateArticle(Article article);

    /// <summary>
    /// Deletes a given article
    /// </summary>
    /// <param name="article">The article to be deleted</param>
    void DeleteArticle(Article article);

    /// <summary>
    /// Selects a single article from the list of available items
    /// </summary>
    /// <returns>The article selected by the user</returns>
    Article SelectArticle();
}