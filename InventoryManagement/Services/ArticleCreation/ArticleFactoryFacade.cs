using InventoryManagement.Contracts;
using InventoryManagement.Models.Articles;
using InventoryManagement.Services.Shell;

namespace InventoryManagement.Services.ArticleCreation;

public class ArticleFactoryFacade
{
    private readonly IArticleRepository _articleRepository;

    public ArticleFactoryFacade(IArticleRepository articleRepository)
    {
        _articleRepository = articleRepository;
    }

    public Article CreateSocks()
    {
        var id = ReadArticleId();
        var factory = new SockFactory(new ShellInputProvider());
        return factory.CreateSocks(id);
    }

    public Article CreateHat()
    {
        var id = ReadArticleId();
        var factory = new HatFactory(new ShellInputProvider());
        return factory.CreateHat(id);
    }

    public Article CreateMenShirt()
    {
        throw new NotImplementedException();
    }

    public Article CreateWomenShirt()
    {
        throw new NotImplementedException();
    }

    public Article CreateMenShoe()
    {
        throw new NotImplementedException();
    }

    public Article CreateWomenShoe()
    {
        throw new NotImplementedException();
    }

    private int ReadArticleId()
    {
        string input;
        int number;
        do
        {
            Console.Write("Enter article number:");
            input = Console.ReadLine();

        } while (!int.TryParse(input, out number) || _articleRepository.DoesIdExist(number));
        return number;
    }
}