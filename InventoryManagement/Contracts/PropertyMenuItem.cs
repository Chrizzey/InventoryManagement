namespace InventoryManagement.Services.ArticleUpdate;

/// <summary>
/// Represents a menu entry for the property update
/// </summary>
public class PropertyMenuItem
{
    /// <summary>
    /// The numeric ID of the entry
    /// </summary>
    public int Number { get; }

    /// <summary>
    /// The human readable description
    /// </summary>
    public string Text { get; }

    /// <summary>
    /// Creates a new menu item
    /// </summary>
    /// <param name="number">The numerical ID</param>
    /// <param name="text">The human readable text</param>
    public PropertyMenuItem(int number, string text)
    {
        Number = number;
        Text = text;
    }
}