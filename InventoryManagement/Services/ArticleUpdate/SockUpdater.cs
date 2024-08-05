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

    public override void UpdateDerivedArticle(Article article)
    {
        throw new NotImplementedException();
    }

    protected override void AddDerivedOptions(List<PropertyMenuItem> menuItems)
    {
        menuItems.Add(new PropertyMenuItem(menuItems.Count, "Size"));   
        menuItems.Add(new PropertyMenuItem(menuItems.Count, "Number of pairs"));   
        
    }
}