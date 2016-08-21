using BotManager.List;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace BotManager.My
{
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), CompilerGenerated]
	internal sealed class MySettings : ApplicationSettingsBase
	{
		private static MySettings defaultInstance = (MySettings)SettingsBase.Synchronized(new MySettings());

		private static bool addedHandler;

		private static object addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new object());

		public static MySettings Default
		{
			get
			{
				if (!MySettings.addedHandler)
				{
					object obj = MySettings.addedHandlerLockObject;
					ObjectFlowControl.CheckForSyncLockOnValueType(obj);
					lock (obj)
					{
						if (!MySettings.addedHandler)
						{
							MyProject.Application.Shutdown += new ShutdownEventHandler(MySettings.AutoSaveSettings);
							MySettings.addedHandler = true;
						}
					}
				}
				return MySettings.defaultInstance;
			}
		}

		[DefaultSettingValue(""), UserScopedSetting, DebuggerNonUserCode]
		public string Textbox
		{
			get
			{
				return Conversions.ToString(this["Textbox"]);
			}
			set
			{
				this["Textbox"] = value;
			}
		}

		[UserScopedSetting, DebuggerNonUserCode]
		public OfPropertiesBots ListOfPropertiesBots
		{
			get
			{
				return (OfPropertiesBots)this["ListOfPropertiesBots"];
			}
			set
			{
				this["ListOfPropertiesBots"] = value;
			}
		}

		[DefaultSettingValue("True"), UserScopedSetting, DebuggerNonUserCode]
		public bool AutoUpdate
		{
			get
			{
				return Conversions.ToBoolean(this["AutoUpdate"]);
			}
			set
			{
				this["AutoUpdate"] = value;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Advanced), DebuggerNonUserCode]
		private static void AutoSaveSettings(object sender, EventArgs e)
		{
			if (MyProject.Application.SaveMySettingsOnExit)
			{
				MySettingsProperty.Settings.Save();
			}
		}
	}
}
