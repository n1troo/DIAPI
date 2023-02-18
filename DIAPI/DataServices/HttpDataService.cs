namespace DIAPI.DataServices;

public class HttpDataService : DataServices.IDataService
{
    public string GetProductData(string url)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Getting product data...");
        Console.ResetColor();
        return "Some product data";
    }
}