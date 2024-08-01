using InventoryManagement.Models.Articles;
using InventoryManagement.Services.CrudServices;

namespace InventoryManagement.Services.ArticleCreation;

public abstract class ShirtFactory : ArticleFactory
{
    protected readonly ShirtCrudService ShirtCrudService;

    protected ShirtFactory(ShirtCrudService shirtCrudService) 
        : base(shirtCrudService)
    {
        ShirtCrudService = shirtCrudService;
    }
    
    protected void ReadShirtProperties(Shirt shirt)
    {
        shirt.Pattern = ShirtCrudService.ReadPattern();
        shirt.HasLongSleeves = ShirtCrudService.ReadLongSleeved();
    }
}