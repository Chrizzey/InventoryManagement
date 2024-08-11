namespace InventoryManagement.Services.ArticleUpdate;

public interface IMenuService
{
    PropertyMenuItem PrintMenuAndReadUserChoice(List<PropertyMenuItem> menuItems);
}