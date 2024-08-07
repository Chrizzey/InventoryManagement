using InventoryManagement.Contracts;
using InventoryManagement.Models.Articles;
using InventoryManagement.Services.CrudServices;
using InventoryManagement.Services.Shell;

namespace InventoryManagement.Services.ArticleCreation;

/// <summary>
/// Represents a single entry point into article creation
/// </summary>
public class ArticleFactoryFacade
{
    private readonly IArticleRepository _articleRepository;
    private readonly ShellInputProvider _inputProvider;

    /// <summary>
    /// Initializes a new facade
    /// </summary>
    /// <param name="inputProvider">An abstraction providing information from the user</param>
    /// <param name="articleRepository">An abstraction of the storage of all articles</param>
    public ArticleFactoryFacade(ShellInputProvider inputProvider, IArticleRepository articleRepository)
    {
        _inputProvider = inputProvider;
        _articleRepository = articleRepository;
    }

    /// <summary>
    /// Creates a new article based on the users inputs
    /// </summary>
    /// <param name="articleType">The article type provided by the user</param>
    /// <returns>The created and initialized article</returns>
    public Article CreateNewArticle(int articleType)
    {
        var factory = GetArticleFactory(articleType);
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