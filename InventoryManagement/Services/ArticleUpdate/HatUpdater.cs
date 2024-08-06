using InventoryManagement.Models.Articles;
using InventoryManagement.Services.CrudServices;

namespace InventoryManagement.Services.ArticleUpdate;

public class HatUpdater : ArticleUpdater
{
    private readonly HatCrudService _hatCrudService;

    public HatUpdater(HatCrudService hatCrudService) 
        : base(hatCrudService)
    {
        _hatCrudService = hatCrudService;
    }

    protected override void AddDerivedOptions(List<PropertyMenuItem> menuItems)
    {
        menuItems.Add(new PropertyMenuItem(menuItems.Count, "Size"));
        menuItems.Add(new PropertyMenuItem(menuItems.Count, "Style"));
    }
    
    protected override void UpdateDerivedArticle(PropertyMenuItem menuItem, Article article)
    {
        var hat = (Hat) article;
        switch (menuItem.Text)
        {
            case "Size":
                UpdateSize(hat);
                break;
            case "Style":
                UpdateStyle(hat);
                break;
        }
    }
    
    private void UpdateStyle(Hat hat)
    {
        _hatCrudService.PrintCurrentValue("Current size: ", hat.Size);
        hat.Size = _hatCrudService.ReadHatSize();
    }
    private void UpdateSize(Hat hat)
    {
        _hatCrudService.PrintCurrentValue("Current style: ", hat.Style);
        hat.Style = _hatCrudService.ReadStyle();
    }
}