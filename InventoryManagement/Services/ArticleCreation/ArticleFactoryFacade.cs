using InventoryManagement.Contracts;
using InventoryManagement.Models.Articles;
using InventoryManagement.Services.CrudServices;
using InventoryManagement.Services.Shell;

namespace InventoryManagement.Services.ArticleCreation;

public class ArticleFactoryFacade
{
    private readonly IArticleRepository _articleRepository;
    private readonly ShellInputProvider _inputProvider;

    public ArticleFactoryFacade(ShellInputProvider inputProvider, IArticleRepository articleRepository)
    {
        _inputProvider = inputProvider;
        _articleRepository = articleRepository;
    }

    public Article CreateNewArticle(int choice)
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
                var sockCrudService = new SockCrudService(_inputProvider);
                return new SockFactory(sockCrudService);
            case 2:
                var hatCrudService = new HatCrudService(_inputProvider);
                return new HatFactory(hatCrudService);
            case 3:
                var menShirtCrudService = new MenShirtCrudService(_inputProvider);
                return new MenShirtFactory(menShirtCrudService);
            case 4:
                var womenShirtCrudService = new WomenShirtCrudService(_inputProvider);
                return new WomenShirtFactory(womenShirtCrudService);
            case 5:
                var menMenShoeCrudService = new MenShoeCrudService(_inputProvider);
                return new MenShoeFactory(menMenShoeCrudService);
            case 6:
                var womenShoeCrudService = new WomenShoeCrudService(_inputProvider);
                return new WomenShoeFactory(womenShoeCrudService);
            default:
                throw new NotSupportedException();
        }
    }

    private int ReadArticleId()
    {
        int number;
        do
        {
            number = _inputProvider.ReadPositiveNumber("Enter article number: ");
        } while (_articleRepository.DoesIdExist(number));
        return number;
    }
}