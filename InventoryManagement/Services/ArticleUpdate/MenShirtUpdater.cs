using InventoryManagement.Models.Articles;
using InventoryManagement.Services.CrudServices;

namespace InventoryManagement.Services.ArticleUpdate;

public class MenShirtUpdater : ShirtUpdater
{
    private readonly MenShirtCrudService _menShirtCrudService;

    public MenShirtUpdater(MenShirtCrudService menShirtCrudService)
        : base(menShirtCrudService)
    {
        _menShirtCrudService = menShirtCrudService;
    }

    public override void UpdateArticle(Article article)
    {
        throw new NotImplementedException();
    }
}