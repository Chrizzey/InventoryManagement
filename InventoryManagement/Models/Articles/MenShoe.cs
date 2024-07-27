namespace InventoryManagement.Models.Articles;

/// <summary>
/// Represents a shoe made for men
/// </summary>
public class MenShoe : Shoe
{
    /// <summary>
    /// Gets or sets a value indicating whether the shoe has a reinforced toe sections for safety purposes
    /// </summary>
    public bool HasSteelToes { get; set; }

    /// <summary>
    /// Creates a new inventory item that represents a shoe for men
    /// </summary>
    /// <param name="id">The unique ID of the article</param>
    public MenShoe(int id) 
        : base(id)
    {
        HasSteelToes = false;
    }
}