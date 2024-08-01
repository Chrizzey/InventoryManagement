using InventoryManagement.Models.Articles;

namespace InventoryManagement.Services.ArticleCreation;

public class WomenShoeFactory : ShoeFactory
{
    private readonly WomenShoeCrudService _womenShoeCrudService;

    public WomenShoeFactory(WomenShoeCrudService womenShoeCrudService)
        : base(womenShoeCrudService)
    {
        _womenShoeCrudService = womenShoeCrudService;
    }

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