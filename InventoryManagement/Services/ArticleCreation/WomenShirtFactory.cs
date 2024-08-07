using InventoryManagement.Models.Articles;
using InventoryManagement.Services.CrudServices;

namespace InventoryManagement.Services.ArticleCreation;

/// <summary>
/// Represents a creation service to create <see cref="WomenShirt"/> items
/// </summary>
public class WomenShirtFactory : ShirtFactory
{
    private readonly WomenShirtCrudService _womenShirtCrudService;

    /// <summary>
    /// Creates a new instance
    /// </summary>
    public WomenShirtFactory(WomenShirtCrudService womenShirtCrudService) 
        : base(womenShirtCrudService)
    {
        _womenShirtCrudService = womenShirtCrudService;
    }

    /// <inheritdoc />
    public override Article Create(int id)
    {
        var shirt = new WomenShirt(id);
        
        ReadArticleProperties(shirt);
        ReadShirtProperties(shirt);

        shirt.Size = _womenShirtCrudService.ReadShirtSize();
        shirt.Material = _womenShirtCrudService.ReadMaterial();

        ReadInventoryProperties(shirt);

        return shirt;
    }
}