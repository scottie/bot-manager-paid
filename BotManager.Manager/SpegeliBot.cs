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
	public class SpegeliBot : Generic
	{
		public SpegeliBot(ref BotInformation botInformation) : base(ref botInformation)
		{
			this.ExecutablePath = OfSupportedBots.GetInstance()["SpegeliBot"].ExecutablePath;
		}

		public override void WriteSettings()
		{
			Configuration configuration = ConfigurationManager.OpenMappedExeConfiguration(new ExeConfigurationFileMap
			{
				ExeConfigFilename = this.BotInformation.TempExecutablePath + ".config"
			}, ConfigurationUserLevel.None);
			object section = configuration.GetSection("userSettings/PokemonGo.RocketAPI.Console.UserSettings");
			object obj = new SettingElement("TempSetting", SettingsSerializeAs.String);
			object[] array;
			bool[] array2;
			NewLateBinding.LateCall(NewLateBinding.LateGet(section, null, "Settings", new object[0], null, null, null), null, "Add", array = new object[]
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
					string text = enumerator.Current;
					object instance = NewLateBinding.LateGet(NewLateBinding.LateGet(section, null, "Settings", new object[0], null, null, null), null, "Get", array = new object[]
					{
						text
					}, null, null, array2 = new bool[]
					{
						true
					});
					if (array2[0])
					{
						text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
					}
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(instance, null, "Value", new object[0], null, null, null), null, "ValueXml", new object[0], null, null, null), null, "LastChild", new object[0], null, null, null), null, "InnerText", new object[]
					{
						this.BotInformation.GetSettingValue(text).ToString()
					}, null, null, false, true);
				}
			}
			finally
			{
				List<string>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			NewLateBinding.LateCall(NewLateBinding.LateGet(section, null, "Settings", new object[0], null, null, null), null, "Remove", array = new object[]
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
			configuration.Save(ConfigurationSaveMode.Full);
		}

		public static void ReadSettings(ref SupportedBotInformation supportedBotInformation)
		{
			Configuration configuration = ConfigurationManager.OpenMappedExeConfiguration(new ExeConfigurationFileMap
			{
				ExeConfigFilename = supportedBotInformation.ExecutablePath + ".config"
			}, ConfigurationUserLevel.None);
			object section = configuration.GetSection("userSettings/PokemonGo.RocketAPI.Console.UserSettings");
			try
			{
				IEnumerator enumerator = ((IEnumerable)NewLateBinding.LateGet(section, null, "Settings", new object[0], null, null, null)).GetEnumerator();
				while (enumerator.MoveNext())
				{
					object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
					supportedBotInformation.AddKeyValue(Conversions.ToString(NewLateBinding.LateGet(objectValue, null, "Name", new object[0], null, null, null)), Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Value", new object[0], null, null, null), null, "ValueXml", new object[0], null, null, null), null, "InnerText", new object[0], null, null, null)));
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
