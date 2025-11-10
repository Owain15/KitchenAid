

public struct AppData
{
	public bool isRunning { get; set; }
	public Tables table { get; set; }
	public tableAction action { get; set; }

	public AppData()
	{
		isRunning = true;
		table = Tables.notSet;
		action = tableAction.notSet;
	}

}

public enum Tables
{
	notSet,
	recipe,
	ingredient,
	suppliers
}

public enum tableAction
{
	notSet,
	view,
	add,
	remove
}

