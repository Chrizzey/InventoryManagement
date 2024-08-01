using InventoryManagement.Models.Articles;
using InventoryManagement.Services.CrudServices;

namespace InventoryManagement.Services.ArticleCreation;

public class MenShirtFactory : ShirtFactory
{
    private readonly MenShirtCrudService _menShirtCrudService;

    public MenShirtFactory(MenShirtCrudService menShirtCrudService) 
        : base(menShirtCrudService)
    {
        _menShirtCrudService = menShirtCrudService;
    }

    public override Article Create(int id)
    {
        var shirt = new MenShirt(id);
        Console.WriteLine("Please enter the following attributes: ");

        ReadArticleProperties(shirt);
        ReadShirtProperties(shirt);

        shirt.ShirtSize = _menShirtCrudService.ReadShirtSize();

        ReadInventoryProperties(shirt);

        return shirt;
    }
}