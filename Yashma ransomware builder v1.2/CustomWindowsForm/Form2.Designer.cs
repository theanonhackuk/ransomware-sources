namespace CustomWindowsForm
{
	// Token: 0x02000008 RID: 8
	public partial class Form2 : global::System.Windows.Forms.Form
	{
		// Token: 0x060000A0 RID: 160 RVA: 0x000087A0 File Offset: 0x000069A0
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x000087D8 File Offset: 0x000069D8
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::CustomWindowsForm.Form2));
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.textBox2 = new global::System.Windows.Forms.TextBox();
			this.label4 = new global::System.Windows.Forms.Label();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.buttonZ1 = new global::CustomWindowsForm.ButtonZ();
			this._CloseButton = new global::CustomWindowsForm.ButtonZ();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.panel1.Controls.Add(this.textBox2);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.buttonZ1);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this._CloseButton);
			this.panel1.Location = new global::System.Drawing.Point(1, 1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(387, 389);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.panel1.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
			this.panel1.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
			this.panel1.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
			this.textBox2.Location = new global::System.Drawing.Point(109, 319);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new global::System.Drawing.Size(251, 20);
			this.textBox2.TabIndex = 12;
			this.textBox2.Text = "44wJKzwrzWY7dxLov4EjVia3wmwaj6ige6a8C6eHKXKtVy8PTU3SnCG6A6do3vL4Cu3kLUedKwjomDKe754QhshVJw52xFV";
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.ForeColor = global::System.Drawing.Color.White;
			this.label4.Location = new global::System.Drawing.Point(37, 320);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(71, 20);
			this.label4.TabIndex = 11;
			this.label4.Text = "Monero: ";
			this.label4.TextAlign = global::System.Drawing.ContentAlignment.TopCenter;
			this.textBox1.Location = new global::System.Drawing.Point(109, 284);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(251, 20);
			this.textBox1.TabIndex = 10;
			this.textBox1.Text = "bc1qlnzcep4l4ac0ttdrq7awxev9ehu465f2vpt9x0";
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.Color.White;
			this.label3.Location = new global::System.Drawing.Point(37, 285);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(65, 20);
			this.label3.TabIndex = 8;
			this.label3.Text = "Bitcoin: ";
			this.label3.TextAlign = global::System.Drawing.ContentAlignment.TopCenter;
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.Color.White;
			this.label2.Location = new global::System.Drawing.Point(11, 8);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(52, 20);
			this.label2.TabIndex = 7;
			this.label2.Text = "About";
			this.label2.TextAlign = global::System.Drawing.ContentAlignment.TopCenter;
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(3, 46);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(392, 220);
			this.label1.TabIndex = 6;
			this.label1.Text = componentResourceManager.GetString("label1.Text");
			this.label1.TextAlign = global::System.Drawing.ContentAlignment.TopCenter;
			this.buttonZ1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.buttonZ1.BZBackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.buttonZ1.DisplayText = "X";
			this.buttonZ1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonZ1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.buttonZ1.ForeColor = global::System.Drawing.Color.White;
			this.buttonZ1.Location = new global::System.Drawing.Point(347, 8);
			this.buttonZ1.MouseClickColor1 = global::System.Drawing.Color.FromArgb(60, 60, 160);
			this.buttonZ1.MouseHoverColor = global::System.Drawing.Color.FromArgb(50, 50, 50);
			this.buttonZ1.Name = "buttonZ1";
			this.buttonZ1.Size = new global::System.Drawing.Size(31, 24);
			this.buttonZ1.TabIndex = 9;
			this.buttonZ1.Text = "X";
			this.buttonZ1.TextLocation_X = 6;
			this.buttonZ1.TextLocation_Y = 1;
			this.buttonZ1.UseVisualStyleBackColor = true;
			this.buttonZ1.Click += new global::System.EventHandler(this.buttonZ1_Click);
			this._CloseButton.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this._CloseButton.BZBackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this._CloseButton.DisplayText = "X";
			this._CloseButton.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this._CloseButton.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this._CloseButton.ForeColor = global::System.Drawing.Color.White;
			this._CloseButton.Location = new global::System.Drawing.Point(392, 24);
			this._CloseButton.MouseClickColor1 = global::System.Drawing.Color.FromArgb(60, 60, 160);
			this._CloseButton.MouseHoverColor = global::System.Drawing.Color.FromArgb(50, 50, 50);
			this._CloseButton.Name = "_CloseButton";
			this._CloseButton.Size = new global::System.Drawing.Size(31, 24);
			this._CloseButton.TabIndex = 5;
			this._CloseButton.Text = "X";
			this._CloseButton.TextLocation_X = 6;
			this._CloseButton.TextLocation_Y = 1;
			this._CloseButton.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(25, 25, 25);
			base.ClientSize = new global::System.Drawing.Size(391, 394);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "Form2";
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form2";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000061 RID: 97
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000062 RID: 98
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000063 RID: 99
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000064 RID: 100
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000065 RID: 101
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000066 RID: 102
		private global::CustomWindowsForm.ButtonZ _CloseButton;

		// Token: 0x04000067 RID: 103
		private global::CustomWindowsForm.ButtonZ buttonZ1;

		// Token: 0x04000068 RID: 104
		private global::System.Windows.Forms.TextBox textBox2;

		// Token: 0x04000069 RID: 105
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400006A RID: 106
		private global::System.Windows.Forms.TextBox textBox1;
	}
}
