using InventoryManagement.Models.Articles;
using InventoryManagement.Services.CrudServices;

namespace InventoryManagement.Services.ArticleCreation;

/// <summary>
/// Represents a creation service to create <see cref="MenShirt"/> items
/// </summary>
public class MenShirtFactory : ShirtFactory
{
    private readonly MenShirtCrudService _menShirtCrudService;

    /// <summary>
    /// Creates a new instance
    /// </summary>
    public MenShirtFactory(MenShirtCrudService menShirtCrudService) 
        : base(menShirtCrudService)
    {
        _menShirtCrudService = menShirtCrudService;
    }

    /// <inheritdoc />
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