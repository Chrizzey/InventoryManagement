using InventoryManagement.Models.Articles;
using InventoryManagement.Services.ArticleCreation;

namespace InventoryManagement.Services.ArticleUpdate;

public class WomenShoeUpdater : ShoeUpdater
{
    private readonly WomenShoeCrudService _womenShoeCrudService;

    public WomenShoeUpdater(WomenShoeCrudService womenShoeCrudService)
        : base(womenShoeCrudService)
    {
        _womenShoeCrudService = womenShoeCrudService;
    }

    public override void UpdateDerivedArticle(Article article)
    {
        throw new NotImplementedException();
    }

    protected override void AddDerivedOptions(List<PropertyMenuItem> menuItems)
    {
        throw new NotImplementedException();
    }
}