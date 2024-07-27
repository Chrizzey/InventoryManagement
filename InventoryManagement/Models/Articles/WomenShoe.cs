namespace InventoryManagement.Models.Articles;

/// <summary>
/// Represents a shoe made for women
/// </summary>
public class WomenShoe : Shoe
{
    /// <summary>
    /// Gets or sets the height of the heel in cm
    /// </summary>
    public double HeelHeight { get; set; }

    /// <summary>
    /// Creates a new inventory item that represents a shoe for women
    /// </summary>
    /// <param name="id">The unique ID of the article</param>
    public WomenShoe(int id) 
        : base(id)
    {
        HeelHeight = 0d;
    }
}