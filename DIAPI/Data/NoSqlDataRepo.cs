using DIAPI.DataServices;

namespace DIAPI.Data;

public class NoSqlDataRepo : IDataRepo
{
    private readonly IDataService _dataService;

    public NoSqlDataRepo(IDataService dataService)
    {
        _dataService = dataService;
    }
    public string ReturnData()
    {
        var resut = _dataService.GetProductData("in NO SQL");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine($"--> Getting data from NoSQL Databse... {resut}");
        Console.ResetColor();
        
        return ("No SQL Data from DB");
    }
}