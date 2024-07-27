using InventoryManagement.Contracts;
using InventoryManagement.Models.Articles;
using InventoryManagement.Models.Exceptions;

namespace InventoryManagement.Services.Shell;

public interface IUserInputProcessor
{
    void ListAllArticles();
    void ShowArticleDetails(Article article);
    void CreateNewArticle();
    void UpdateArticle(Article article);
    void DeleteArticle(Article article);
    Article SelectArticle();
}

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

public class ShellMenu
{
    private readonly IUserInputProcessor _userInputProcessor;

    public ShellMenu(IUserInputProcessor userInputProcessor)
    {
        _userInputProcessor = userInputProcessor;
    }

    public void Foo()
    {
        var choice = PrintMainMenu();
        switch (choice)
        {
            case 1:
                _userInputProcessor.ListAllArticles();
                break;
            case 2:
                {
                    var article = _userInputProcessor.SelectArticle();
                    _userInputProcessor.ShowArticleDetails(article);
                    break;
                }
            case 3:
                _userInputProcessor.CreateNewArticle();
                break;
            case 4:
                {
                    var article = _userInputProcessor.SelectArticle();
                    _userInputProcessor.UpdateArticle(article);
                    break;
                }
            case 5:
                {
                    var article = _userInputProcessor.SelectArticle();
                    _userInputProcessor.DeleteArticle(article);
                    break;
                }
        }
    }

    private int PrintMainMenu()
    {
        string input;
        int choice;

        do
        {
            Console.WriteLine("Main Menu");
            Console.WriteLine("Please choose one of the following options");
            Console.WriteLine("[ 1] List all articles");
            Console.WriteLine("[ 2] Show article details");
            Console.WriteLine("[ 3] Create new article");
            Console.WriteLine("[ 4] Change article");
            Console.WriteLine("[ 5] Delete article");

            input = Console.ReadLine();
        } while (int.TryParse(input, out choice));

        return choice;
    }
}