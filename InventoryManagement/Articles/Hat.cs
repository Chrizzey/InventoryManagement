using InventoryManagement.Models;

namespace InventoryManagement.Articles;

/// <summary>
/// Represents a hat that the customer can wear
/// </summary>
public class Hat : Article
{
    /// <summary>
    /// Gets or sets the size of the hat
    /// </summary>
    public StandardSize Size { get; set; }

    /// <summary>
    /// Gets or sets the kind of hat being sold
    /// <remarks>
    /// Styles may be cylinder, baseball cap, beach wear
    /// </remarks>
    /// </summary>
    public string Style { get; set; }

    /// <summary>
    /// Creates a new inventory item that represents a hat
    /// </summary>
    /// <param name="id">The unique ID of the article</param>
    public Hat(int id) 
        : base(id)
    {
        Style = string.Empty;
    }
}