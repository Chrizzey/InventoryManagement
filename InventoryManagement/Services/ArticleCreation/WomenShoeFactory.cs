using InventoryManagement.Models.Articles;
using InventoryManagement.Services.Shell;

namespace InventoryManagement.Services.ArticleCreation;

public class WomenShoeFactory : ShoeFactory
{
    public WomenShoeFactory(ShellInputProvider inputProvider) : base(inputProvider)
    {
    }

    public override Article Create(int id)
    {
        var shoe = new WomenShoe(id);

        ReadArticleProperties(shoe);
        ReadShoeProperties(shoe);

        shoe.HeelHeight = ReadHeelHeight();

        ReadInventoryProperties(shoe);

        return shoe;
    }

    private decimal ReadHeelHeight()
    {
        return InputProvider.ReadPositiveDecimal("Heel height: ");
    }
}