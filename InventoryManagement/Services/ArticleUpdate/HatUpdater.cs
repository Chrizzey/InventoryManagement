﻿using InventoryManagement.Models.Articles;
using InventoryManagement.Services.CrudServices;

namespace InventoryManagement.Services.ArticleUpdate;

public class HatUpdater : ArticleUpdater
{
    private readonly HatCrudService _hatCrudService;

    public HatUpdater(HatCrudService hatCrudService) 
        : base(hatCrudService)
    {
        _hatCrudService = hatCrudService;
    }
    
    protected override void AddDerivedOptions(List<PropertyMenuItem> menuItems)
    {
        menuItems.Add(new PropertyMenuItem(menuItems.Count, "Size"));
        menuItems.Add(new PropertyMenuItem(menuItems.Count, "Style"));
    }

    public override void UpdateDerivedArticle(Article article)
    {
        throw new NotImplementedException();
    }
}