using InventoryManagement.Models.Articles;
using InventoryManagement.Services.Shell;

namespace InventoryManagement.Services.ArticleCreation;

public class WomenShirtFactory : ArticleFactory
{
    public WomenShirtFactory(ShellInputProvider inputProvider) 
        : base(inputProvider)
    {
    }

    public override Article Create(int id)
    {
        throw new NotImplementedException();
    }
}