using InventoryManagement.Contracts;
using InventoryManagement.Models.Articles;

namespace InventoryManagement.Services;

/// <summary>
/// A service creating articles for testing purposes
/// </summary>
public class TestDataFactory
{
    private readonly IArticleRepository _articleRepository;

    /// <summary>
    /// Creates a new instance
    /// </summary>
    /// <param name="articleRepository">A repository to store the test data</param>
    public TestDataFactory(IArticleRepository articleRepository)
    {
        _articleRepository = articleRepository;
    }

    /// <summary>
    /// Adds a number of socks to the test data
    /// </summary>
    public void AddSocks(int numberOfSocksToAdd)
    {
        var lastId = GetLastId();

        for (var i = lastId; i < numberOfSocksToAdd; i++)
        {
            var socks = new Socks(i)
            {
                Brand = "No-name",
                Color = "Black",
                ItemsInStock = 100,
                NumberOfPairs = 4,
                Price = 19.99m,
                Size = "39-42",
                Name = "Black no-name socks"
            };
            _articleRepository.AddArticle(socks);
        }
    }

    private int GetLastId()
    {
        for (var i = 0; i < int.MaxValue; i++)
        {
            if(!_articleRepository.DoesIdExist(i))
                return i;
        }

        throw new NotImplementedException();
    }

    /// <summary>
    /// Adds a single shirt for men to the test data
    /// </summary>
    public void AddMenShirts()
    {
        _articleRepository.AddArticle(new MenShirt(100)
        {
            Name = "Formal Shirt",
            Brand = "Armani",
            Color = "Pale Blue",
            Price = 59.99m,
            Pattern = "Solid Color",
            HasLongSleeves = true,
            ShirtSize = StandardSize.Medium,
            Description = "A stylish shirt by Armani in solid pale blue",
            ItemsInStock = 152
        });
    }
}