namespace Ryuk.Net
{
	// Token: 0x02000007 RID: 7
	public partial class extensions : global::System.Windows.Forms.Form
	{
		// Token: 0x06000098 RID: 152 RVA: 0x000080F8 File Offset: 0x000062F8
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00008130 File Offset: 0x00006330
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Ryuk.Net.extensions));
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.label1 = new global::System.Windows.Forms.Label();
			this.button1 = new global::System.Windows.Forms.Button();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this._CloseButton = new global::CustomWindowsForm.ButtonZ();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this._CloseButton);
			this.panel1.Location = new global::System.Drawing.Point(3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(644, 575);
			this.panel1.TabIndex = 2;
			this.panel1.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
			this.panel1.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
			this.panel1.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(25, 20);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(504, 20);
			this.label1.TabIndex = 4;
			this.label1.Text = "Add your extensions like this    \".docx\",\".txt\",\".jpg\",\".png\",\".xls\"";
			this.button1.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.button1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.button1.Location = new global::System.Drawing.Point(90, 528);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(427, 34);
			this.button1.TabIndex = 3;
			this.button1.Text = "SAVE";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.textBox1.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.textBox1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.textBox1.ForeColor = global::System.Drawing.Color.White;
			this.textBox1.Location = new global::System.Drawing.Point(19, 52);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(609, 459);
			this.textBox1.TabIndex = 2;
			this.textBox1.Text = componentResourceManager.GetString("textBox1.Text");
			this._CloseButton.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this._CloseButton.BZBackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this._CloseButton.DisplayText = "X";
			this._CloseButton.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this._CloseButton.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this._CloseButton.ForeColor = global::System.Drawing.Color.White;
			this._CloseButton.Location = new global::System.Drawing.Point(613, 3);
			this._CloseButton.MouseClickColor1 = global::System.Drawing.Color.FromArgb(60, 60, 160);
			this._CloseButton.MouseHoverColor = global::System.Drawing.Color.FromArgb(50, 50, 50);
			this._CloseButton.Name = "_CloseButton";
			this._CloseButton.Size = new global::System.Drawing.Size(31, 24);
			this._CloseButton.TabIndex = 1;
			this._CloseButton.Text = "X";
			this._CloseButton.TextLocation_X = 6;
			this._CloseButton.TextLocation_Y = 1;
			this._CloseButton.UseVisualStyleBackColor = true;
			this._CloseButton.Click += new global::System.EventHandler(this._CloseButton_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			base.ClientSize = new global::System.Drawing.Size(659, 589);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "extensions";
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "extensions";
			base.Load += new global::System.EventHandler(this.extensions_Load);
			base.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.extensions_MouseDown);
			base.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.extensions_MouseMove);
			base.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.extensions_MouseUp);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000059 RID: 89
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400005A RID: 90
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400005B RID: 91
		private global::CustomWindowsForm.ButtonZ _CloseButton;

		// Token: 0x0400005C RID: 92
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x0400005D RID: 93
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400005E RID: 94
		private global::System.Windows.Forms.Label label1;
	}
}
