using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenAid.Table
{
	internal class Supplier : DbTable
	{
		public long Id { get; set; }

		public string Name { get; set; }

		public string? URL { get; set; }

		public string? EmailAddress { get; set; }

		public string? PhoneNumber { get; set; }
	}
}
