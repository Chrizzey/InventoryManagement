using InventoryManagement.Models.Articles;
using InventoryManagement.Services.CrudServices;

namespace InventoryManagement.Services.ArticleCreation;

public class WomenShirtFactory : ShirtFactory
{
    private readonly WomenShirtCrudService _womenShirtCrudService;

    public WomenShirtFactory(WomenShirtCrudService womenShirtCrudService) 
        : base(womenShirtCrudService)
    {
        _womenShirtCrudService = womenShirtCrudService;
    }

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