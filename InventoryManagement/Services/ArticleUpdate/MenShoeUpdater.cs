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
    
    protected override void AddDerivedOptions(List<PropertyMenuItem> menuItems)
    {
        base.AddDerivedOptions(menuItems);

        menuItems.Add(new PropertyMenuItem(menuItems.Count, "Has steel toes"));
    }

    protected override void UpdateDerivedArticle(PropertyMenuItem menuItem, Article article)
    {
        var menShoe = (MenShoe) article;
        switch (menuItem.Text)
        {
            case "Has steel toes":
                UpdateSteelToed(menShoe);
                break;
            default:
                base.UpdateDerivedArticle(menuItem, article);
                break;
        }
    }

    private void UpdateSteelToed(MenShoe shoe)
    {
        _menShoeCrudService.PrintCurrentValue("Has currently steel toes: ", shoe.HasSteelToes);
        shoe.HasSteelToes = _menShoeCrudService.ReadHasSteelToes();
    }
}