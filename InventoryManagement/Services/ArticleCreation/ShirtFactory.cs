using InventoryManagement.Models.Articles;
using InventoryManagement.Services.CrudServices;

namespace InventoryManagement.Services.ArticleCreation;

/// <summary>
/// Represents a creation service to create <see cref="Shirt"/> items
/// </summary>
public abstract class ShirtFactory : ArticleFactory
{
    protected readonly ShirtCrudService ShirtCrudService;

    /// <summary>
    /// Creates a new instance
    /// </summary>
    protected ShirtFactory(ShirtCrudService shirtCrudService) 
        : base(shirtCrudService)
    {
        ShirtCrudService = shirtCrudService;
    }
    
    /// <summary>
    /// Initializes shirt-specific properties of a given <paramref name="shirt"/>
    /// </summary>
    protected void ReadShirtProperties(Shirt shirt)
    {
        shirt.Pattern = ShirtCrudService.ReadPattern();
        shirt.HasLongSleeves = ShirtCrudService.ReadLongSleeved();
    }
}