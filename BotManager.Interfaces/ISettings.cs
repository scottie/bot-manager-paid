using System;
using System.Collections.Generic;

namespace BotManager.Interfaces
{
	public interface ISettings
	{
		List<string> SettingKeys
		{
			get;
			set;
		}

		List<string> SettingValues
		{
			get;
			set;
		}

		string GetSettingValue(string key);

		void AddKeyValue(string key, string value);
	}
}
