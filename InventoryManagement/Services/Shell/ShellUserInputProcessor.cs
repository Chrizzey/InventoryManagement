﻿using InventoryManagement.Contracts;
using InventoryManagement.Models.Articles;
using InventoryManagement.Models.Exceptions;
using InventoryManagement.Services.ArticleCreation;
using InventoryManagement.Services.ArticleUpdate;

namespace InventoryManagement.Services.Shell;

public class ShellUserInputProcessor : IUserInputProcessor
{
    private readonly IArticleRepository _articleRepository;
    private readonly ShellInputProvider _inputProvider;
    private readonly ArticlePrinter _articlePrinter;

    public ShellUserInputProcessor(IArticleRepository articleRepository)
    {
        _articleRepository = articleRepository;
        _articlePrinter = new ArticlePrinter(articleRepository);
        _inputProvider = new ShellInputProvider();
    }

    public void ListAllArticles()
    {
        _articlePrinter.PrintOverview();
    }

    public void ShowArticleDetails(Article article)
    {
        _articlePrinter.Print(article);
    }

    public void CreateNewArticle()
    {
        int choice;
        string input;
        do
        {
            Console.WriteLine("Which article do you want to create?");
            Console.WriteLine("[1] Socks");
            Console.WriteLine("[2] Hat");
            Console.WriteLine("[3] Shirt (Men)");
            Console.WriteLine("[4] Shirt (Women)");
            Console.WriteLine("[5] Shoe (Men)");
            Console.WriteLine("[6] Shoe (Women)");

            input = Console.ReadLine();
        } while (!int.TryParse(input, out choice));

        var factoryFacade = new ArticleFactoryFacade(_inputProvider, _articleRepository);
        var article = factoryFacade.CreateNewArticle(choice);
        _articleRepository.AddArticle(article);
    }
    
    public void UpdateArticle(Article article)
    {
        ShowArticleDetails(article);
        Console.WriteLine();

        var updateFacade = new ArticleUpdateFacade(new ShellInputProvider());
        updateFacade.UpdateArticle(article);
        _articleRepository.UpdateArticle(article);
    }

    public void DeleteArticle(Article article)
    {
        _articleRepository.DeleteArticle(article);
    }

    public Article SelectArticle()
    {
        for (var i = 0; i < 5; i++)
        {
            Console.Write("Please enter the article number: ");
            var input = Console.ReadLine();
            if (!int.TryParse(input, out var artNo))
            {
                Console.WriteLine("Invalid article number. Please enter a valid number.");
                continue;
            }

            try
            {
                return _articleRepository.GetArticle(artNo);
            }
            catch (ArticleNotFoundException ex)
            {
                Console.WriteLine($"No article with number {ex.Id} exists in the inventory. Please enter a valid number");
            }
        }

        throw new NotImplementedException();
    }
}