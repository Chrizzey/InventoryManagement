using InventoryManagement.Models.Articles;
using InventoryManagement.Services.Shell;

namespace InventoryManagement.Services.ArticleCreation;

public class SockFactory : ArticleFactory
{
    public SockFactory(ShellInputProvider inputProvider)
        : base(inputProvider)
    {
    }

    public override Article Create(int id)
    {
        var article = new Socks(id);
        Console.WriteLine("Please enter the following attributes: ");

        article.Name = ReadName();
        article.Brand = ReadBrand();
        article.Color = ReadColor();
        article.Size = ReadSockSize();
        article.Price = ReadPrice();
        article.NumberOfPairs = ReadNumberOfPairs();
        article.Description = ReadDescription();
        article.ItemsInStock = ReadItemsInStock();

        return article;
    }

    private int ReadNumberOfPairs()
    {
        return InputProvider.ReadPositiveNumber("Number of pairs: ");
    }

    private string ReadSockSize()
    {
        return InputProvider.ReadNonEmptyString("Size: ");
    }
}