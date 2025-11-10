using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenAid
{
	internal class DbTable
	{

		public long Id;


		public DbTableReturn AddEntery()
		{
			return DbTableReturn.NotSet;
		}

		public DbTableReturn RemoveEntery()
		{
			return DbTableReturn.NotSet;
		}

	}

	internal enum DbTableReturn
	{
		NotSet

	}
}
