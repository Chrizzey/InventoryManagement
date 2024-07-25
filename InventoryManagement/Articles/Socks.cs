namespace InventoryManagement.Articles;

/// <summary>
/// Represents a pack of socks
/// </summary>
public class Socks : Article
{
    /// <summary>
    /// Gets or sets the size or size range for the socks
    /// </summary>
    public string Size { get; set; }

    /// <summary>
    /// Gets or sets the number of pairs that come in one package unit
    /// </summary>
    public int NumberOfPairs { get; set; }

    /// <summary>
    /// Creates a new inventory item that represents a package of socks
    /// </summary>
    /// <param name="id">The unique ID of the article</param>
    public Socks(int id) 
        : base(id)
    {
        Size = string.Empty;
        NumberOfPairs = 1;
    }
}
