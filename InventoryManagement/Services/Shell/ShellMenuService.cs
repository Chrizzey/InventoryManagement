using InventoryManagement.Services.ArticleUpdate;

namespace InventoryManagement.Services.Shell;

public class ShellMenuService : IMenuService
{
    public PropertyMenuItem PrintMenuAndReadUserChoice(List<PropertyMenuItem> menuItems)
    {
        PrintMenu(menuItems);
        int userInput;

        do
        {
            userInput = ReadUserChoice() - 1;
        } while (userInput < 0 || userInput >= menuItems.Count);

        return menuItems[userInput];
    }


    private void PrintMenu(List<PropertyMenuItem> menuItems)
    {
        Console.WriteLine("Which attribute do you want to edit?");
        foreach (var menuItem in menuItems)
        {
            Console.Write("  ");
            Console.Write(menuItem.Number);
            Console.Write(" ");
            Console.WriteLine(menuItem.Text);
        }
    }

    private int ReadUserChoice()
    {
        string input;
        int number;
        do
        {
            input = Console.ReadLine();
        } while (!int.TryParse(input, out number));

        return number;
    }
}