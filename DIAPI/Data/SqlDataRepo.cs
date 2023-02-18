namespace DIAPI.Data;

public class SqlDataRepo : IDataRepo
{
    public string ReturnData()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("--> Getting data from SQL Databse,,,");
        Console.ResetColor();
        
        return ("SQL from DB");
    }
}