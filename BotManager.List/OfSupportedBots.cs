using BotManager.Properties;
using System;
using System.Collections.Generic;

namespace BotManager.List
{
	public class OfSupportedBots : Dictionary<string, SupportedBotInformation>
	{
		private static OfSupportedBots _instances;

		private OfSupportedBots()
		{
		}

		public static Dictionary<string, SupportedBotInformation> GetInstance()
		{
			Dictionary<string, SupportedBotInformation> instances;
			if (OfSupportedBots._instances == null)
			{
				OfSupportedBots._instances = new OfSupportedBots();
				OfSupportedBots._instances.Add("SpegeliBot", new SupportedBotInformation
				{
					Name = "SpegeliBot",
					DownloadUrl = "https://github.com/chancity/BotManagerBots/raw/master/Bots/SpegeliBot/Release.zip",
					WorkingDirectory = "SpegeliBot/Release",
					ZipName = "SpegeliBot.zip",
					UnZipDirectory = "SpegeliBot",
					ExecutablePath = "SpegeliBot/Release/PokemonGo.RocketAPI.Console.exe",
					BotClass = "BotManager.Manager.SpegeliBot"
				});
				OfSupportedBots._instances.Add("HaxtonBot", new SupportedBotInformation
				{
					Name = "HaxtonBot",
					DownloadUrl = "https://github.com/chancity/BotManagerBots/raw/master/Bots/HaxtonBot/Release.zip",
					WorkingDirectory = "HaxtonBot/Release",
					ZipName = "HaxtonBot.zip",
					UnZipDirectory = "HaxtonBot",
					ExecutablePath = "HaxtonBot/Release/PokemonGo.Haxton.Console.exe",
					BotClass = "BotManager.Manager.HaxtonBot"
				});
				OfSupportedBots._instances.Add("PokeMobBot", new SupportedBotInformation
				{
					Name = "PokeMobBot",
					DownloadUrl = "https://github.com/chancity/BotManagerBots/raw/master/Bots/PokeMobBot/Release.zip",
					WorkingDirectory = "PokeMobBot/Release",
					ZipName = "PokeMobBot.zip",
					UnZipDirectory = "PokeMobBot",
					ExecutablePath = "PokeMobBot/Release/PokeMobBot.exe",
					BotClass = "BotManager.Manager.PokeMobBot"
				});
				OfSupportedBots._instances.Add("NecroBot", new SupportedBotInformation
				{
					Name = "NecroBot",
					DownloadUrl = "https://github.com/chancity/BotManagerBots/raw/master/Bots/NecroBot/Release.zip",
					WorkingDirectory = "NecroBot/Release",
					ZipName = "NecroBot.zip",
					UnZipDirectory = "NecroBot",
					ExecutablePath = "NecroBot/Release/NecroBot.exe",
					BotClass = "BotManager.Manager.NecroBot"
				});
				instances = OfSupportedBots._instances;
			}
			else
			{
				instances = OfSupportedBots._instances;
			}
			return instances;
		}
	}
}
