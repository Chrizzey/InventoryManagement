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

    public override void UpdateDerivedArticle(Article article)
    {
        throw new NotImplementedException();
    }

    protected override void AddDerivedOptions(List<PropertyMenuItem> menuItems)
    {
        base.AddDerivedOptions(menuItems);

        menuItems.Add(new PropertyMenuItem(menuItems.Count, "Has steel toes"));
    }
}