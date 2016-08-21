using BotManager.Helpers;
using BotManager.My;
using BotManager.Properties;
using BotManager.Windows;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Timers;
using System.Windows.Forms;

namespace BotManager.Manager
{
	public abstract class Generic : IDisposable
	{
		public bool IsSelected;

		public static int PanelHandle;

		public string Level;

		private bool _hasRan;

		public string ExperiencePerHour;

		public string PokeStopsPerHour;

		public BotInformation BotInformation;

		protected string ExecutablePath;

		private Process _p;

		private readonly System.Timers.Timer _timer;

		private DateTime _startTime;

		public int ProcessId
		{
			get
			{
				int result;
				if (this.IsRunning)
				{
					result = this._p.Id;
				}
				else
				{
					result = 0;
				}
				return result;
			}
		}

		public IntPtr Handle
		{
			get
			{
				IntPtr result;
				if (this.IsRunning)
				{
					result = this._p.MainWindowHandle;
				}
				else
				{
					result = 0;
				}
				return result;
			}
		}

		public bool IsRunning
		{
			get
			{
				return this._p != null && !this._p.HasExited;
			}
		}

		public abstract void WriteSettings();

		public Generic(ref BotInformation botInformation)
		{
			this.IsSelected = false;
			this.Level = "";
			this._hasRan = false;
			this.ExperiencePerHour = "";
			this.ExecutablePath = "";
			this._timer = new System.Timers.Timer(500.0);
			this._startTime = DateTime.MinValue;
			this.BotInformation = botInformation;
			this._timer.Stop();
			this._timer.Elapsed += new ElapsedEventHandler(this.HandleTimer);
		}

		protected bool Initialize()
		{
			bool result;
			if (File.Exists(this.ExecutablePath))
			{
				this.BotInformation.TempExecutablePath = IO.CopyFolder(Path.GetDirectoryName(this.ExecutablePath)) + "\\" + Path.GetFileName(this.ExecutablePath);
				result = true;
			}
			else
			{
				Interaction.MsgBox("Path doesn't Exists", MsgBoxStyle.OkOnly, null);
				MySettingsProperty.Settings.ListOfPropertiesBots.Items.Remove(this.BotInformation);
				result = false;
			}
			return result;
		}

		public void Start()
		{
			if (!this._hasRan)
			{
				this.Initialize();
				this._hasRan = true;
			}
			this.WriteSettings();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WorkingDirectory = Path.GetDirectoryName(this.BotInformation.TempExecutablePath);
			processStartInfo.FileName = Path.GetFileName(this.BotInformation.TempExecutablePath);
			processStartInfo.WindowStyle = ProcessWindowStyle.Maximized;
			Process p = CmdLine.Run(ref processStartInfo);
			this._p = null;
			this._p = p;
			while (this.IsRunning && !Api.GetChildWindows((IntPtr)Generic.PanelHandle).Contains(this.Handle))
			{
				this.PutConsoleInPanel(this.Handle);
			}
			if (this.IsRunning)
			{
				Api.SendMessage(this.Handle, 256, (IntPtr)13, (IntPtr)0);
			}
			this._timer.Start();
		}

		private void PutConsoleInPanel(IntPtr pHandle)
		{
			Api.SetParent(pHandle, (IntPtr)Generic.PanelHandle);
			if (this.IsSelected)
			{
				Api.ShowWindow(pHandle, 5);
				Api.SetWindowPos(pHandle, (IntPtr)1, 0, 0, Control.FromHandle((IntPtr)Generic.PanelHandle).Width, Control.FromHandle((IntPtr)Generic.PanelHandle).Height, 0);
			}
			else
			{
				Api.ShowWindow(pHandle, 0);
			}
		}

		public void Kill(bool delete = true)
		{
			if (this.IsRunning)
			{
				this._timer.Stop();
				if (!this._p.HasExited)
				{
					this._p.Kill();
				}
				this._startTime = DateTime.MinValue;
			}
			if (delete)
			{
				string directoryName = Path.GetDirectoryName(this.BotInformation.TempExecutablePath);
				while (Conversions.ToBoolean(Operators.NotObject(IO.DirectoryIsEmpty(directoryName))))
				{
					IO.DeleteFilesFromFolder(directoryName);
				}
				this._hasRan = false;
			}
		}

		private void HandleTimer(object sender, EventArgs e)
		{
			if (this._p.HasExited)
			{
				this.Start();
			}
			if (this.BotInformation.RestartTimer > 0)
			{
				if (DateTime.Compare(this._startTime, DateTime.MinValue) == 0)
				{
					this._startTime = DateAndTime.Now;
				}
				if (DateTime.Compare(DateAndTime.Now, this._startTime.AddMinutes((double)this.BotInformation.RestartTimer)) >= 0)
				{
					this.Kill(false);
					this.Start();
					this._startTime = DateAndTime.Now;
				}
			}
		}

		public void Dispose()
		{
			if (this.IsRunning)
			{
				this.Kill(true);
			}
			this._hasRan = false;
			this.IsSelected = false;
			this.ExecutablePath = null;
			if (this._p != null)
			{
				this._p.Dispose();
			}
			if (this._timer != null)
			{
				this._timer.Dispose();
			}
			this._startTime = DateTime.MinValue;
		}
	}
}
