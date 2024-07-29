using InventoryManagement.Contracts;
using InventoryManagement.Models.Articles;
using InventoryManagement.Services.Shell;

namespace InventoryManagement.Services.ArticleCreation;

public class HatFactory : ArticleFactory
{
    public HatFactory(ShellInputProvider inputProvider) 
        : base(inputProvider)
    {
    }

    public override Article Create(int id)
    {
        var hat = new Hat(id);
        Console.WriteLine("Please enter the following attributes: ");
        
        ReadArticleProperties(hat);
        
        hat.Size = ReadHatSize();
        hat.Style = ReadStyle();

        ReadInventoryProperties(hat);

        return hat;
    }

    private StandardSize ReadHatSize()
    {
        return InputProvider.ReadStandardSize("Size (Standard): ");
    }

    private string ReadStyle()
    {
        return InputProvider.ReadNonEmptyString("Style: ");
    }
}