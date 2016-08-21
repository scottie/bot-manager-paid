using BotManager.Helpers;
using BotManager.List;
using BotManager.Manager;
using BotManager.My;
using BotManager.Properties;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace BotManager.UserInterface
{
	[DesignerGenerated]
	public class Downloading : Form
	{
		private IContainer components;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("downloadProgress"), CompilerGenerated]
		private ProgressBar _downloadProgress;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("BackgroundWorker1"), CompilerGenerated]
		private BackgroundWorker _BackgroundWorker1;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("downloadLabel"), CompilerGenerated]
		private Label _downloadLabel;

		private bool _forceUpdate;

		internal virtual ProgressBar downloadProgress
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual BackgroundWorker BackgroundWorker1
		{
			[CompilerGenerated]
			get
			{
				return this._BackgroundWorker1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DoWorkEventHandler value2 = new DoWorkEventHandler(this.BackgroundWorker1_DoWork);
				ProgressChangedEventHandler value3 = new ProgressChangedEventHandler(this.BackgroundWorker1_ReportProgress);
				RunWorkerCompletedEventHandler value4 = new RunWorkerCompletedEventHandler(this.BackgroundWorker1_RunWorkerCompleted);
				BackgroundWorker backgroundWorker = this._BackgroundWorker1;
				if (backgroundWorker != null)
				{
					backgroundWorker.DoWork -= value2;
					backgroundWorker.ProgressChanged -= value3;
					backgroundWorker.RunWorkerCompleted -= value4;
				}
				this._BackgroundWorker1 = value;
				backgroundWorker = this._BackgroundWorker1;
				if (backgroundWorker != null)
				{
					backgroundWorker.DoWork += value2;
					backgroundWorker.ProgressChanged += value3;
					backgroundWorker.RunWorkerCompleted += value4;
				}
			}
		}

		internal virtual Label downloadLabel
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public bool ForceUpdate
		{
			set
			{
				this._forceUpdate = value;
			}
		}

		public Downloading()
		{
			base.Load += new EventHandler(this.Downloading_Load);
			this._forceUpdate = false;
			this.InitializeComponent();
		}

		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.components != null)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.downloadProgress = new ProgressBar();
			this.BackgroundWorker1 = new BackgroundWorker();
			this.downloadLabel = new Label();
			base.SuspendLayout();
			this.downloadProgress.Location = new Point(11, 30);
			this.downloadProgress.Name = "downloadProgress";
			this.downloadProgress.Size = new Size(258, 16);
			this.downloadProgress.Style = ProgressBarStyle.Marquee;
			this.downloadProgress.TabIndex = 1;
			this.BackgroundWorker1.WorkerReportsProgress = true;
			this.downloadLabel.AutoSize = true;
			this.downloadLabel.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.downloadLabel.Location = new Point(8, 9);
			this.downloadLabel.Name = "downloadLabel";
			this.downloadLabel.Size = new Size(142, 18);
			this.downloadLabel.TabIndex = 0;
			this.downloadLabel.Text = "Get Latest Version ?";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(280, 53);
			base.Controls.Add(this.downloadLabel);
			base.Controls.Add(this.downloadProgress);
			base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
			base.MaximizeBox = false;
			this.MaximumSize = new Size(296, 92);
			base.MinimizeBox = false;
			this.MinimumSize = new Size(296, 69);
			base.Name = "Downloading";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.SizeGripStyle = SizeGripStyle.Hide;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Download Manager";
			base.TopMost = true;
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			try
			{
				Dictionary<string, SupportedBotInformation>.ValueCollection.Enumerator enumerator = OfSupportedBots.GetInstance().Values.GetEnumerator();
				while (enumerator.MoveNext())
				{
					SupportedBotInformation current = enumerator.Current;
					if (Conversions.ToBoolean(Conversions.ToBoolean(e.Argument) || !this.Installed(ref current)))
					{
						this.InstallBot(ref current);
					}
					if (this.Installed(ref current))
					{
						this.AddSettings(ref current);
					}
				}
			}
			finally
			{
				Dictionary<string, SupportedBotInformation>.ValueCollection.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			IO.DeleteFilesFromFolder(IO.AppData);
			this.BackgroundWorker1.ReportProgress(0, "Complete");
			Thread.Sleep(100);
		}

		private void BackgroundWorker1_ReportProgress(object sender, ProgressChangedEventArgs e)
		{
			this.downloadLabel.Text = e.UserState.ToString();
		}

		private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			if (e.Error != null)
			{
				StreamWriter streamWriter = new StreamWriter("error.log");
				streamWriter.Write(e.Error.Message + "\r\n" + e.Error.StackTrace);
				streamWriter.Dispose();
				Process.Start("error.log");
			}
			base.DialogResult = DialogResult.OK;
			MyProject.Forms.Main.Show();
			base.Close();
		}

		private void InstallBot(ref SupportedBotInformation supportedBotInformation)
		{
			this.DeleteOldBot(ref supportedBotInformation);
			this.DownloadBot(ref supportedBotInformation);
			this.UnZipBot(ref supportedBotInformation);
		}

		private void DeleteOldBot(ref SupportedBotInformation supportedBotInformation)
		{
			this.BackgroundWorker1.ReportProgress(1, "Deleting " + supportedBotInformation.Name + "directory");
			IO.DeleteFilesFromFolder(supportedBotInformation.Name);
		}

		private void DownloadBot(ref SupportedBotInformation supportedBotInformation)
		{
			this.BackgroundWorker1.ReportProgress(1, "Downloading " + supportedBotInformation.Name);
			Http.DownloadRepository(supportedBotInformation.DownloadUrl, supportedBotInformation.ZipName);
		}

		private void UnZipBot(ref SupportedBotInformation supportedBotInformation)
		{
			this.BackgroundWorker1.ReportProgress(1, "Unzipping " + supportedBotInformation.Name);
			IO.Unzip(supportedBotInformation.ZipName, supportedBotInformation.UnZipDirectory);
			File.Delete(supportedBotInformation.ZipName);
		}

		private void AddSettings(ref SupportedBotInformation supportedBotInformation)
		{
			this.BackgroundWorker1.ReportProgress(1, "Reading " + supportedBotInformation.Name + "settings");
			if (File.Exists(supportedBotInformation.ExecutablePath))
			{
				string name = supportedBotInformation.Name;
				if (Operators.CompareString(name, "SpegeliBot", false) != 0)
				{
					if (Operators.CompareString(name, "HaxtonBot", false) != 0)
					{
						if (Operators.CompareString(name, "NecroBot", false) != 0)
						{
							if (Operators.CompareString(name, "PokeMobBot", false) == 0)
							{
								PokeMobBot.ReadSettings(ref supportedBotInformation);
							}
						}
						else
						{
							NecroBot.ReadSettings(ref supportedBotInformation);
						}
					}
					else
					{
						HaxtonBot.ReadSettings(ref supportedBotInformation);
					}
				}
				else
				{
					SpegeliBot.ReadSettings(ref supportedBotInformation);
				}
			}
		}

		private void Downloading_Load(object sender, EventArgs e)
		{
			MyProject.Forms.Main.Hide();
			if (File.Exists("BotManager.exe.old"))
			{
				File.Delete("BotManager.exe.old");
			}
			if (MySettingsProperty.Settings.AutoUpdate)
			{
				this.CheckForUpdates();
			}
			this.BackgroundWorker1.RunWorkerAsync(this._forceUpdate);
		}

		[MethodImpl(MethodImplOptions.NoOptimization)]
		private void CheckForUpdates()
		{
			string text = "";
			try
			{
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://raw.githubusercontent.com/chancity/BotManagerBots/master/VERSION");
				httpWebRequest.Proxy = null;
				httpWebRequest.UserAgent = "Pokemon";
				HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				Stream responseStream = httpWebResponse.GetResponseStream();
				StreamReader streamReader = new StreamReader(responseStream);
				string text2 = streamReader.ReadToEnd();
				streamReader.Close();
				text = text2.ToString().Trim();
			}
			catch (Exception expr_62)
			{
				ProjectData.SetProjectError(expr_62);
				ProjectData.ClearProjectError();
			}
			if (Operators.CompareString(text, "", false) != 0 && Operators.CompareString(Application.ProductVersion, text, false) != 0)
			{
				DialogResult dialogResult = MessageBox.Show("Program has been updated! Would you like to update now?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
				if (dialogResult == DialogResult.Yes)
				{
					MyProject.Computer.FileSystem.RenameFile("BotManager.exe", "BotManager.exe.old");
					Http.DownloadRepository("https://github.com/chancity/BotManagerBots/raw/master/Download/BotManager.exe", "BotManager.exe");
					Process.Start("BotManager.exe");
					ProjectData.EndApp();
				}
			}
		}

		private bool Installed(ref SupportedBotInformation supportedBotInformation)
		{
			return File.Exists(supportedBotInformation.ExecutablePath);
		}
	}
}
