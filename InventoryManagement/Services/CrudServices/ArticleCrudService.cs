using InventoryManagement.Services.Shell;

namespace InventoryManagement.Services.CrudServices;

/// <summary>
/// Create, Read, Update, Delete service for articles
/// </summary>
public abstract class ArticleCrudService
{
    /// <summary>
    /// The input provider to communicate to the user
    /// </summary>
    protected ShellInputProvider InputProvider;

    /// <summary>
    /// Creates a new instance
    /// </summary>
    /// <param name="inputProvider">The input provider to communicate to the user</param>
    protected ArticleCrudService(ShellInputProvider inputProvider)
    {
        InputProvider = inputProvider;
    }

    /// <summary>
    /// Reads the brand name from the user
    /// </summary>
    public string ReadBrand()
    {
        return InputProvider.ReadNonEmptyString("Brand: ");
    }

    /// <summary>
    /// Reads the article name from the user
    /// </summary>
    /// <returns></returns>
    public string ReadName()
    {
        return InputProvider.ReadNonEmptyString("Name: ");
    }

    /// <summary>
    /// Reads the article color from the user
    /// </summary>
    public string ReadColor()
    {
        return InputProvider.ReadNonEmptyString("Color: ");
    }

    /// <summary>
    /// Reads the number of items in stock from the user
    /// </summary>
    public int ReadItemsInStock()
    {
        return InputProvider.ReadPositiveNumber("Items in stock: ");
    }

    /// <summary>
    /// Reads the price of the article from the user
    /// </summary>
    public decimal ReadPrice()
    {
        return InputProvider.ReadPositiveDecimal("Price: ");
    }

    /// <summary>
    /// Reads the description from the user
    /// </summary>
    public string ReadDescription()
    {
        return InputProvider.ReadString("Description: ");
    }
    
    /// <summary>
    /// Reads the unique article number from the user
    /// </summary>
    /// <returns></returns>
    public int ReadId()
    {
        return InputProvider.ReadPositiveNumber("Id: ");
    }

    /// <summary>
    /// Outputs the current property value
    /// </summary>
    /// <param name="title">The name of the property</param>
    /// <param name="value">The value of the property</param>
    public void PrintCurrentValue(string title, object value)
    {
        InputProvider.PrintCurrentValue(title, value);
    }
}