using InventoryManagement.Models.Articles;
using InventoryManagement.Services.CrudServices;

namespace InventoryManagement.Services.ArticleUpdate;

public abstract class ShoeUpdater : ArticleUpdater
{
    protected readonly ShoeCrudService ShoeCrudService;

    protected ShoeUpdater(ShoeCrudService shoeCrudService) 
        : base(shoeCrudService)
    {
    }

    protected override void AddDerivedOptions(List<PropertyMenuItem> menuItems)
    {
        menuItems.Add(new PropertyMenuItem(menuItems.Count, "Shoe size"));
    }

    protected override void UpdateDerivedArticle(PropertyMenuItem menuItem, Article article)
    {
        var shoe = (Shoe)article;
        switch (menuItem.Text)
        {
            case "Shoe size":
                UpdateShoeSize(shoe);
                break;
        }
    }

    private void UpdateShoeSize(Shoe shoe)
    {
        ShoeCrudService.PrintCurrentValue("Current shoe size: ", shoe.ShoeSize);
        shoe.ShoeSize = ShoeCrudService.ReadShoeSize();
    }
}