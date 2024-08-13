using InventoryManagement.Contracts;

namespace InventoryManagement.Services.Shell;

/// <summary>
/// A service responsible for collecting user input
/// </summary>
public class ShellInputProvider
{
    /// <summary>
    /// Prints a given <paramref name="displayText"/> and parses the given input as a decimal value
    /// greater or equal to 0
    /// </summary>
    /// <param name="displayText">The hint text to display to the user</param>
    /// <returns>The user input as a decimal value greater or equal to zero</returns>
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

    /// <summary>
    /// Prints a given <paramref name="displayText"/> and reads any string from the user
    /// </summary>
    /// <param name="displayText">The hint text to display to the user</param>
    /// <returns>The raw user input as a string</returns>
    public string ReadString(string displayText)
    {
        Console.Write(displayText);
        return Console.ReadLine();
    }

    /// <summary>
    /// Prints a given <paramref name="displayText"/> and reads the given input as a integer value
    /// greater or equal to 0
    /// </summary>
    /// <param name="displayText">The hint text to display to the user</param>
    /// <returns>TThe user input as a integer value greater or equal to zero</returns>
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

    /// <summary>
    /// Prints a given <paramref name="displayText"/> and reads any non-empty string from the user
    /// </summary>
    /// <param name="displayText">The hint text to display to the user</param>
    /// <returns>The user input as a non-empty, non-whitespace string</returns>
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

    /// <summary>
    /// Prints a given <paramref name="displayText"/> and reads the given input as a <see cref="StandardSize"/> value
    /// </summary>
    /// <param name="displayText">The hint text to display to the user</param>
    /// <returns>TThe user input as a <see cref="StandardSize"/> value</returns>
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

    /// <summary>
    /// Prints a given <paramref name="displayText"/> and reads the given input as a boolean value
    /// </summary>
    /// <param name="displayText">The hint text to display to the user</param>
    /// <returns>TThe user input as a boolean flag</returns>
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

    /// <summary>
    /// Outputs the current property value
    /// </summary>
    /// <param name="title">The name of the property</param>
    /// <param name="value">The value of the property</param>
    public void PrintCurrentValue(string title, object value)
    {
        Console.Write(title);
        Console.WriteLine(value);
    }
}