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

    public override void UpdateArticle(Article article)
    {
        throw new NotImplementedException();
    }
}