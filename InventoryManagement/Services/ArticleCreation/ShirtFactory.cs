using InventoryManagement.Models.Articles;
using InventoryManagement.Services.Shell;

namespace InventoryManagement.Services.ArticleCreation;

public abstract class ShirtFactory : ArticleFactory
{
    protected ShirtFactory(ShellInputProvider inputProvider) 
        : base(inputProvider)
    {
    }

    protected string ReadPattern()
    {
        return InputProvider.ReadNonEmptyString("Pattern: ");
    }

    protected bool ReadLongSleeved()
    {
        return InputProvider.ReadBoolean("Has long sleeves: ");
    }

    protected void ReadShirtProperties(Shirt shirt)
    {
        shirt.Pattern = ReadPattern();
        shirt.HasLongSleeves = ReadLongSleeved();
    }
}