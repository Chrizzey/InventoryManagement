using InventoryManagement.Models.Articles;
using InventoryManagement.Services.CrudServices;

namespace InventoryManagement.Services.ArticleCreation;

public abstract class ShoeFactory : ArticleFactory
{
    protected readonly ShoeCrudService ShoeCrudService;

    protected ShoeFactory(ShoeCrudService shoeCrudService) 
        : base(shoeCrudService)
    {
        ShoeCrudService = shoeCrudService;
    }

    protected void ReadShoeProperties(Shoe shoe)
    {
        shoe.ShoeSize = ShoeCrudService.ReadShoeSize();
    }

}