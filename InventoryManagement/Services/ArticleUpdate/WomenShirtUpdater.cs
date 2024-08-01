using InventoryManagement.Models.Articles;
using InventoryManagement.Services.CrudServices;

namespace InventoryManagement.Services.ArticleUpdate;

public class WomenShirtUpdater : ShirtUpdater
{
    private readonly WomenShirtCrudService _womenShirtCrudService;

    public WomenShirtUpdater(WomenShirtCrudService womenShirtCrudService) 
        : base(womenShirtCrudService)
    {
        _womenShirtCrudService = womenShirtCrudService;
    }

    public override void UpdateArticle(Article article)
    {
        throw new NotImplementedException();
    }
}