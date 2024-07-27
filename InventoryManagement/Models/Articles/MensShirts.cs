using InventoryManagement.Contracts;

namespace InventoryManagement.Models.Articles;

/// <summary>
/// Represents a shirt made for men
/// </summary>
public class MenShirt : Shirt
{
    /// <summary>
    /// Gets or sets the standardized size of the shirt
    /// </summary>
    public StandardSize ShirtSize { get; set; }

    /// <summary>
    /// Creates a new inventory item that represents a shirt
    /// </summary>
    /// <param name="id">The unique ID of the article</param>
    public MenShirt(int id) : base(id)
    {
        ShirtSize = StandardSize.Unknown;
    }
}
