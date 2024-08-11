﻿using InventoryManagement.Contracts;
using InventoryManagement.Models.Articles;

namespace InventoryManagement.Services
{
    public class TestDataFactory
    {
        private readonly IArticleRepository _articleRepository;

        public TestDataFactory(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

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
}
