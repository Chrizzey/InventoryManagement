using InventoryManagement.Models.Articles;
using InventoryManagement.Services.CrudServices;

namespace InventoryManagement.Services.ArticleCreation;

/// <summary>
/// Represents a creation service to create <see cref="Hat"/> items
/// </summary>
public class HatFactory : ArticleFactory
{
    private readonly HatCrudService _hatCrudService;

    /// <summary>
    /// Creates a new instance
    /// </summary>
    public HatFactory(HatCrudService hatCrudService) 
        : base(hatCrudService)
    {
        _hatCrudService = hatCrudService;
    }

    /// <inheritdoc />
    public override Article Create(int id)
    {
        var hat = new Hat(id);
        ReadArticleProperties(hat);
        
        hat.Size = _hatCrudService.ReadHatSize();
        hat.Style = _hatCrudService.ReadStyle();

        ReadInventoryProperties(hat);

        return hat;
    }
}