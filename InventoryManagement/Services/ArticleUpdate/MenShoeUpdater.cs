using InventoryManagement.Models.Articles;
using InventoryManagement.Services.CrudServices;

namespace InventoryManagement.Services.ArticleUpdate;

public class MenShoeUpdater : ShoeUpdater
{
    private readonly MenShoeCrudService _menShoeCrudService;

    public MenShoeUpdater(MenShoeCrudService menShoeCrudService) 
        : base(menShoeCrudService)
    {
        _menShoeCrudService = menShoeCrudService;
    }

    public override void UpdateArticle(Article article)
    {
        throw new NotImplementedException();
    }
}