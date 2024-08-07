using InventoryManagement.Models.Articles;
using InventoryManagement.Services.CrudServices;

namespace InventoryManagement.Services.ArticleCreation;

/// <summary>
/// Represents a creation service to create <see cref="MenShoe"/> items
/// </summary>
public class MenShoeFactory : ShoeFactory
{
    private readonly MenShoeCrudService _menShoeCrudService;

    /// <summary>
    /// Creates a new instance
    /// </summary>
    public MenShoeFactory(MenShoeCrudService menMenShoeCrudService) 
        : base(menMenShoeCrudService)
    {
        _menShoeCrudService = menMenShoeCrudService;
    }

    /// <inheritdoc />
    public override Article Create(int id)
    {
        var shoe = new MenShoe(id);

        ReadArticleProperties(shoe);
        ReadShoeProperties(shoe);

        shoe.HasSteelToes = _menShoeCrudService.ReadHasSteelToes();

        ReadInventoryProperties(shoe);

        return shoe;
    }
}