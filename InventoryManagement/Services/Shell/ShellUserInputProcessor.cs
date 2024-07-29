using InventoryManagement.Contracts;
using InventoryManagement.Models.Articles;
using InventoryManagement.Models.Exceptions;
using InventoryManagement.Services.ArticleCreation;

namespace InventoryManagement.Services.Shell;

public class ShellUserInputProcessor : IUserInputProcessor
{
    private readonly IArticleRepository _articleRepository;
    private readonly ArticleFactoryFacade _articleFactoryFacade;

    public ShellUserInputProcessor(IArticleRepository articleRepository)
    {
        _articleRepository = articleRepository;
        _articleFactoryFacade = new ArticleFactoryFacade(articleRepository);
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

    private Article CreateNewArticle(int choice)
    {
        switch (choice)
        {
            case 1:
                return _articleFactoryFacade.CreateSocks();
            case 2:
                return _articleFactoryFacade.CreateHat();
            case 3:
                return _articleFactoryFacade.CreateMenShirt();
            case 4:
                return _articleFactoryFacade.CreateWomenShirt();
            case 5:
                return _articleFactoryFacade.CreateMenShoe();
            case 6:
                return _articleFactoryFacade.CreateWomenShoe();

            default:
                throw new NotSupportedException();
        }
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