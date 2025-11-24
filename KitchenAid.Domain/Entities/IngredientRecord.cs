using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenAid.Domain.Entities
{
	internal class IngredientRecord
	{

		public long Id { get; set; }

		public long IngredientId { get; set; }

		public Ingredient Ingredient { get; set; }

		public long SupplierId { get; set; }

		public Supplier Supplier { get; set; }

		public DateTime DateTime { get; set; }

		public decimal Price { get; set; }

		public bool IsOnOffer { get; set; }
		
		public decimal? OnOfferPrice { get; set; }
	
	}
}
