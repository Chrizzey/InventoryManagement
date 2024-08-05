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

    public override void UpdateDerivedArticle(Article article)
    {
        throw new NotImplementedException();
    }

    protected override void AddDerivedOptions(List<PropertyMenuItem> menuItems)
    {
        throw new NotImplementedException();
    }
}