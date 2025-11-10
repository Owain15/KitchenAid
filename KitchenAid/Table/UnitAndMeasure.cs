namespace KitchenAid.Table
{
	public class UnitAndMeasure
	{
		public decimal Measurement { get; set; }

		public Units Unit { get; set; }

	}

	public enum Units
	{
		Grams,
		Millilitres
	}

}
