using InventoryManagement.Models.Articles;

namespace InventoryManagement.Services.Shell;

public class ArticlePrinter
{
    public void Print(Article article)
    {
        Console.WriteLine();
        Console.WriteLine($"Article [{article.GetType().Name}]:");
        Console.WriteLine($"\t              Id: {article.Id}");
        Console.WriteLine($"\t            Name: {article.Name}");
        Console.WriteLine($"\t           Brand: {article.Brand}");
        Console.WriteLine($"\t           Color: {article.Color}");
        Console.WriteLine($"\t        In stock: {article.ItemsInStock}");

        PrintArticleProperties(article);

        Console.WriteLine($"\t     Description: {article.Description}");
    }

    private void PrintArticleProperties(Article article)
    {
        if (article is Socks)
        {
            PrintSocks((Socks)article);
        }
        else if (article is Hat)
        {
            PrintHat((Hat)article);
        }
        else if (article is Shirt)
        {
            PrintShirt((Shirt)article);
            if (article is MenShirt)
            {
                PrintMenShirt((MenShirt)article);
            }
            else if (article is WomenShirt)
            {
                PrintWomenShirt((WomenShirt)article);
            }
        }
        else if (article is Shoe)
        {
            PrintShoe((Shoe)article);
            if (article is MenShoe)
            {
                PrintMenShoe((MenShoe)article);
            }
            else if (article is WomenShoe)
            {
                PrintWomenShoe((WomenShoe)article);
            }
        }
    }

    private void PrintWomenShoe(WomenShoe shoe)
    {
        Console.WriteLine($"\t     Heel height: {shoe.HeelHeight}");
    }

    private void PrintMenShoe(MenShoe shoe)
    {
        Console.WriteLine($"\t  Has steel toes: {shoe.HasSteelToes}");
    }

    private void PrintShoe(Shoe shoe)
    {
        Console.WriteLine($"\t            Size: {shoe.ShoeSize}");
    }

    private void PrintWomenShirt(WomenShirt shirt)
    {
        Console.WriteLine($"\t            Size: {shirt.Size}");
        Console.WriteLine($"\t        Material: {shirt.Material}");
    }

    private void PrintMenShirt(MenShirt shirt)
    {
        Console.WriteLine($"\t            Size: {shirt.ShirtSize}");
    }

    private void PrintShirt(Shirt shirt)
    {
        Console.WriteLine($"\t         Pattern: {shirt.Pattern}");
        Console.WriteLine($"\tHas long sleeves: {shirt.HasLongSleeves}");
    }

    private void PrintHat(Hat hat)
    {
        Console.WriteLine($"\t            Size: {hat.Size}");
        Console.WriteLine($"\t           Style: {hat.Style}");
    }

    private void PrintSocks(Socks socks)
    {
        Console.WriteLine($"\t            Size: {socks.Size}");
        Console.WriteLine($"\t Number of Pairs: {socks.NumberOfPairs}");
    }
}