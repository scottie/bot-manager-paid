using BotManager.List;
using BotManager.Properties;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace BotManager.Manager
{
	public class HaxtonBot : Generic
	{
		public HaxtonBot(ref BotInformation botInformation) : base(ref botInformation)
		{
			this.ExecutablePath = OfSupportedBots.GetInstance()["HaxtonBot"].ExecutablePath;
		}

		public override void WriteSettings()
		{
			Configuration configuration = ConfigurationManager.OpenMappedExeConfiguration(new ExeConfigurationFileMap
			{
				ExeConfigFilename = this.BotInformation.TempExecutablePath + ".config"
			}, ConfigurationUserLevel.None);
			object appSettings = configuration.AppSettings;
			object obj = new KeyValueConfigurationElement("TempSetting", "temp");
			object[] array;
			bool[] array2;
			NewLateBinding.LateCall(NewLateBinding.LateGet(appSettings, null, "Settings", new object[0], null, null, null), null, "Add", array = new object[]
			{
				obj
			}, null, null, array2 = new bool[]
			{
				true
			}, true);
			if (array2[0])
			{
				obj = RuntimeHelpers.GetObjectValue(array[0]);
			}
			try
			{
				List<string>.Enumerator enumerator = this.BotInformation.SettingKeys.GetEnumerator();
				while (enumerator.MoveNext())
				{
					string current = enumerator.Current;
					((AppSettingsSection)appSettings).Settings[current].Value = this.BotInformation.GetSettingValue(current).ToString();
				}
			}
			finally
			{
				List<string>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			((AppSettingsSection)appSettings).Settings.Remove("TempSetting");
			configuration.Save(ConfigurationSaveMode.Full);
		}

		public static void ReadSettings(ref SupportedBotInformation supportedBotInformation)
		{
			Configuration configuration = ConfigurationManager.OpenMappedExeConfiguration(new ExeConfigurationFileMap
			{
				ExeConfigFilename = supportedBotInformation.ExecutablePath + ".config"
			}, ConfigurationUserLevel.None);
			object appSettings = configuration.AppSettings;
			try
			{
				IEnumerator enumerator = ((IEnumerable)NewLateBinding.LateGet(appSettings, null, "Settings", new object[0], null, null, null)).GetEnumerator();
				while (enumerator.MoveNext())
				{
					object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
					supportedBotInformation.AddKeyValue(Conversions.ToString(NewLateBinding.LateGet(objectValue, null, "Key", new object[0], null, null, null)), NewLateBinding.LateGet(objectValue, null, "Value", new object[0], null, null, null).ToString());
				}
			}
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}
	}
}
