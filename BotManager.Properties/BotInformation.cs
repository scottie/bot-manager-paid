using BotManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace BotManager.Properties
{
	[Serializable]
	public class BotInformation : ISettings
	{
		public string TempExecutablePath;

		public int RestartTimer;

		public bool Hide;

		public string BotClass;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
		private List<string> _SettingKeys;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
		private List<string> _SettingValues;

		public List<string> SettingKeys
		{
			get;
			set;
		}

		public List<string> SettingValues
		{
			get;
			set;
		}

		public void AddKeyValue(string key, string value)
		{
			if (this.SettingKeys.Contains(key))
			{
				this.SettingValues[this.SettingKeys.IndexOf(key)] = value;
			}
			else
			{
				this.SettingKeys.Add(key);
				this.SettingValues.Add(value);
			}
		}

		public string GetSettingValue(string key)
		{
			int index = this.SettingKeys.IndexOf(key);
			return this.SettingValues[index];
		}

		public BotInformation()
		{
			this.TempExecutablePath = "";
			this.Hide = false;
			this.SettingKeys = new List<string>();
			this.SettingValues = new List<string>();
		}
	}
}
