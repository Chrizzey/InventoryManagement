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

    public override void UpdateArticle(Article article)
    {
        throw new NotImplementedException();
    }
}