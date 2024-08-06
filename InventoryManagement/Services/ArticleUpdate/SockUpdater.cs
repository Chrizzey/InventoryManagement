using InventoryManagement.Models.Articles;
using InventoryManagement.Services.CrudServices;

namespace InventoryManagement.Services.ArticleUpdate;

public class SockUpdater : ArticleUpdater
{
    private readonly SockCrudService _sockCrudService;

    public SockUpdater(SockCrudService sockCrudService)
        : base(sockCrudService)
    {
        _sockCrudService = sockCrudService;
    }

    protected override void AddDerivedOptions(List<PropertyMenuItem> menuItems)
    {
        menuItems.Add(new PropertyMenuItem(menuItems.Count, "Size"));
        menuItems.Add(new PropertyMenuItem(menuItems.Count, "Number of pairs"));

    }

    protected override void UpdateDerivedArticle(PropertyMenuItem menuItem, Article article)
    {
        var socks = (Socks)article;
        switch (menuItem.Text)
        {
            case "Size":
                UpdateSize(socks);
                break;
            case "Number of pairs":
                UpdateNumberOfPairs(socks);
                break;
        }
    }

    private void UpdateSize(Socks socks)
    {
        _sockCrudService.PrintCurrentValue("Current size: ", socks.Size);
        socks.Size = _sockCrudService.ReadSockSize();
    }

    private void UpdateNumberOfPairs(Socks socks)
    {
        _sockCrudService.PrintCurrentValue("Current number of pairs per unit: ", socks.NumberOfPairs);
        socks.NumberOfPairs = _sockCrudService.ReadNumberOfPairs();
    }
}