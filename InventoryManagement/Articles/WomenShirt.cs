namespace InventoryManagement.Articles;

/// <summary>
/// Represents a shirt made for women
/// </summary>
public class WomenShirt : Shirt
{
    /// <summary>
    /// Gets or sets the standardized number-based size of the shirt
    /// </summary>
    public int Size { get; set; }

    /// <summary>
    /// Gets or sets the material composition of the shirt
    /// <remarks>
    /// E.g.: 80% wool, 20% polyester
    /// </remarks>
    /// </summary>
    public string Material { get; set; }

    /// <summary>
    /// Creates a new inventory item that represents a shirt for women
    /// </summary>
    /// <param name="id">The unique ID of the article</param>
    public WomenShirt(int id) 
        : base(id)
    {
        Size = 0;
        Material = string.Empty;
    }
}