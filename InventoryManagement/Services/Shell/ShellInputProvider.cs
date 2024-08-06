using InventoryManagement.Contracts;

namespace InventoryManagement.Services.Shell;

public class ShellInputProvider
{
    public decimal ReadPositiveDecimal(string displayText)
    {
        string input;
        decimal price;
        do
        {
            Console.Write(displayText);
            input = Console.ReadLine();
        } while (!decimal.TryParse(input, out price) || price < 0m);

        return price;
    }

    public string ReadString(string displayText)
    {
        Console.Write(displayText);
        return Console.ReadLine();
    }

    public int ReadPositiveNumber(string displayText)
    {
        string input;
        int number;
        do
        {
            Console.Write(displayText);
            input = Console.ReadLine();
        } while (!int.TryParse(input, out number) || number < 0);

        return number;
    }

    public string ReadNonEmptyString(string displayText)
    {
        string brand;
        do
        {
            Console.Write(displayText);
            brand = Console.ReadLine();
        } while (string.IsNullOrWhiteSpace(brand));

        return brand;
    }

    public StandardSize ReadStandardSize(string displayText)
    {
        string input;
        StandardSize size;
        do
        {
            Console.Write(displayText);
            input = Console.ReadLine();
        } while (!Enum.TryParse(input,out size));

        return size;
    }

    public bool ReadBoolean(string displayText)
    {
        string input;
        bool result;
        do
        {
            Console.Write(displayText);
            input = Console.ReadLine();
        } while(!bool.TryParse(input,out result));

        return result;
    }

    public void PrintCurrentValue(string title, object value)
    {
        Console.Write(title);
        Console.WriteLine(value);
    }
}