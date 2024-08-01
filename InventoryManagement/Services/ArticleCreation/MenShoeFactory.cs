using InventoryManagement.Models.Articles;
using InventoryManagement.Services.CrudServices;

namespace InventoryManagement.Services.ArticleCreation;

public class MenShoeFactory : ShoeFactory
{
    private readonly MenShoeCrudService _menShoeCrudService;

    public MenShoeFactory(MenShoeCrudService menMenShoeCrudService) 
        : base(menMenShoeCrudService)
    {
        _menShoeCrudService = menMenShoeCrudService;
    }

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