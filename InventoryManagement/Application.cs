using InventoryManagement.Contracts;
using InventoryManagement.Services.Shell;

namespace InventoryManagement;

/// <summary>
/// The main application
/// </summary>
public class Application
{
    private readonly IArticleRepository _articleRepository;

    /// <summary>
    /// Creates a new instance during bootstrapping
    /// </summary>
    /// <param name="articleRepository">A repository instance to store articles</param>
    public Application(IArticleRepository articleRepository)
    {
        _articleRepository = articleRepository;
    }

    /// <summary>
    /// Start the application and hosts the endless loop
    /// </summary>
    public void Start()
    {
        var userInputProcessor = new ShellUserInputProcessor(_articleRepository);
        var shellMenu = new ShellMenu(userInputProcessor);

        while (true)
        {
            shellMenu.Show();
        }
    }
}