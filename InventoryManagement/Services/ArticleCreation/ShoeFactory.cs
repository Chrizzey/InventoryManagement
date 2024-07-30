using InventoryManagement.Models.Articles;
using InventoryManagement.Services.Shell;

namespace InventoryManagement.Services.ArticleCreation;

public abstract class ShoeFactory : ArticleFactory
{
    protected ShoeFactory(ShellInputProvider inputProvider) 
        : base(inputProvider)
    {
    }

    protected void ReadShoeProperties(Shoe shoe)
    {
        shoe.ShoeSize = ReadShoeSize();
    }

    protected decimal ReadShoeSize()
    {
        return InputProvider.ReadPositiveDecimal("Size: ");
    } 
}