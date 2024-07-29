using InventoryManagement.Models.Articles;
using InventoryManagement.Services.Shell;

namespace InventoryManagement.Services.ArticleCreation;

public class WomenShirtFactory : ShirtFactory
{
    public WomenShirtFactory(ShellInputProvider inputProvider) 
        : base(inputProvider)
    {
    }

    public override Article Create(int id)
    {
        var shirt = new WomenShirt(id);
        
        ReadArticleProperties(shirt);
        ReadShirtProperties(shirt);

        shirt.Size = ReadShirtSize();
        shirt.Material = ReadMaterial();

        ReadInventoryProperties(shirt);

        return shirt;
    }

    private int ReadShirtSize()
    {
        return InputProvider.ReadPositiveNumber("Size: ");
    }
    private string ReadMaterial()
    {
        return InputProvider.ReadNonEmptyString("Material: ");
    }
}