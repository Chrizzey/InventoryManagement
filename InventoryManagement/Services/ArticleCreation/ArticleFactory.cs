using InventoryManagement.Services.Shell;

namespace InventoryManagement.Services.ArticleCreation;

public abstract class ArticleFactory
{
    protected ShellInputProvider InputProvider;

    protected ArticleFactory(ShellInputProvider inputProvider)
    {
        InputProvider = inputProvider;
    }

    protected string ReadBrand()
    {
        return InputProvider.ReadNonEmptyString("Brand: ");
    }

    protected string ReadName()
    {
        return InputProvider.ReadNonEmptyString("Name: ");
    }

    protected string ReadColor()
    {
        return InputProvider.ReadNonEmptyString("Color: ");
    }
    
    protected int ReadItemsInStock()
    {
        return InputProvider.ReadPositiveNumber("Items in stock: ");
    }
    
    protected decimal ReadPrice()
    {
        return InputProvider.ReadPositiveDecimal("Price: ");
    }

    protected string ReadDescription()
    {
        return InputProvider.ReadString("Description: ");
    }
}