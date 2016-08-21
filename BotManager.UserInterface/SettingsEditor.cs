using BotManager.Interfaces;
using BotManager.List;
using BotManager.Properties;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace BotManager.UserInterface
{
	[DesignerGenerated]
	public class SettingsEditor : Form
	{
		private IContainer components;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("DataGridView1"), CompilerGenerated]
		private DataGridView _DataGridView1;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("btnSave"), CompilerGenerated]
		private Button _btnSave;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("btnCancel"), CompilerGenerated]
		private Button _btnCancel;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("restartLabel"), CompilerGenerated]
		private Label _restartLabel;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("txtRestartTimer"), CompilerGenerated]
		private TextBox _txtRestartTimer;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("minutesLabel"), CompilerGenerated]
		private Label _minutesLabel;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("chkBatchAdd"), CompilerGenerated]
		private CheckBox _chkBatchAdd;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("fileLoc"), CompilerGenerated]
		private TextBox _fileLoc;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("chkHide"), CompilerGenerated]
		private CheckBox _chkHide;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("browseBtn"), CompilerGenerated]
		private Button _browseBtn;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("batchSettingsGroup"), CompilerGenerated]
		private GroupBox _batchSettingsGroup;

		private readonly BotInformation _botProperties;

		public List<BotInformation> BatchAddProperties;

		internal virtual DataGridView DataGridView1
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button btnSave
		{
			[CompilerGenerated]
			get
			{
				return this._btnSave;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnSave_Click);
				Button btnSave = this._btnSave;
				if (btnSave != null)
				{
					btnSave.Click -= value2;
				}
				this._btnSave = value;
				btnSave = this._btnSave;
				if (btnSave != null)
				{
					btnSave.Click += value2;
				}
			}
		}

		internal virtual Button btnCancel
		{
			[CompilerGenerated]
			get
			{
				return this._btnCancel;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnCancel_Click);
				Button btnCancel = this._btnCancel;
				if (btnCancel != null)
				{
					btnCancel.Click -= value2;
				}
				this._btnCancel = value;
				btnCancel = this._btnCancel;
				if (btnCancel != null)
				{
					btnCancel.Click += value2;
				}
			}
		}

		internal virtual Label restartLabel
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox txtRestartTimer
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label minutesLabel
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual CheckBox chkBatchAdd
		{
			[CompilerGenerated]
			get
			{
				return this._chkBatchAdd;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.chkBatchAdd_CheckedChanged);
				CheckBox chkBatchAdd = this._chkBatchAdd;
				if (chkBatchAdd != null)
				{
					chkBatchAdd.CheckedChanged -= value2;
				}
				this._chkBatchAdd = value;
				chkBatchAdd = this._chkBatchAdd;
				if (chkBatchAdd != null)
				{
					chkBatchAdd.CheckedChanged += value2;
				}
			}
		}

		internal virtual TextBox fileLoc
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual CheckBox chkHide
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button browseBtn
		{
			[CompilerGenerated]
			get
			{
				return this._browseBtn;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.browseBtn_Click);
				Button browseBtn = this._browseBtn;
				if (browseBtn != null)
				{
					browseBtn.Click -= value2;
				}
				this._browseBtn = value;
				browseBtn = this._browseBtn;
				if (browseBtn != null)
				{
					browseBtn.Click += value2;
				}
			}
		}

		internal virtual GroupBox batchSettingsGroup
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
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
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			this.DataGridView1 = new DataGridView();
			this.btnSave = new Button();
			this.btnCancel = new Button();
			this.restartLabel = new Label();
			this.txtRestartTimer = new TextBox();
			this.minutesLabel = new Label();
			this.chkBatchAdd = new CheckBox();
			this.fileLoc = new TextBox();
			this.chkHide = new CheckBox();
			this.browseBtn = new Button();
			this.batchSettingsGroup = new GroupBox();
			((ISupportInitialize)this.DataGridView1).BeginInit();
			this.batchSettingsGroup.SuspendLayout();
			base.SuspendLayout();
			this.DataGridView1.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = SystemColors.Control;
			dataGridViewCellStyle.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
			this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = SystemColors.Window;
			dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
			this.DataGridView1.Location = new Point(12, 90);
			this.DataGridView1.Name = "DataGridView1";
			this.DataGridView1.Size = new Size(384, 259);
			this.DataGridView1.TabIndex = 0;
			this.btnSave.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.btnSave.Location = new Point(331, 355);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new Size(65, 23);
			this.btnSave.TabIndex = 1;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnCancel.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.btnCancel.Location = new Point(253, 355);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new Size(72, 23);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.restartLabel.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.restartLabel.AutoSize = true;
			this.restartLabel.Location = new Point(12, 359);
			this.restartLabel.Name = "restartLabel";
			this.restartLabel.Size = new Size(73, 13);
			this.restartLabel.TabIndex = 3;
			this.restartLabel.Text = "Restart every:";
			this.txtRestartTimer.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.txtRestartTimer.Location = new Point(91, 357);
			this.txtRestartTimer.Name = "txtRestartTimer";
			this.txtRestartTimer.Size = new Size(52, 20);
			this.txtRestartTimer.TabIndex = 4;
			this.txtRestartTimer.Text = "30";
			this.minutesLabel.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.minutesLabel.AutoSize = true;
			this.minutesLabel.Location = new Point(149, 359);
			this.minutesLabel.Name = "minutesLabel";
			this.minutesLabel.Size = new Size(43, 13);
			this.minutesLabel.TabIndex = 5;
			this.minutesLabel.Text = "minutes";
			this.chkBatchAdd.AutoSize = true;
			this.chkBatchAdd.Location = new Point(5, 18);
			this.chkBatchAdd.Margin = new Padding(2);
			this.chkBatchAdd.Name = "chkBatchAdd";
			this.chkBatchAdd.Size = new Size(76, 17);
			this.chkBatchAdd.TabIndex = 6;
			this.chkBatchAdd.Text = "Batch Add";
			this.chkBatchAdd.UseVisualStyleBackColor = true;
			this.fileLoc.Enabled = false;
			this.fileLoc.Location = new Point(85, 15);
			this.fileLoc.Margin = new Padding(2);
			this.fileLoc.Name = "fileLoc";
			this.fileLoc.Size = new Size(294, 20);
			this.fileLoc.TabIndex = 7;
			this.fileLoc.Text = "File Path";
			this.chkHide.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.chkHide.AutoSize = true;
			this.chkHide.Location = new Point(197, 358);
			this.chkHide.Margin = new Padding(2);
			this.chkHide.Name = "chkHide";
			this.chkHide.Size = new Size(51, 17);
			this.chkHide.TabIndex = 8;
			this.chkHide.Text = "Hide!";
			this.chkHide.UseVisualStyleBackColor = true;
			this.browseBtn.Enabled = false;
			this.browseBtn.Location = new Point(3, 40);
			this.browseBtn.Name = "browseBtn";
			this.browseBtn.Size = new Size(376, 23);
			this.browseBtn.TabIndex = 9;
			this.browseBtn.Text = "Browse";
			this.browseBtn.UseVisualStyleBackColor = true;
			this.batchSettingsGroup.Controls.Add(this.chkBatchAdd);
			this.batchSettingsGroup.Controls.Add(this.browseBtn);
			this.batchSettingsGroup.Controls.Add(this.fileLoc);
			this.batchSettingsGroup.Location = new Point(12, 12);
			this.batchSettingsGroup.Name = "batchSettingsGroup";
			this.batchSettingsGroup.Size = new Size(384, 72);
			this.batchSettingsGroup.TabIndex = 10;
			this.batchSettingsGroup.TabStop = false;
			this.batchSettingsGroup.Text = "Batch Import";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(408, 390);
			base.Controls.Add(this.batchSettingsGroup);
			base.Controls.Add(this.chkHide);
			base.Controls.Add(this.minutesLabel);
			base.Controls.Add(this.txtRestartTimer);
			base.Controls.Add(this.restartLabel);
			base.Controls.Add(this.btnCancel);
			base.Controls.Add(this.btnSave);
			base.Controls.Add(this.DataGridView1);
			this.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
			base.Name = "SettingsEditor";
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Settings Editor";
			((ISupportInitialize)this.DataGridView1).EndInit();
			this.batchSettingsGroup.ResumeLayout(false);
			this.batchSettingsGroup.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		public SettingsEditor(ref BotInformation botProperties)
		{
			base.Load += new EventHandler(this.SettingsEditor_Load);
			this.InitializeComponent();
			this._botProperties = botProperties;
		}

		private void SettingsEditor_Load(object sender, EventArgs e)
		{
			if (this._botProperties.SettingValues.Count > 0)
			{
				this.AddToGridView(this._botProperties);
			}
			else
			{
				string botClass = this._botProperties.BotClass;
				if (Operators.CompareString(botClass, "BotManager.Manager.HaxtonBot", false) != 0)
				{
					if (Operators.CompareString(botClass, "BotManager.Manager.SpegeliBot", false) != 0)
					{
						if (Operators.CompareString(botClass, "BotManager.Manager.NecroBot", false) != 0)
						{
							if (Operators.CompareString(botClass, "BotManager.Manager.PokeMobBot", false) == 0)
							{
								this.AddToGridView(OfSupportedBots.GetInstance()["PokeMobBot"]);
							}
						}
						else
						{
							this.AddToGridView(OfSupportedBots.GetInstance()["NecroBot"]);
						}
					}
					else
					{
						this.AddToGridView(OfSupportedBots.GetInstance()["SpegeliBot"]);
					}
				}
				else
				{
					this.AddToGridView(OfSupportedBots.GetInstance()["HaxtonBot"]);
				}
			}
		}

		private void AddToGridView(ISettings supportedBotInformation)
		{
			DataTable dataTable = new DataTable();
			dataTable.Columns.Add("Name");
			dataTable.Columns.Add("Value");
			checked
			{
				int num = supportedBotInformation.SettingKeys.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					dataTable.Rows.Add(new object[]
					{
						supportedBotInformation.SettingKeys[i],
						supportedBotInformation.SettingValues[i]
					});
					this._botProperties.AddKeyValue(supportedBotInformation.SettingKeys[i], supportedBotInformation.SettingValues[i]);
				}
				this.txtRestartTimer.Text = Conversions.ToString(this._botProperties.RestartTimer);
				this.chkHide.Checked = this._botProperties.Hide;
				this.DataGridView1.DataSource = dataTable;
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			this.BatchAddProperties = new List<BotInformation>();
			checked
			{
				int num = this.DataGridView1.Rows.Count - 2;
				for (int i = 0; i <= num; i++)
				{
					this._botProperties.SettingValues[i] = this.DataGridView1.Rows[i].Cells[1].Value.ToString();
				}
				if (!int.TryParse(this.txtRestartTimer.Text, out this._botProperties.RestartTimer))
				{
					this._botProperties.RestartTimer = 0;
				}
				this._botProperties.Hide = this.chkHide.Checked;
				if (this.chkBatchAdd.Checked)
				{
					string text = "";
					string text2 = Conversions.ToString(0);
					string text3 = "";
					try
					{
						StreamReader streamReader = new StreamReader(this.fileLoc.Text);
						string[] array = streamReader.ReadToEnd().Trim().Split(new char[]
						{
							'\r'
						});
						streamReader.Dispose();
						int num2 = array.Length - 1;
						for (int j = 0; j <= num2; j++)
						{
							text2 = array[j];
							text = Conversions.ToString(j);
							BotInformation botInformation = new BotInformation();
							botInformation.Hide = this._botProperties.Hide;
							botInformation.RestartTimer = this._botProperties.RestartTimer;
							botInformation.BotClass = this._botProperties.BotClass;
							int num3 = this._botProperties.SettingKeys.Count - 1;
							for (int k = 0; k <= num3; k++)
							{
								botInformation.AddKeyValue(this._botProperties.SettingKeys[k], this._botProperties.SettingValues[k]);
							}
							string[] array2 = text2.Trim(new char[]
							{
								'\n'
							}).Split(new char[]
							{
								','
							});
							if (array2.Length != 0)
							{
								string[] array3 = array2;
								for (int l = 0; l < array3.Length; l++)
								{
									string text4 = array3[l];
									string text5 = text4.Split(new char[]
									{
										':'
									})[0];
									string text6 = text4.Split(new char[]
									{
										':'
									})[1];
									if (Operators.CompareString(text5, "", false) != 0 && Operators.CompareString(text6, "", false) != 0)
									{
										text3 = text5;
										int index = botInformation.SettingKeys.IndexOf(text5);
										botInformation.SettingValues[index] = text6;
									}
								}
								this.BatchAddProperties.Add(botInformation);
							}
						}
						goto IL_2EC;
					}
					catch (Exception expr_295)
					{
						ProjectData.SetProjectError(expr_295);
						Exception ex = expr_295;
						Interaction.MsgBox(string.Concat(new string[]
						{
							ex.Message,
							"\r\n\r\nLine Index: ",
							text,
							"\r\nField: ",
							text3
						}), MsgBoxStyle.OkOnly, null);
						ProjectData.ClearProjectError();
						return;
					}
				}
				this.BatchAddProperties.Add(this._botProperties);
				IL_2EC:
				base.DialogResult = DialogResult.OK;
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
		}

		private void chkBatchAdd_CheckedChanged(object sender, EventArgs e)
		{
			this.browseBtn.Enabled = this.chkBatchAdd.Checked;
			this.fileLoc.Enabled = this.chkBatchAdd.Checked;
		}

		private void browseBtn_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					this.fileLoc.Text = openFileDialog.FileName;
				}
			}
		}
	}
}
