

using KitchenAid.Domain.Entities;

public struct AppData
{
	public bool isRunning { get; set; }
	public Tables table { get; set; }
	public tableAction action { get; set; }

	public Recipe? recipe { get; set; }
	public Ingredient? ingredient { get; set; }
	public Supplier? suppliers { get; set; }

	public AppData()
	{
		isRunning = true;
		table = Tables.notSet;
		action = tableAction.notSet;

		recipe = null;
		ingredient = null;
		suppliers = null;
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
	remove,
	update
}

