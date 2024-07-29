using InventoryManagement.Contracts;

namespace InventoryManagement.Services.Shell;

public class ShellMenu
{
    private readonly IUserInputProcessor _userInputProcessor;

    public ShellMenu(IUserInputProcessor userInputProcessor)
    {
        _userInputProcessor = userInputProcessor;
    }

    public void Show()
    {
        var choice = PrintMainMenu();
        switch (choice)
        {
            case 1:
                {
                    _userInputProcessor.ListAllArticles();
                    break;
                }
            case 2:
                {
                    var article = _userInputProcessor.SelectArticle();
                    _userInputProcessor.ShowArticleDetails(article);
                    break;
                }
            case 3:
                {
                    _userInputProcessor.CreateNewArticle();
                    break;
                }
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
        } while (!int.TryParse(input, out choice));

        return choice;
    }
}