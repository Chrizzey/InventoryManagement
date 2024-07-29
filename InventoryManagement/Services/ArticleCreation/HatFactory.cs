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

    public Hat CreateHat(int id)
    {
        var article = new Hat(id);
        Console.WriteLine("Please enter the following attributes: ");

        article.Name = ReadName();
        article.Brand = ReadBrand();
        article.Color = ReadColor();
        article.Size = ReadHatSize();
        article.Price = ReadPrice();
        article.Style = ReadStyle();
        article.Description = ReadDescription();
        article.ItemsInStock = ReadItemsInStock();

        return article;
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