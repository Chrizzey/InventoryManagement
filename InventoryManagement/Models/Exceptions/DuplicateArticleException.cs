using InventoryManagement.Models.Articles;

namespace InventoryManagement.Models.Exceptions;

/// <summary>
/// Represents an error when an article already exists
/// </summary>
public class DuplicateArticleException : Exception
{
    /// <summary>
    /// Gets the duplicated article
    /// </summary>
    public Article Article { get; }

    /// <summary>
    /// Creates a new instance
    /// </summary>
    /// <param name="article">The duplicated article</param>
    public DuplicateArticleException(Article article)  
        : base($"An Article with ID {article.Id} already exists")
    {
        Article = article;
    }
}