using BotManager.Properties;
using Microsoft.VisualBasic.CompilerServices;
using System;

namespace BotManager.Manager
{
	public class BotFactory
	{
		public static Generic GetBot(ref BotInformation botProperties)
		{
			string botClass = botProperties.BotClass;
			Generic result;
			if (Operators.CompareString(botClass, "BotManager.Manager.HaxtonBot", false) != 0)
			{
				if (Operators.CompareString(botClass, "BotManager.Manager.SpegeliBot", false) != 0)
				{
					if (Operators.CompareString(botClass, "BotManager.Manager.NecroBot", false) != 0)
					{
						if (Operators.CompareString(botClass, "BotManager.Manager.PokeMobBot", false) != 0)
						{
							throw new Exception("Uknown Bot Class!");
						}
						result = new PokeMobBot(ref botProperties);
					}
					else
					{
						result = new NecroBot(ref botProperties);
					}
				}
				else
				{
					result = new SpegeliBot(ref botProperties);
				}
			}
			else
			{
				result = new HaxtonBot(ref botProperties);
			}
			return result;
		}
	}
}
