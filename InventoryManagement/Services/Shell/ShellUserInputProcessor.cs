using InventoryManagement.Contracts;
using InventoryManagement.Models.Articles;
using InventoryManagement.Models.Exceptions;

namespace InventoryManagement.Services.Shell;

public class ShellUserInputProcessor : IUserInputProcessor
{
    private readonly IArticleRepository _articleRepository;

    public ShellUserInputProcessor(IArticleRepository articleRepository)
    {
        _articleRepository = articleRepository;
    }

    public void ListAllArticles()
    {
        foreach (var article in _articleRepository.GetAllArticles())
        {
            Console.WriteLine($"{article.Name} No.: {article.Id} Price: {article.Price} In Stock: {article.ItemsInStock}");
        }
    }

    public void ShowArticleDetails(Article article)
    {
        throw new NotImplementedException();
    }

    public void CreateNewArticle()
    {
        throw new NotImplementedException();
    }

    public void UpdateArticle(Article article)
    {
        ShowArticleDetails(article);
        throw new NotImplementedException();
    }

    public void DeleteArticle(Article article)
    {
        throw new NotImplementedException();
    }

    public Article SelectArticle()
    {
        for (var i = 0; i < 5; i++)
        {
            Console.Write("Please enter the article number: ");
            var input = Console.ReadLine();
            if (!int.TryParse(input, out var artNo))
            {
                Console.WriteLine("Invalid article number. Please enter a valid number.");
                continue;
            }

            try
            {
                return _articleRepository.GetArticle(artNo);
            }
            catch (ArticleNotFoundException ex)
            {
                Console.WriteLine($"No article with number {ex.Id} exists in the inventory. Please enter a valid number");
            }
        }

        throw new NotImplementedException();
    }
}