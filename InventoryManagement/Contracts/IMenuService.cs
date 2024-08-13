namespace InventoryManagement.Contracts;

/// <summary>
/// A menu service used for property change interactions
/// </summary>
public interface IMenuService
{
    /// <summary>
    /// Prints the menu and lets the user choose on of the options
    /// </summary>
    /// <param name="menuItems">The menu items to be displayed</param>
    /// <returns>The menu item chosen by the user</returns>
    PropertyMenuItem PrintMenuAndReadUserChoice(List<PropertyMenuItem> menuItems);
}