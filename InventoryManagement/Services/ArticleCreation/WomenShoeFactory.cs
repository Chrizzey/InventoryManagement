using InventoryManagement.Models.Articles;
using InventoryManagement.Services.CrudServices;

namespace InventoryManagement.Services.ArticleCreation;

/// <summary>
/// Represents a creation service to create <see cref="WomenShoe"/> items
/// </summary>
public class WomenShoeFactory : ShoeFactory
{
    private readonly WomenShoeCrudService _womenShoeCrudService;

    /// <summary>
    /// Creates a new instance
    /// </summary>
    public WomenShoeFactory(WomenShoeCrudService womenShoeCrudService)
        : base(womenShoeCrudService)
    {
        _womenShoeCrudService = womenShoeCrudService;
    }

    /// <inheritdoc />
    public override Article Create(int id)
    {
        var shoe = new WomenShoe(id);

        ReadArticleProperties(shoe);
        ReadShoeProperties(shoe);

        shoe.HeelHeight = _womenShoeCrudService.ReadHeelHeight();

        ReadInventoryProperties(shoe);

        return shoe;
    }

}