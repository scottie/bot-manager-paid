using BotManager.List;
using BotManager.Properties;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;

namespace BotManager.Manager
{
	public class NecroBot : Generic
	{
		public NecroBot(ref BotInformation botInformation) : base(ref botInformation)
		{
			this.ExecutablePath = OfSupportedBots.GetInstance()["NecroBot"].ExecutablePath;
		}

		public override void WriteSettings()
		{
			StreamReader streamReader = new StreamReader(Path.GetDirectoryName(this.BotInformation.TempExecutablePath) + "\\Config\\config.json");
			string json = streamReader.ReadToEnd();
			streamReader.Dispose();
			StreamReader streamReader2 = new StreamReader(Path.GetDirectoryName(this.BotInformation.TempExecutablePath) + "\\Config\\auth.json");
			string json2 = streamReader2.ReadToEnd();
			streamReader2.Dispose();
			JObject jObject = JObject.Parse(json);
			JObject jObject2 = JObject.Parse(json2);
			try
			{
				List<string>.Enumerator enumerator = this.BotInformation.SettingKeys.GetEnumerator();
				while (enumerator.MoveNext())
				{
					string current = enumerator.Current;
					if (current.Equals("AuthType") || current.Equals("GoogleUsername") || current.Equals("GooglePassword") || current.Equals("PtcUsername") || current.Equals("PtcPassword"))
					{
						jObject2[current] = this.BotInformation.GetSettingValue(current).ToString();
					}
					else if (current.Equals("AutoUpdate"))
					{
						jObject[current] = "false";
					}
					else
					{
						jObject[current] = this.BotInformation.GetSettingValue(current).ToString();
					}
				}
			}
			finally
			{
				List<string>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			using (StreamWriter streamWriter = new StreamWriter(Path.GetDirectoryName(this.BotInformation.TempExecutablePath) + "\\Config\\auth.json"))
			{
				streamWriter.Write(jObject2.ToString());
			}
			using (StreamWriter streamWriter2 = new StreamWriter(Path.GetDirectoryName(this.BotInformation.TempExecutablePath) + "\\Config\\config.json"))
			{
				streamWriter2.Write(jObject.ToString());
			}
		}

		public static void ReadSettings(ref SupportedBotInformation supportedBotInformation)
		{
			string json = new StreamReader(Path.GetDirectoryName(supportedBotInformation.ExecutablePath) + "\\Config\\config.json").ReadToEnd();
			string json2 = new StreamReader(Path.GetDirectoryName(supportedBotInformation.ExecutablePath) + "\\Config\\auth.json").ReadToEnd();
			JObject jObject = JObject.Parse(json);
			JObject jObject2 = JObject.Parse(json2);
			try
			{
				IEnumerator<JToken> enumerator = jObject2.Children().GetEnumerator();
				while (enumerator.MoveNext())
				{
					JProperty jProperty = (JProperty)enumerator.Current;
					if (jProperty.Value.GetType().ToString().Contains("Newtonsoft.Json.Linq.JValue"))
					{
						supportedBotInformation.AddKeyValue(jProperty.Name, jProperty.Value.ToString());
					}
				}
			}
			finally
			{
				IEnumerator<JToken> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			try
			{
				IEnumerator<JToken> enumerator2 = jObject.Children().GetEnumerator();
				while (enumerator2.MoveNext())
				{
					JProperty jProperty2 = (JProperty)enumerator2.Current;
					if (jProperty2.Value.GetType().ToString().Contains("Newtonsoft.Json.Linq.JValue"))
					{
						supportedBotInformation.AddKeyValue(jProperty2.Name, jProperty2.Value.ToString());
					}
				}
			}
			finally
			{
				IEnumerator<JToken> enumerator2;
				if (enumerator2 != null)
				{
					enumerator2.Dispose();
				}
			}
		}
	}
}
