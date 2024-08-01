using InventoryManagement.Models.Articles;
using InventoryManagement.Services.CrudServices;

namespace InventoryManagement.Services.ArticleCreation;

public class HatFactory : ArticleFactory
{
    private readonly HatCrudService _hatCrudService;

    public HatFactory(HatCrudService hatCrudService) 
        : base(hatCrudService)
    {
        _hatCrudService = hatCrudService;
    }

    public override Article Create(int id)
    {
        var hat = new Hat(id);
        Console.WriteLine("Please enter the following attributes: ");
        
        ReadArticleProperties(hat);
        
        hat.Size = _hatCrudService.ReadHatSize();
        hat.Style = _hatCrudService.ReadStyle();

        ReadInventoryProperties(hat);

        return hat;
    }
}