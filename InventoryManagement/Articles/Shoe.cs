namespace InventoryManagement.Articles;

/// <summary>
/// Represents a generalized shoe as an inventory item
/// </summary>
public abstract class Shoe : Article
{
    /// <summary>
    /// Gets or sets the shoe size as a number. Allows for intermediate sizes
    /// </summary>
    public decimal ShoeSize { get; set; }

    /// <summary>
    /// Creates a new inventory item that represents a shoe
    /// </summary>
    /// <param name="id">The unique ID of the article</param>
    protected Shoe(int id) 
        : base(id)
    {
        ShoeSize = decimal.Zero;
    }
}