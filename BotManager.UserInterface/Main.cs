using BotManager.List;
using BotManager.Manager;
using BotManager.My;
using BotManager.Properties;
using BotManager.Windows;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BotManager.UserInterface
{
	[DesignerGenerated]
	public class Main : Form
	{
		[CompilerGenerated]
		internal sealed class _Closure$__27-0
		{
			public bool $VB$Local_delete;

			public Main $VB$Me;

			public _Closure$__27-0(Main._Closure$__27-0 arg0)
			{
				if (arg0 != null)
				{
					this.$VB$Local_delete = arg0.$VB$Local_delete;
				}
			}

			internal void _Lambda$__0()
			{
				try
				{
					IEnumerator enumerator = this.$VB$Me._bots.GetEnumerator();
					while (enumerator.MoveNext())
					{
						Generic generic = (Generic)enumerator.Current;
						if (generic.IsRunning)
						{
							generic.Kill(this.$VB$Local_delete);
						}
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

		[CompilerGenerated]
		internal sealed class _Closure$__28-0
		{
			public string $VB$Local_commandLine;

			internal bool _Lambda$__0(Generic bot)
			{
				return this.$VB$Local_commandLine.Contains(bot.ProcessId.ToString());
			}
		}

		private readonly ManagementObjectSearcher _processSearcher;

		private readonly ArrayList _bots;

		private IContainer components;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("btnAdd"), CompilerGenerated]
		private Button _btnAdd;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("btnRemove"), CompilerGenerated]
		private Button _btnRemove;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("btnEdit"), CompilerGenerated]
		private Button _btnEdit;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("botSelectBox"), CompilerGenerated]
		private ComboBox _botSelectBox;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("btnRestart"), CompilerGenerated]
		private Button _btnRestart;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("repLabel"), CompilerGenerated]
		private LinkLabel _repLabel;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("btnStop"), CompilerGenerated]
		private Button _btnStop;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("Timer"), CompilerGenerated]
		private Timer _Timer;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("botTree"), CompilerGenerated]
		private TreeView _botTree;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("botPanel"), CompilerGenerated]
		private Panel _botPanel;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("BackgroundWorker"), CompilerGenerated]
		private BackgroundWorker _BackgroundWorker;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("botsContainer"), CompilerGenerated]
		private SplitContainer _botsContainer;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("btnStopAll"), CompilerGenerated]
		private Button _btnStopAll;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("btnRestartAll"), CompilerGenerated]
		private Button _btnRestartAll;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("selectedOptionsGroup"), CompilerGenerated]
		private GroupBox _selectedOptionsGroup;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("batchOptionsGroup"), CompilerGenerated]
		private GroupBox _batchOptionsGroup;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("donationGroup"), CompilerGenerated]
		private GroupBox _donationGroup;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("paypalLabel"), CompilerGenerated]
		private LinkLabel _paypalLabel;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox1"), CompilerGenerated]
		private GroupBox _GroupBox1;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("statusStrip"), CompilerGenerated]
		private StatusStrip _statusStrip;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("statusLabel"), CompilerGenerated]
		private ToolStripStatusLabel _statusLabel;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox2"), CompilerGenerated]
		private GroupBox _GroupBox2;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("showPokemon"), CompilerGenerated]
		private CheckBox _showPokemon;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("showExp"), CompilerGenerated]
		private CheckBox _showExp;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("showLvl"), CompilerGenerated]
		private CheckBox _showLvl;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("btnStartAll"), CompilerGenerated]
		private Button _btnStartAll;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("btnRemoveAll"), CompilerGenerated]
		private Button _btnRemoveAll;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("stripMenu"), CompilerGenerated]
		private MenuStrip _stripMenu;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("stripSettings"), CompilerGenerated]
		private ToolStripMenuItem _stripSettings;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("stripForceUpdate"), CompilerGenerated]
		private ToolStripMenuItem _stripForceUpdate;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("stripAutoUpdate"), CompilerGenerated]
		private ToolStripMenuItem _stripAutoUpdate;

		internal virtual Button btnAdd
		{
			[CompilerGenerated]
			get
			{
				return this._btnAdd;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnAdd_Click);
				Button btnAdd = this._btnAdd;
				if (btnAdd != null)
				{
					btnAdd.Click -= value2;
				}
				this._btnAdd = value;
				btnAdd = this._btnAdd;
				if (btnAdd != null)
				{
					btnAdd.Click += value2;
				}
			}
		}

		internal virtual Button btnRemove
		{
			[CompilerGenerated]
			get
			{
				return this._btnRemove;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnRemove_Click);
				Button btnRemove = this._btnRemove;
				if (btnRemove != null)
				{
					btnRemove.Click -= value2;
				}
				this._btnRemove = value;
				btnRemove = this._btnRemove;
				if (btnRemove != null)
				{
					btnRemove.Click += value2;
				}
			}
		}

		internal virtual Button btnEdit
		{
			[CompilerGenerated]
			get
			{
				return this._btnEdit;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnEdit_Click);
				Button btnEdit = this._btnEdit;
				if (btnEdit != null)
				{
					btnEdit.Click -= value2;
				}
				this._btnEdit = value;
				btnEdit = this._btnEdit;
				if (btnEdit != null)
				{
					btnEdit.Click += value2;
				}
			}
		}

		internal virtual ComboBox botSelectBox
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button btnRestart
		{
			[CompilerGenerated]
			get
			{
				return this._btnRestart;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnRestart_Click);
				Button btnRestart = this._btnRestart;
				if (btnRestart != null)
				{
					btnRestart.Click -= value2;
				}
				this._btnRestart = value;
				btnRestart = this._btnRestart;
				if (btnRestart != null)
				{
					btnRestart.Click += value2;
				}
			}
		}

		internal virtual LinkLabel repLabel
		{
			[CompilerGenerated]
			get
			{
				return this._repLabel;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				LinkLabelLinkClickedEventHandler value2 = new LinkLabelLinkClickedEventHandler(this.repLabel_LinkClicked);
				LinkLabel repLabel = this._repLabel;
				if (repLabel != null)
				{
					repLabel.LinkClicked -= value2;
				}
				this._repLabel = value;
				repLabel = this._repLabel;
				if (repLabel != null)
				{
					repLabel.LinkClicked += value2;
				}
			}
		}

		internal virtual Button btnStop
		{
			[CompilerGenerated]
			get
			{
				return this._btnStop;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnStop_Click);
				Button btnStop = this._btnStop;
				if (btnStop != null)
				{
					btnStop.Click -= value2;
				}
				this._btnStop = value;
				btnStop = this._btnStop;
				if (btnStop != null)
				{
					btnStop.Click += value2;
				}
			}
		}

		internal virtual Timer Timer
		{
			[CompilerGenerated]
			get
			{
				return this._Timer;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer1_Tick);
				Timer timer = this._Timer;
				if (timer != null)
				{
					timer.Tick -= value2;
				}
				this._Timer = value;
				timer = this._Timer;
				if (timer != null)
				{
					timer.Tick += value2;
				}
			}
		}

		internal virtual TreeView botTree
		{
			[CompilerGenerated]
			get
			{
				return this._botTree;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				TreeViewEventHandler value2 = new TreeViewEventHandler(this.botTree_AfterSelect);
				TreeViewCancelEventHandler value3 = new TreeViewCancelEventHandler(this.botTree_BeforeSelect);
				TreeView botTree = this._botTree;
				if (botTree != null)
				{
					botTree.AfterSelect -= value2;
					botTree.BeforeSelect -= value3;
				}
				this._botTree = value;
				botTree = this._botTree;
				if (botTree != null)
				{
					botTree.AfterSelect += value2;
					botTree.BeforeSelect += value3;
				}
			}
		}

		internal virtual Panel botPanel
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual BackgroundWorker BackgroundWorker
		{
			[CompilerGenerated]
			get
			{
				return this._BackgroundWorker;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DoWorkEventHandler value2 = new DoWorkEventHandler(this.BackgroundWorker_DoWork);
				RunWorkerCompletedEventHandler value3 = new RunWorkerCompletedEventHandler(this.BackgroundWorker_Complete);
				BackgroundWorker backgroundWorker = this._BackgroundWorker;
				if (backgroundWorker != null)
				{
					backgroundWorker.DoWork -= value2;
					backgroundWorker.RunWorkerCompleted -= value3;
				}
				this._BackgroundWorker = value;
				backgroundWorker = this._BackgroundWorker;
				if (backgroundWorker != null)
				{
					backgroundWorker.DoWork += value2;
					backgroundWorker.RunWorkerCompleted += value3;
				}
			}
		}

		internal virtual SplitContainer botsContainer
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button btnStopAll
		{
			[CompilerGenerated]
			get
			{
				return this._btnStopAll;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnStopAll_Click);
				Button btnStopAll = this._btnStopAll;
				if (btnStopAll != null)
				{
					btnStopAll.Click -= value2;
				}
				this._btnStopAll = value;
				btnStopAll = this._btnStopAll;
				if (btnStopAll != null)
				{
					btnStopAll.Click += value2;
				}
			}
		}

		internal virtual Button btnRestartAll
		{
			[CompilerGenerated]
			get
			{
				return this._btnRestartAll;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnRestartAll_Click);
				Button btnRestartAll = this._btnRestartAll;
				if (btnRestartAll != null)
				{
					btnRestartAll.Click -= value2;
				}
				this._btnRestartAll = value;
				btnRestartAll = this._btnRestartAll;
				if (btnRestartAll != null)
				{
					btnRestartAll.Click += value2;
				}
			}
		}

		internal virtual GroupBox selectedOptionsGroup
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual GroupBox batchOptionsGroup
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual GroupBox donationGroup
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual LinkLabel paypalLabel
		{
			[CompilerGenerated]
			get
			{
				return this._paypalLabel;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				LinkLabelLinkClickedEventHandler value2 = new LinkLabelLinkClickedEventHandler(this.paypalLabel_LinkClicked_1);
				LinkLabel paypalLabel = this._paypalLabel;
				if (paypalLabel != null)
				{
					paypalLabel.LinkClicked -= value2;
				}
				this._paypalLabel = value;
				paypalLabel = this._paypalLabel;
				if (paypalLabel != null)
				{
					paypalLabel.LinkClicked += value2;
				}
			}
		}

		internal virtual GroupBox GroupBox1
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual StatusStrip statusStrip
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ToolStripStatusLabel statusLabel
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual GroupBox GroupBox2
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual CheckBox showPokemon
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual CheckBox showExp
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual CheckBox showLvl
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button btnStartAll
		{
			[CompilerGenerated]
			get
			{
				return this._btnStartAll;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnStartAll_Click);
				Button btnStartAll = this._btnStartAll;
				if (btnStartAll != null)
				{
					btnStartAll.Click -= value2;
				}
				this._btnStartAll = value;
				btnStartAll = this._btnStartAll;
				if (btnStartAll != null)
				{
					btnStartAll.Click += value2;
				}
			}
		}

		internal virtual Button btnRemoveAll
		{
			[CompilerGenerated]
			get
			{
				return this._btnRemoveAll;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnRemoveAll_Click);
				Button btnRemoveAll = this._btnRemoveAll;
				if (btnRemoveAll != null)
				{
					btnRemoveAll.Click -= value2;
				}
				this._btnRemoveAll = value;
				btnRemoveAll = this._btnRemoveAll;
				if (btnRemoveAll != null)
				{
					btnRemoveAll.Click += value2;
				}
			}
		}

		internal virtual MenuStrip stripMenu
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ToolStripMenuItem stripSettings
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ToolStripMenuItem stripForceUpdate
		{
			[CompilerGenerated]
			get
			{
				return this._stripForceUpdate;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.StripForceUpdate_click);
				ToolStripMenuItem stripForceUpdate = this._stripForceUpdate;
				if (stripForceUpdate != null)
				{
					stripForceUpdate.Click -= value2;
				}
				this._stripForceUpdate = value;
				stripForceUpdate = this._stripForceUpdate;
				if (stripForceUpdate != null)
				{
					stripForceUpdate.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem stripAutoUpdate
		{
			[CompilerGenerated]
			get
			{
				return this._stripAutoUpdate;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.stripAutoUpdate_Click);
				ToolStripMenuItem stripAutoUpdate = this._stripAutoUpdate;
				if (stripAutoUpdate != null)
				{
					stripAutoUpdate.Click -= value2;
				}
				this._stripAutoUpdate = value;
				stripAutoUpdate = this._stripAutoUpdate;
				if (stripAutoUpdate != null)
				{
					stripAutoUpdate.Click += value2;
				}
			}
		}

		public Main()
		{
			base.Load += new EventHandler(this.Main_Load);
			base.ResizeEnd += new EventHandler(this.Main_Resize);
			base.Shown += new EventHandler(this.Main_HasLoad);
			base.Closed += new EventHandler(this.Main_Closed);
			this._processSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_Process WHERE Name='WerFault.exe'");
			this._bots = new ArrayList();
			this.InitializeComponent();
		}

		private void Main_Load(object sender, EventArgs e)
		{
			try
			{
				try
				{
					Dictionary<string, SupportedBotInformation>.ValueCollection.Enumerator enumerator = OfSupportedBots.GetInstance().Values.GetEnumerator();
					while (enumerator.MoveNext())
					{
						SupportedBotInformation current = enumerator.Current;
						if (current.DisplayAsBot)
						{
							this.botSelectBox.Items.Add(current.Name);
							this.botSelectBox.SelectedItem = RuntimeHelpers.GetObjectValue(this.botSelectBox.Items[0]);
						}
					}
				}
				finally
				{
					Dictionary<string, SupportedBotInformation>.ValueCollection.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			catch (Exception expr_7A)
			{
				ProjectData.SetProjectError(expr_7A);
				Exception ex = expr_7A;
				Interaction.MsgBox("Error at load " + ex.Message, MsgBoxStyle.OkOnly, null);
				ProjectData.ClearProjectError();
			}
			base.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
		}

		public static void SetDoubleBuffered(Control c)
		{
			if (!SystemInformation.TerminalServerSession)
			{
				PropertyInfo property = typeof(Control).GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
				property.SetValue(c, true, null);
			}
		}

		private void Main_Resize(object sender, EventArgs e)
		{
			this.ResizeCmd();
		}

		private void Main_HasLoad(object sender, EventArgs e)
		{
			Generic.PanelHandle = (int)this.botPanel.Handle;
			if (MySettingsProperty.Settings.ListOfPropertiesBots == null)
			{
				MySettingsProperty.Settings.ListOfPropertiesBots = new OfPropertiesBots();
			}
			else
			{
				try
				{
					List<BotInformation>.Enumerator enumerator = MySettingsProperty.Settings.ListOfPropertiesBots.Items.GetEnumerator();
					while (enumerator.MoveNext())
					{
						BotInformation current = enumerator.Current;
						this.CreateTreeNode(ref current);
					}
				}
				finally
				{
					List<BotInformation>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
		}

		private void Main_Closed(object sender, EventArgs e)
		{
			Task task = Task.Run(delegate
			{
				try
				{
					IEnumerator enumerator = this._bots.GetEnumerator();
					while (enumerator.MoveNext())
					{
						Generic generic = (Generic)enumerator.Current;
						generic.Dispose();
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
			});
			task.Wait();
			MySettingsProperty.Settings.Save();
		}

		private void CreateTreeNode(ref BotInformation botInformation)
		{
			TreeNode treeNode = new TreeNode();
			string settingValue = botInformation.GetSettingValue("PtcUsername");
			if (settingValue.ToLower().Contains("username"))
			{
				settingValue = botInformation.GetSettingValue("GoogleEmail");
			}
			if (Operators.CompareString(settingValue, "", false) == 0)
			{
				settingValue = botInformation.GetSettingValue("GoogleUsername");
			}
			treeNode.Name = settingValue;
			treeNode.Text = settingValue;
			Generic bot = BotFactory.GetBot(ref botInformation);
			this._bots.Add(bot);
			treeNode.Tag = bot;
			this.botTree.Nodes.Add(treeNode);
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			BotInformation botInformation = new BotInformation();
			if (Operators.CompareString(this.botSelectBox.Text, "HaxtonBot", false) == 0)
			{
				botInformation.BotClass = "BotManager.Manager.HaxtonBot";
			}
			else if (Operators.CompareString(this.botSelectBox.Text, "SpegeliBot", false) == 0)
			{
				botInformation.BotClass = "BotManager.Manager.SpegeliBot";
			}
			else if (Operators.CompareString(this.botSelectBox.Text, "NecroBot", false) == 0)
			{
				botInformation.BotClass = "BotManager.Manager.NecroBot";
			}
			else
			{
				if (Operators.CompareString(this.botSelectBox.Text, "PokeMobBot", false) != 0)
				{
					botInformation = null;
					Interaction.MsgBox("Select bot type", MsgBoxStyle.OkOnly, null);
					return;
				}
				botInformation.BotClass = "BotManager.Manager.PokeMobBot";
			}
			SettingsEditor settingsEditor = new SettingsEditor(ref botInformation);
			if (settingsEditor.ShowDialog() == DialogResult.OK)
			{
				try
				{
					List<BotInformation>.Enumerator enumerator = settingsEditor.BatchAddProperties.GetEnumerator();
					while (enumerator.MoveNext())
					{
						BotInformation current = enumerator.Current;
						MySettingsProperty.Settings.ListOfPropertiesBots.Items.Add(current);
						this.CreateTreeNode(ref current);
					}
				}
				finally
				{
					List<BotInformation>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				this.StartAllBots();
			}
			settingsEditor.Dispose();
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			if (this.botTree.SelectedNode != null)
			{
				Generic generic = (Generic)this.botTree.SelectedNode.Tag;
				SettingsEditor settingsEditor = new SettingsEditor(ref generic.BotInformation);
				if (settingsEditor.ShowDialog() == DialogResult.OK)
				{
					string settingValue = generic.BotInformation.GetSettingValue("PtcUsername");
					if (settingValue.ToLower().Contains("username"))
					{
						settingValue = generic.BotInformation.GetSettingValue("GoogleEmail");
					}
					if (Operators.CompareString(settingValue, "", false) == 0)
					{
						settingValue = generic.BotInformation.GetSettingValue("GoogleUsername");
					}
					this.botTree.SelectedNode.Name = settingValue;
					this.botTree.SelectedNode.Text = settingValue;
					generic.Kill(false);
					generic.Start();
				}
			}
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			if (this.botTree.SelectedNode != null)
			{
				Generic generic = (Generic)this.botTree.SelectedNode.Tag;
				this._bots.Remove(generic);
				generic.Dispose();
				MySettingsProperty.Settings.ListOfPropertiesBots.Items.Remove(generic.BotInformation);
				this.botTree.Nodes.Remove(this.botTree.SelectedNode);
			}
		}

		private void btnRestart_Click(object sender, EventArgs e)
		{
			if (this.botTree.SelectedNode != null)
			{
				Generic generic = (Generic)this.botTree.SelectedNode.Tag;
				if (generic.IsRunning)
				{
					generic.Kill(false);
				}
				generic.Start();
			}
		}

		private void btnStop_Click(object sender, EventArgs e)
		{
			if (this.botTree.SelectedNode != null)
			{
				Generic generic = (Generic)this.botTree.SelectedNode.Tag;
				if (generic.IsRunning)
				{
					generic.Kill(false);
				}
			}
		}

		private void btnRestartAll_Click(object sender, EventArgs e)
		{
			this.KillAllBots(false);
			this.StartAllBots();
		}

		private void btnStopAll_Click(object sender, EventArgs e)
		{
			this.KillAllBots(false);
		}

		private void repLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.repLabel.LinkVisited = true;
			Process.Start("http://www.ownedcore.com/forums/pokemon-go/pokemon-go-hacks-cheats/568064-bot-manager-spegeli-necro-haxton-all-one-multi-account-1000-a.html");
		}

		private void paypalLabel_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.repLabel.LinkVisited = true;
			Process.Start("https://www.paypal.me/chancity");
		}

		private void Timer1_Tick(object sender, EventArgs e)
		{
			if (!this.BackgroundWorker.IsBusy)
			{
				this.BackgroundWorker.RunWorkerAsync();
			}
		}

		private void botTree_AfterSelect(object sender, TreeViewEventArgs e)
		{
			if (e.Node.IsSelected)
			{
				Generic generic = (Generic)e.Node.Tag;
				Api.ShowWindow(generic.Handle, 5);
				Api.SetWindowPos(generic.Handle, (IntPtr)1, 0, 0, this.botPanel.Width, this.botPanel.Height, 0);
				generic.IsSelected = true;
			}
		}

		private void botTree_BeforeSelect(object sender, TreeViewCancelEventArgs e)
		{
			if (this.botTree.SelectedNode == null)
			{
				Generic generic = (Generic)e.Node.Tag;
				Api.ShowWindow(generic.Handle, 5);
				Api.SetWindowPos(generic.Handle, (IntPtr)1, 0, 0, this.botPanel.Width, this.botPanel.Height, 0);
			}
			else
			{
				Generic generic2 = (Generic)this.botTree.SelectedNode.Tag;
				Api.ShowWindow(generic2.Handle, 0);
				generic2.IsSelected = false;
			}
		}

		private void TimerTask()
		{
			try
			{
				ManagementObjectCollection.ManagementObjectEnumerator enumerator = this._processSearcher.Get().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ManagementObject managementObject = (ManagementObject)enumerator.Current;
					if (Conversions.ToBoolean(this.ContainsProcess(managementObject["CommandLine"].ToString())))
					{
						managementObject.InvokeMethod("Terminate", null);
					}
				}
			}
			finally
			{
				ManagementObjectCollection.ManagementObjectEnumerator enumerator;
				if (enumerator != null)
				{
					((IDisposable)enumerator).Dispose();
				}
			}
		}

		private string StatusUpdate()
		{
			double num = 0.0;
			StringBuilder stringBuilder = new StringBuilder(256);
			try
			{
				IEnumerator enumerator = this._bots.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Generic generic = (Generic)enumerator.Current;
					if (generic.IsRunning)
					{
						stringBuilder.Clear();
						Api.GetWindowTextA(generic.Handle, stringBuilder, stringBuilder.Capacity);
						string[] array = stringBuilder.ToString().Split(new char[]
						{
							'|'
						});
						if (array.Length >= 2)
						{
							object value;
							if (Operators.CompareString(generic.BotInformation.BotClass, "BotManager.Manager.HaxtonBot", false) == 0)
							{
								value = array[1].Split(new char[]
								{
									'-'
								})[2];
							}
							else if (Operators.CompareString(generic.BotInformation.BotClass, "BotManager.Manager.SpegeliBot", false) == 0)
							{
								value = array[0].Split(new char[]
								{
									'('
								})[0].Split(new char[]
								{
									'-'
								})[2];
							}
							else if (Operators.CompareString(generic.BotInformation.BotClass, "BotManager.Manager.NecroBot", false) == 0)
							{
								value = array[0].Split(new char[]
								{
									'-'
								})[2].Split(new char[]
								{
									'('
								})[0];
							}
							else if (Operators.CompareString(generic.BotInformation.BotClass, "BotManager.Manager.PokeMobBot", false) == 0)
							{
								value = array[0].Split(new char[]
								{
									'-'
								})[2].Split(new char[]
								{
									'('
								})[0];
							}
							generic.Level = Conversions.ToString(value);
							generic.ExperiencePerHour = array[2];
							generic.PokeStopsPerHour = array[3];
							num += Conversions.ToDouble(array[2].Split(new char[]
							{
								':'
							})[1].Trim());
						}
					}
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
			return string.Format("Total Bots: {0}, Average EXP: {1}, Total EXP: {2}", this.botTree.Nodes.Count, num / (double)this.botTree.Nodes.Count, num);
		}

		private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			this.TimerTask();
			e.Result = this.StatusUpdate();
		}

		private void BackgroundWorker_Complete(object sender, RunWorkerCompletedEventArgs e)
		{
			try
			{
				IEnumerator enumerator = this.botTree.Nodes.GetEnumerator();
				while (enumerator.MoveNext())
				{
					TreeNode treeNode = (TreeNode)enumerator.Current;
					Generic generic = (Generic)treeNode.Tag;
					treeNode.Text = treeNode.Name;
					if (this.showLvl.Checked)
					{
						TreeNode treeNode2;
						(treeNode2 = treeNode).Text = treeNode2.Text + " - " + generic.Level;
					}
					if (this.showExp.Checked)
					{
						TreeNode treeNode2;
						(treeNode2 = treeNode).Text = treeNode2.Text + " - " + generic.ExperiencePerHour;
					}
					if (this.showPokemon.Checked)
					{
						TreeNode treeNode2;
						(treeNode2 = treeNode).Text = treeNode2.Text + " - " + generic.PokeStopsPerHour;
					}
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
			this.statusLabel.Text = e.Result.ToString();
		}

		private void ResizeCmd()
		{
			if (this.botTree.SelectedNode != null)
			{
				Generic generic = (Generic)this.botTree.SelectedNode.Tag;
				Api.SetWindowPos(generic.Handle, (IntPtr)1, 0, 0, this.botPanel.Width, this.botPanel.Height, 0);
			}
		}

		private void StartAllBots()
		{
			Task.Run(delegate
			{
				try
				{
					IEnumerator enumerator = this._bots.GetEnumerator();
					while (enumerator.MoveNext())
					{
						Generic generic = (Generic)enumerator.Current;
						if (!generic.IsRunning)
						{
							generic.Start();
						}
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
			});
		}

		private void KillAllBots(bool delete = false)
		{
			Main._Closure$__27-0 closure$__27- = new Main._Closure$__27-0(closure$__27-);
			closure$__27-.$VB$Me = this;
			closure$__27-.$VB$Local_delete = delete;
			Task task = Task.Run(delegate
			{
				try
				{
					IEnumerator enumerator = closure$__27-.$VB$Me._bots.GetEnumerator();
					while (enumerator.MoveNext())
					{
						Generic generic = (Generic)enumerator.Current;
						if (generic.IsRunning)
						{
							generic.Kill(closure$__27-.$VB$Local_delete);
						}
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
			});
			task.Wait();
		}

		private object ContainsProcess(string commandLine)
		{
			return this._bots.Cast<Generic>().Any((Generic bot) => commandLine.Contains(bot.ProcessId.ToString()));
		}

		private void btnStartAll_Click(object sender, EventArgs e)
		{
			this.StartAllBots();
		}

		private void btnRemoveAll_Click(object sender, EventArgs e)
		{
			this.botTree.Nodes.Clear();
			this.KillAllBots(true);
			this._bots.Clear();
			MySettingsProperty.Settings.ListOfPropertiesBots = new OfPropertiesBots();
			MySettingsProperty.Settings.Save();
		}

		private void StripForceUpdate_click(object sender, EventArgs e)
		{
			Downloading downloading = new Downloading();
			downloading.ForceUpdate = true;
			downloading.ShowDialog();
			downloading.Dispose();
		}

		private void stripAutoUpdate_Click(object sender, EventArgs e)
		{
			MySettingsProperty.Settings.AutoUpdate = this.stripAutoUpdate.Checked;
			MySettingsProperty.Settings.Save();
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
			this.components = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Main));
			this.btnAdd = new Button();
			this.btnRemove = new Button();
			this.btnEdit = new Button();
			this.botSelectBox = new ComboBox();
			this.btnRestart = new Button();
			this.repLabel = new LinkLabel();
			this.btnStop = new Button();
			this.Timer = new Timer(this.components);
			this.botTree = new TreeView();
			this.botPanel = new Panel();
			this.BackgroundWorker = new BackgroundWorker();
			this.botsContainer = new SplitContainer();
			this.btnStopAll = new Button();
			this.btnRestartAll = new Button();
			this.selectedOptionsGroup = new GroupBox();
			this.batchOptionsGroup = new GroupBox();
			this.btnRemoveAll = new Button();
			this.btnStartAll = new Button();
			this.donationGroup = new GroupBox();
			this.paypalLabel = new LinkLabel();
			this.GroupBox1 = new GroupBox();
			this.statusStrip = new StatusStrip();
			this.statusLabel = new ToolStripStatusLabel();
			this.GroupBox2 = new GroupBox();
			this.showPokemon = new CheckBox();
			this.showExp = new CheckBox();
			this.showLvl = new CheckBox();
			this.stripMenu = new MenuStrip();
			this.stripSettings = new ToolStripMenuItem();
			this.stripAutoUpdate = new ToolStripMenuItem();
			this.stripForceUpdate = new ToolStripMenuItem();
			((ISupportInitialize)this.botsContainer).BeginInit();
			this.botsContainer.Panel1.SuspendLayout();
			this.botsContainer.Panel2.SuspendLayout();
			this.botsContainer.SuspendLayout();
			this.selectedOptionsGroup.SuspendLayout();
			this.batchOptionsGroup.SuspendLayout();
			this.donationGroup.SuspendLayout();
			this.GroupBox1.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			this.stripMenu.SuspendLayout();
			base.SuspendLayout();
			this.btnAdd.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.btnAdd.Location = new Point(160, 19);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new Size(65, 25);
			this.btnAdd.TabIndex = 4;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnRemove.Location = new Point(219, 19);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new Size(65, 25);
			this.btnRemove.TabIndex = 6;
			this.btnRemove.Text = "Remove";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnEdit.Location = new Point(6, 19);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new Size(65, 25);
			this.btnEdit.TabIndex = 7;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.botSelectBox.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.botSelectBox.DisplayMember = "1";
			this.botSelectBox.FormattingEnabled = true;
			this.botSelectBox.Location = new Point(18, 22);
			this.botSelectBox.Name = "botSelectBox";
			this.botSelectBox.Size = new Size(136, 21);
			this.botSelectBox.TabIndex = 10;
			this.btnRestart.Location = new Point(148, 19);
			this.btnRestart.Name = "btnRestart";
			this.btnRestart.Size = new Size(65, 25);
			this.btnRestart.TabIndex = 11;
			this.btnRestart.Text = "Restart";
			this.btnRestart.UseVisualStyleBackColor = true;
			this.repLabel.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.repLabel.AutoSize = true;
			this.repLabel.Location = new Point(6, 25);
			this.repLabel.Name = "repLabel";
			this.repLabel.Size = new Size(35, 13);
			this.repLabel.TabIndex = 12;
			this.repLabel.TabStop = true;
			this.repLabel.Text = "Help?";
			this.btnStop.Location = new Point(77, 19);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new Size(65, 25);
			this.btnStop.TabIndex = 15;
			this.btnStop.Text = "Stop";
			this.btnStop.UseVisualStyleBackColor = true;
			this.Timer.Enabled = true;
			this.Timer.Interval = 500;
			this.botTree.Dock = DockStyle.Fill;
			this.botTree.Location = new Point(0, 0);
			this.botTree.Margin = new Padding(2);
			this.botTree.Name = "botTree";
			this.botTree.ShowLines = false;
			this.botTree.ShowPlusMinus = false;
			this.botTree.ShowRootLines = false;
			this.botTree.Size = new Size(228, 622);
			this.botTree.TabIndex = 16;
			this.botPanel.AutoSize = true;
			this.botPanel.BackColor = Color.Black;
			this.botPanel.Dock = DockStyle.Fill;
			this.botPanel.Location = new Point(0, 0);
			this.botPanel.Margin = new Padding(0);
			this.botPanel.Name = "botPanel";
			this.botPanel.Size = new Size(1077, 622);
			this.botPanel.TabIndex = 17;
			this.botsContainer.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.botsContainer.Location = new Point(12, 86);
			this.botsContainer.Margin = new Padding(2);
			this.botsContainer.Name = "botsContainer";
			this.botsContainer.Panel1.Controls.Add(this.botTree);
			this.botsContainer.Panel2.Controls.Add(this.botPanel);
			this.botsContainer.Panel2MinSize = 0;
			this.botsContainer.Size = new Size(1308, 622);
			this.botsContainer.SplitterDistance = 228;
			this.botsContainer.SplitterWidth = 3;
			this.botsContainer.TabIndex = 18;
			this.btnStopAll.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.btnStopAll.Location = new Point(77, 19);
			this.btnStopAll.Name = "btnStopAll";
			this.btnStopAll.Size = new Size(65, 25);
			this.btnStopAll.TabIndex = 20;
			this.btnStopAll.Text = "Stop";
			this.btnStopAll.UseVisualStyleBackColor = true;
			this.btnRestartAll.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.btnRestartAll.Location = new Point(148, 19);
			this.btnRestartAll.Name = "btnRestartAll";
			this.btnRestartAll.Size = new Size(65, 25);
			this.btnRestartAll.TabIndex = 21;
			this.btnRestartAll.Text = "Restart";
			this.btnRestartAll.UseVisualStyleBackColor = true;
			this.selectedOptionsGroup.Controls.Add(this.btnEdit);
			this.selectedOptionsGroup.Controls.Add(this.btnStop);
			this.selectedOptionsGroup.Controls.Add(this.btnRestart);
			this.selectedOptionsGroup.Controls.Add(this.btnRemove);
			this.selectedOptionsGroup.Location = new Point(12, 27);
			this.selectedOptionsGroup.Name = "selectedOptionsGroup";
			this.selectedOptionsGroup.Size = new Size(293, 54);
			this.selectedOptionsGroup.TabIndex = 22;
			this.selectedOptionsGroup.TabStop = false;
			this.selectedOptionsGroup.Text = "Selected Bot Operations";
			this.batchOptionsGroup.Controls.Add(this.btnRemoveAll);
			this.batchOptionsGroup.Controls.Add(this.btnStartAll);
			this.batchOptionsGroup.Controls.Add(this.btnStopAll);
			this.batchOptionsGroup.Controls.Add(this.btnRestartAll);
			this.batchOptionsGroup.Location = new Point(311, 27);
			this.batchOptionsGroup.Name = "batchOptionsGroup";
			this.batchOptionsGroup.Size = new Size(299, 54);
			this.batchOptionsGroup.TabIndex = 23;
			this.batchOptionsGroup.TabStop = false;
			this.batchOptionsGroup.Text = "Batch Operations";
			this.btnRemoveAll.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.btnRemoveAll.Location = new Point(219, 19);
			this.btnRemoveAll.Name = "btnRemoveAll";
			this.btnRemoveAll.Size = new Size(65, 25);
			this.btnRemoveAll.TabIndex = 23;
			this.btnRemoveAll.Text = "Remove";
			this.btnRemoveAll.UseVisualStyleBackColor = true;
			this.btnStartAll.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.btnStartAll.Location = new Point(6, 19);
			this.btnStartAll.Name = "btnStartAll";
			this.btnStartAll.Size = new Size(65, 25);
			this.btnStartAll.TabIndex = 22;
			this.btnStartAll.Text = "Start";
			this.btnStartAll.UseVisualStyleBackColor = true;
			this.donationGroup.Controls.Add(this.paypalLabel);
			this.donationGroup.Controls.Add(this.repLabel);
			this.donationGroup.Location = new Point(1054, 27);
			this.donationGroup.Name = "donationGroup";
			this.donationGroup.Size = new Size(155, 54);
			this.donationGroup.TabIndex = 24;
			this.donationGroup.TabStop = false;
			this.donationGroup.Text = "Help Developer";
			this.paypalLabel.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.paypalLabel.AutoSize = true;
			this.paypalLabel.Location = new Point(51, 25);
			this.paypalLabel.Name = "paypalLabel";
			this.paypalLabel.Size = new Size(95, 13);
			this.paypalLabel.TabIndex = 13;
			this.paypalLabel.TabStop = true;
			this.paypalLabel.Text = "Donate via PayPal";
			this.GroupBox1.Controls.Add(this.btnAdd);
			this.GroupBox1.Controls.Add(this.botSelectBox);
			this.GroupBox1.Location = new Point(616, 27);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new Size(241, 54);
			this.GroupBox1.TabIndex = 22;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Add Bot(s)";
			this.statusStrip.Items.AddRange(new ToolStripItem[]
			{
				this.statusLabel
			});
			this.statusStrip.Location = new Point(0, 717);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new Size(1331, 22);
			this.statusStrip.TabIndex = 25;
			this.statusStrip.Text = "StatusStrip1";
			this.statusLabel.Name = "statusLabel";
			this.statusLabel.Size = new Size(0, 17);
			this.GroupBox2.Controls.Add(this.showPokemon);
			this.GroupBox2.Controls.Add(this.showExp);
			this.GroupBox2.Controls.Add(this.showLvl);
			this.GroupBox2.Location = new Point(863, 27);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new Size(185, 54);
			this.GroupBox2.TabIndex = 26;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "Info to show";
			this.showPokemon.AutoSize = true;
			this.showPokemon.Location = new Point(131, 23);
			this.showPokemon.Name = "showPokemon";
			this.showPokemon.Size = new Size(46, 17);
			this.showPokemon.TabIndex = 2;
			this.showPokemon.Text = "P/H";
			this.showPokemon.UseVisualStyleBackColor = true;
			this.showExp.AutoSize = true;
			this.showExp.Location = new Point(57, 23);
			this.showExp.Name = "showExp";
			this.showExp.Size = new Size(68, 17);
			this.showExp.TabIndex = 1;
			this.showExp.Text = "EXP/HR";
			this.showExp.UseVisualStyleBackColor = true;
			this.showLvl.AutoSize = true;
			this.showLvl.Location = new Point(6, 24);
			this.showLvl.Name = "showLvl";
			this.showLvl.Size = new Size(45, 17);
			this.showLvl.TabIndex = 0;
			this.showLvl.Text = "LVL";
			this.showLvl.UseVisualStyleBackColor = true;
			this.stripMenu.Items.AddRange(new ToolStripItem[]
			{
				this.stripSettings
			});
			this.stripMenu.Location = new Point(0, 0);
			this.stripMenu.Name = "stripMenu";
			this.stripMenu.Size = new Size(1331, 24);
			this.stripMenu.TabIndex = 27;
			this.stripMenu.Text = "MenuStrip1";
			this.stripSettings.Checked = true;
			this.stripSettings.CheckOnClick = true;
			this.stripSettings.CheckState = CheckState.Checked;
			this.stripSettings.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.stripAutoUpdate,
				this.stripForceUpdate
			});
			this.stripSettings.Name = "stripSettings";
			this.stripSettings.Size = new Size(61, 20);
			this.stripSettings.Text = "Settings";
			this.stripAutoUpdate.Checked = true;
			this.stripAutoUpdate.CheckOnClick = true;
			this.stripAutoUpdate.CheckState = CheckState.Checked;
			this.stripAutoUpdate.Name = "stripAutoUpdate";
			this.stripAutoUpdate.Size = new Size(152, 22);
			this.stripAutoUpdate.Text = "AutoUpdate";
			this.stripForceUpdate.Name = "stripForceUpdate";
			this.stripForceUpdate.Size = new Size(152, 22);
			this.stripForceUpdate.Text = "Force Update";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = SystemColors.Control;
			base.ClientSize = new Size(1331, 739);
			base.Controls.Add(this.GroupBox2);
			base.Controls.Add(this.statusStrip);
			base.Controls.Add(this.stripMenu);
			base.Controls.Add(this.GroupBox1);
			base.Controls.Add(this.donationGroup);
			base.Controls.Add(this.batchOptionsGroup);
			base.Controls.Add(this.botsContainer);
			base.Controls.Add(this.selectedOptionsGroup);
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.MainMenuStrip = this.stripMenu;
			base.Name = "Main";
			this.Text = "Pokemon Go Bot Manager";
			this.botsContainer.Panel1.ResumeLayout(false);
			this.botsContainer.Panel2.ResumeLayout(false);
			this.botsContainer.Panel2.PerformLayout();
			((ISupportInitialize)this.botsContainer).EndInit();
			this.botsContainer.ResumeLayout(false);
			this.selectedOptionsGroup.ResumeLayout(false);
			this.batchOptionsGroup.ResumeLayout(false);
			this.donationGroup.ResumeLayout(false);
			this.donationGroup.PerformLayout();
			this.GroupBox1.ResumeLayout(false);
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox2.PerformLayout();
			this.stripMenu.ResumeLayout(false);
			this.stripMenu.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		[CompilerGenerated]
		private void _Lambda$__7-0()
		{
			try
			{
				IEnumerator enumerator = this._bots.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Generic generic = (Generic)enumerator.Current;
					generic.Dispose();
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

		[CompilerGenerated]
		private void _Lambda$__26-0()
		{
			try
			{
				IEnumerator enumerator = this._bots.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Generic generic = (Generic)enumerator.Current;
					if (!generic.IsRunning)
					{
						generic.Start();
					}
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
