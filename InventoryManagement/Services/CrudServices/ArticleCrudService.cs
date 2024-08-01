using InventoryManagement.Services.Shell;

namespace InventoryManagement.Services.CrudServices;

public abstract class ArticleCrudService
{
    protected ShellInputProvider InputProvider;

    protected ArticleCrudService(ShellInputProvider inputProvider)
    {
        InputProvider = inputProvider;
    }

    public string ReadBrand()
    {
        return InputProvider.ReadNonEmptyString("Brand: ");
    }

    public string ReadName()
    {
        return InputProvider.ReadNonEmptyString("Name: ");
    }

    public string ReadColor()
    {
        return InputProvider.ReadNonEmptyString("Color: ");
    }

    public int ReadItemsInStock()
    {
        return InputProvider.ReadPositiveNumber("Items in stock: ");
    }

    public decimal ReadPrice()
    {
        return InputProvider.ReadPositiveDecimal("Price: ");
    }

    public string ReadDescription()
    {
        return InputProvider.ReadString("Description: ");
    }
}