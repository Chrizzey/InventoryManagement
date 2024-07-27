namespace InventoryManagement.Models.Articles;

/// <summary>
/// Represents a generalized inventory item
/// </summary>
public abstract class Article
{
    /// <summary>
    /// Gets or sets the unique ID of the article
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the non-discounted price of the item
    /// </summary>
    public decimal Price { get; set; }

    /// <summary>
    /// Gets or sets the name of the brand
    /// </summary>
    public string Brand { get; set; }

    /// <summary>
    /// Gets or sets the color or color-combination of the item
    /// </summary>
    public string Color { get; set; }

    /// <summary>
    /// Gets or sets a text describing the article in more detail
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Gets or sets the amount of package units of this article that is currently stocked
    /// </summary>
    public int ItemsInStock { get; set; }

    /// <summary>
    /// Creates a new inventory item
    /// </summary>
    /// <param name="id">The unique ID of the article</param>
    protected Article(int id)
    {
        Id = id;
        ItemsInStock = 0;
        Description = string.Empty;
        Color = string.Empty;
        Brand = string.Empty;
        Price = decimal.MaxValue;
    }
}