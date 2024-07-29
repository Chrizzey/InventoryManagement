using InventoryManagement.Models.Articles;

namespace InventoryManagement.Contracts;

public interface IUserInputProcessor
{
    void ListAllArticles();
    void ShowArticleDetails(Article article);
    void CreateNewArticle();
    void UpdateArticle(Article article);
    void DeleteArticle(Article article);
    Article SelectArticle();
}