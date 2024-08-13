namespace InventoryManagement.Contracts;

/// <summary>
/// A collection of distinct standard sizes
/// </summary>
public enum StandardSize
{
    /// <summary>
    /// Default value
    /// </summary>
    Unknown,

    /// <summary>
    /// Size XS
    /// </summary>
    ExtraSmall,

    /// <summary>
    /// Size S
    /// </summary>
    Small,

    /// <summary>
    /// Size M
    /// </summary>
    Medium,

    /// <summary>
    /// Size L
    /// </summary>
    Large,

    /// <summary>
    /// Size XL
    /// </summary>
    ExtraLarge,

    /// <summary>
    /// Size XXL
    /// </summary>
    ExtraExtraLarge,

    /// <summary>
    /// Everything bigger than <see cref="ExtraExtraLarge"/>
    /// </summary>
    Oversize
}