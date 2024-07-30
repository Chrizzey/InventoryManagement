using InventoryManagement.Contracts;
using InventoryManagement.Models.Articles;
using InventoryManagement.Models.Exceptions;
using InventoryManagement.Services.ArticleCreation;

namespace InventoryManagement.Services.Shell;

public class ShellUserInputProcessor : IUserInputProcessor
{
    private readonly IArticleRepository _articleRepository;
    private readonly ShellInputProvider _inputProvider;

    public ShellUserInputProcessor(IArticleRepository articleRepository)
    {
        _articleRepository = articleRepository;
        _inputProvider = new ShellInputProvider();
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
        new ArticlePrinter().Print(article);
    }

    public void CreateNewArticle()
    {
        int choice;
        string input;
        do
        {
            Console.WriteLine("Which article do you want to create?");
            Console.WriteLine("[1] Socks");
            Console.WriteLine("[2] Hat");
            Console.WriteLine("[3] Shirt (Men)");
            Console.WriteLine("[4] Shirt (Women)");
            Console.WriteLine("[5] Shoe (Men)");
            Console.WriteLine("[6] Shoe (Women)");

            input = Console.ReadLine();
        } while (!int.TryParse(input, out choice));

        var article = CreateNewArticle(choice);
        _articleRepository.AddArticle(article);
    }

    private int ReadArticleId()
    {
        string input;
        int number;
        do
        {
            Console.Write("Enter article number: ");
            input = Console.ReadLine();

        } while (!int.TryParse(input, out number) || _articleRepository.DoesIdExist(number));
        return number;
    }

    public void UpdateArticle(Article article)
    {
        ShowArticleDetails(article);
        throw new NotImplementedException();
    }

    public void DeleteArticle(Article article)
    {
        _articleRepository.DeleteArticle(article);
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

    #region article creation

    private Article CreateNewArticle(int choice)
    {
        var factory = GetArticleFactory(choice);
        var id = ReadArticleId();
        return factory.Create(id);
    }

    private ArticleFactory GetArticleFactory(int choice)
    {
        switch (choice)
        {
            case 1:
                return new SockFactory(_inputProvider);
            case 2:
                return new HatFactory(_inputProvider);
            case 3:
                return new MenShirtFactory(_inputProvider);
            case 4:
                return new WomenShirtFactory(_inputProvider);
            case 5:
                return new MenShoeFactory(_inputProvider);
            case 6:
                return new WomenShoeFactory(_inputProvider);
            default:
                throw new NotSupportedException();
        }
    }

    #endregion
}