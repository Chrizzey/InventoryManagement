using InventoryManagement.Models.Articles;
using InventoryManagement.Services.CrudServices;

namespace InventoryManagement.Services.ArticleCreation;

/// <summary>
/// Represents a creation service to create <see cref="Shoe"/> items
/// </summary>
public abstract class ShoeFactory : ArticleFactory
{
    protected readonly ShoeCrudService ShoeCrudService;

    /// <summary>
    /// Creates a new instance
    /// </summary>
    protected ShoeFactory(ShoeCrudService shoeCrudService) 
        : base(shoeCrudService)
    {
        ShoeCrudService = shoeCrudService;
    }

    /// <summary>
    /// Initializes shoe-specific properties of a given <paramref name="shoe"/>
    /// </summary>
    protected void ReadShoeProperties(Shoe shoe)
    {
        shoe.ShoeSize = ShoeCrudService.ReadShoeSize();
    }

}