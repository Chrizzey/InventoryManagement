using InventoryManagement.Contracts;
using InventoryManagement.Models.Articles;
using InventoryManagement.Services.Shell;

namespace InventoryManagement.Services.ArticleCreation;

public class MenShirtFactory : ShirtFactory
{
    public MenShirtFactory(ShellInputProvider inputProvider) 
        : base(inputProvider)
    {
    }

    public override Article Create(int id)
    {
        var shirt = new MenShirt(id);
        Console.WriteLine("Please enter the following attributes: ");

        ReadArticleProperties(shirt);
        ReadShirtProperties(shirt);

        shirt.ShirtSize = ReadShirtSize();

        ReadInventoryProperties(shirt);

        return shirt;
    }

    private StandardSize ReadShirtSize()
    {
        return InputProvider.ReadStandardSize("Size: ");
    }
}