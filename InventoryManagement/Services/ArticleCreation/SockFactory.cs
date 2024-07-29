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
        var socks = new Socks(id);
        Console.WriteLine("Please enter the following attributes: ");

        ReadArticleProperties(socks);
        
        socks.Size = ReadSockSize();
        socks.NumberOfPairs = ReadNumberOfPairs();

        ReadInventoryProperties(socks);

        return socks;
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