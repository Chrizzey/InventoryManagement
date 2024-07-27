namespace InventoryManagement.Models.Articles;

/// <summary>
/// Represents a generalized shirt as an inventory item
/// </summary>
public abstract class Shirt : Article
{
    /// <summary>
    /// Gets or sets a value indicating whether the shirt has long sleeves
    /// </summary>
    public bool HasLongSleeves { get; set; }

    /// <summary>
    /// Gets or sets a value specifying the pattern used for the shirt
    /// <remarks>
    /// E.g.: Striped, solid color
    /// </remarks>
    /// </summary>
    public string Pattern { get; set; }

    /// <summary>
    /// Creates a new inventory item that represents a shirt
    /// </summary>
    /// <param name="id">The unique ID of the article</param>
    protected Shirt(int id) 
        : base(id)
    {
        HasLongSleeves = true;
        Pattern = string.Empty;
    }
}