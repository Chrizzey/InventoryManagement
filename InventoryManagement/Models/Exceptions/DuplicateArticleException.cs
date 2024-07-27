using InventoryManagement.Models.Articles;

namespace InventoryManagement.Models.Exceptions;

public class DuplicateArticleException : Exception
{
    public Article Article { get; }

    public DuplicateArticleException(Article article)  
        : base($"An Article with ID {article.Id} already exists")
    {
        Article = article;
    }
}