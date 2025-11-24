using KitchenAid;
using KitchenAid.Console;
using KitchenAid.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
services.AddDbContext<AppDbContext>(options => options.UseSqlite("Data Source=myapp.db"));
services.AddScoped<IKitchenAidRepository>(provider => provider.GetRequiredService<AppDbContext>());
var serviceProvider = services.BuildServiceProvider();

AppData appData = new AppData();

while (appData.isRunning)
{
    var repository = serviceProvider.GetRequiredService<IKitchenAidRepository>();

    //render display
    //Render.Display(appData);
    Render.TestDisplay(repository);

    //get command
    //Console.ReadLine();

    //Run/get command
    appData = RunCommand(appData, Console.ReadLine());
}

Environment.Exit(0);

AppData RunCommand(AppData appData, string input)
{
    if (input == "")
    { }
    else if (input == "exit")
    {
        appData.isRunning = false;
    }
    else
    { 
        appData = GetAppData(appData, input); }

    return appData;
}

AppData GetAppData(AppData appData, string input)
{
    var options = (appData.table == Tables.notSet) ? Enum.GetNames(typeof(Tables)) : Enum.GetNames(typeof(tableAction));


    if (input == "back" && appData.action != tableAction.notSet)
    {
        appData.action = tableAction.notSet;
    }
    else if (input == "back" && appData.table != Tables.notSet)
    {

        appData.action = tableAction.notSet;
        appData.table = Tables.notSet;

    }
    else if (int.TryParse(input, out int output) && output < options.Count())
    {

        if (appData.table == Tables.notSet)
        { appData.table = (Tables)output; }
        else if (appData.action == tableAction.notSet)
        { appData.action = (tableAction)output; }
    }
    else if (options.Contains(input.ToLower()))
    {
        if (appData.table == Tables.notSet)
        { appData.table = (Tables)Enum.Parse(typeof(Tables), input); }
        else if (appData.action == tableAction.notSet)
        { appData.action = (tableAction)Enum.Parse(typeof(tableAction), input); }
    }
    else
    {
        Console.WriteLine("\n\rinvalid input\n\rpress any key to continue");
        Console.ReadKey();
    }

    return appData;
}