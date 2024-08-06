﻿using InventoryManagement.Models.Articles;
using InventoryManagement.Services.CrudServices;

namespace InventoryManagement.Services.ArticleUpdate;

public abstract class ArticleUpdater
{
    protected readonly ArticleCrudService ArticleCrudService;

    protected ArticleUpdater(ArticleCrudService articleCrudService)
    {
        ArticleCrudService = articleCrudService;
    }

    public void UpdateArticle(Article article)
    {
        Console.WriteLine("Which attribute do you want to edit?");
        var menuItems = new List<PropertyMenuItem>();
        BuildMenu(menuItems);
        PrintMenu(menuItems);

        var choice = ReadUserChoice(menuItems);

        HandleUpdate(menuItems[choice], article);
    }

    protected abstract void UpdateDerivedArticle(PropertyMenuItem menuItem, Article article);

    private int ReadUserChoice(List<PropertyMenuItem> menuItems)
    {
        var choice = int.Parse(Console.ReadLine());
        return choice - 1;
    }

    protected void HandleUpdate(PropertyMenuItem menuItem, Article article)
    {
        // todo: implement chain of responsibility 
        switch (menuItem.Text)
        {
            case "Id":
                UpdateId(article);
                break;
            case "Name":
                UpdateName(article);
                break;
            case "Price": 
                UpdatePrice(article);
                break;
            case "Brand":
                UpdateBrand(article);
                break;
            case "Color":
                UpdateColor(article);
                break;
            case "Description":
                UpdateDescription(article);
                break;
            case "Items in Stock":
                UpdateItemsInStock(article);
                break;
            default:
                UpdateDerivedArticle(menuItem, article);
                break;
        }
    }
    
    private void UpdateId(Article article)
    {
        ArticleCrudService.PrintCurrentValue("Current id: ", article.Id);
        article.Id = ArticleCrudService.ReadId();
    }

    private void UpdateName(Article article)
    {
        ArticleCrudService.PrintCurrentValue("Current name: ", article.Name);
        article.Name = ArticleCrudService.ReadName();
    }

    private void UpdatePrice(Article article)
    {
        ArticleCrudService.PrintCurrentValue("Current price: ", article.Price);
        article.Price = ArticleCrudService.ReadPrice();
    }

    private void UpdateBrand(Article article)
    {
        ArticleCrudService.PrintCurrentValue("Current brand: ", article.Brand);
        article.Brand = ArticleCrudService.ReadBrand();
    }

    private void UpdateColor(Article article)
    {
        ArticleCrudService.PrintCurrentValue("Current color: ", article.Color);
        article.Color = ArticleCrudService.ReadColor();
    }

    private void UpdateDescription(Article article)
    {
        ArticleCrudService.PrintCurrentValue("Current description: ", article.Description);
        article.Description = ArticleCrudService.ReadDescription();
    }

    private void UpdateItemsInStock(Article article)
    {
        ArticleCrudService.PrintCurrentValue("Current items in stock: ", article.ItemsInStock);
        article.ItemsInStock = ArticleCrudService.ReadItemsInStock();
    }

    protected void BuildMenu(List<PropertyMenuItem> menuItems)
    {
        menuItems.Add(new PropertyMenuItem(1, "Id"));
        menuItems.Add(new PropertyMenuItem(2, "Name"));
        menuItems.Add(new PropertyMenuItem(3, "Price"));
        menuItems.Add(new PropertyMenuItem(4, "Brand"));
        menuItems.Add(new PropertyMenuItem(5, "Color"));
        menuItems.Add(new PropertyMenuItem(6, "Description"));
        menuItems.Add(new PropertyMenuItem(7, "Items in stock"));

        AddDerivedOptions(menuItems);
    }

    protected abstract void AddDerivedOptions(List<PropertyMenuItem> menuItems);

    protected class PropertyMenuItem
    {
        public int Number { get; }
        public string Text { get; }

        public PropertyMenuItem(int number, string text)
        {
            Number = number;
            Text = text;
        }
    }

    private void PrintMenu(List<PropertyMenuItem> menuItems)
    {
        foreach (var menuItem in menuItems)
        {
            Console.Write("  ");
            Console.Write(menuItem.Number);
            Console.Write(" ");
            Console.WriteLine(menuItem.Text);
        }
    }
}