using BotManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace BotManager.Properties
{
	public class SupportedBotInformation : ISettings
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
		private string _Name;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
		private string _ZipName;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
		private string _UnZipDirectory;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
		private string _DownloadUrl;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
		private string _WorkingDirectory;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
		private string _ExecutablePath;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
		private bool _DisplayAsBot;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
		private string _BotClass;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
		private List<string> _SettingKeys;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
		private List<string> _SettingValues;

		public string Name
		{
			get;
			set;
		}

		public string ZipName
		{
			get;
			set;
		}

		public string UnZipDirectory
		{
			get;
			set;
		}

		public string DownloadUrl
		{
			get;
			set;
		}

		public string WorkingDirectory
		{
			get;
			set;
		}

		public string ExecutablePath
		{
			get;
			set;
		}

		public bool DisplayAsBot
		{
			get;
			set;
		}

		public string BotClass
		{
			get;
			set;
		}

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

		public SupportedBotInformation()
		{
			this.DisplayAsBot = true;
			this.SettingKeys = new List<string>();
			this.SettingValues = new List<string>();
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
	}
}
