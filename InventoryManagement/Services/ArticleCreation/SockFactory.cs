using InventoryManagement.Models.Articles;
using InventoryManagement.Services.CrudServices;

namespace InventoryManagement.Services.ArticleCreation;

/// <summary>
/// Represents a creation service to create <see cref="Socks"/> items
/// </summary>
public class SockFactory : ArticleFactory
{
    private readonly SockCrudService _sockCrudService;

    /// <summary>
    /// Creates a new instance
    /// </summary>
    public SockFactory(SockCrudService sockCrudService)
        : base(sockCrudService)
    {
        _sockCrudService = sockCrudService;
    }

    /// <inheritdoc />
    public override Article Create(int id)
    {
        var socks = new Socks(id);
        Console.WriteLine("Please enter the following attributes: ");

        ReadArticleProperties(socks);
        
        socks.Size = _sockCrudService.ReadSockSize();
        socks.NumberOfPairs = _sockCrudService.ReadNumberOfPairs();

        ReadInventoryProperties(socks);

        return socks;
    }
}