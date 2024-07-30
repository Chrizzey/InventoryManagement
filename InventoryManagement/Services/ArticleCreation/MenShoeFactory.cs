using InventoryManagement.Models.Articles;
using InventoryManagement.Services.Shell;

namespace InventoryManagement.Services.ArticleCreation;

public class MenShoeFactory : ShoeFactory
{
    public MenShoeFactory(ShellInputProvider inputProvider) 
        : base(inputProvider)
    {
    }

    public override Article Create(int id)
    {
        var shoe = new MenShoe(id);

        ReadArticleProperties(shoe);
        ReadShoeProperties(shoe);

        shoe.HasSteelToes = ReadHasSteelToes();

        ReadInventoryProperties(shoe);

        return shoe;
    }

    private bool ReadHasSteelToes()
    {
        return InputProvider.ReadBoolean("Has steel toes: ");
    }
}