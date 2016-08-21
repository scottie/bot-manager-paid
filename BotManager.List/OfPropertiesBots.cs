using BotManager.Properties;
using System;
using System.Collections.Generic;

namespace BotManager.List
{
	[Serializable]
	public class OfPropertiesBots
	{
		public List<BotInformation> Items;

		public OfPropertiesBots()
		{
			this.Items = new List<BotInformation>();
		}
	}
}
