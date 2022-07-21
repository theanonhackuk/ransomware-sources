namespace BlueWorm
{
	// Token: 0x02000010 RID: 16
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Form3 : global::System.Windows.Forms.Form
	{
		// Token: 0x060000D0 RID: 208 RVA: 0x00007700 File Offset: 0x00005900
		[global::System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.icontainer_0 != null)
				{
					this.icontainer_0.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00007744 File Offset: 0x00005944
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.TextBox1 = new global::System.Windows.Forms.TextBox();
			this.SuspendLayout();
			this.Label1.AutoSize = true;
			global::System.Windows.Forms.Control label = this.Label1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(2, 15);
			label.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control label2 = this.Label1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(26, 13);
			label2.Size = size;
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Port";
			this.Button1.BackColor = global::System.Drawing.Color.Black;
			this.Button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			global::System.Windows.Forms.Control button = this.Button1;
			location = new global::System.Drawing.Point(114, 38);
			button.Location = location;
			this.Button1.Name = "Button1";
			global::System.Windows.Forms.Control button2 = this.Button1;
			size = new global::System.Drawing.Size(75, 23);
			button2.Size = size;
			this.Button1.TabIndex = 1;
			this.Button1.Text = "Listen";
			this.Button1.UseVisualStyleBackColor = false;
			global::System.Windows.Forms.Control textBox = this.TextBox1;
			location = new global::System.Drawing.Point(34, 12);
			textBox.Location = location;
			this.TextBox1.Name = "TextBox1";
			global::System.Windows.Forms.Control textBox2 = this.TextBox1;
			size = new global::System.Drawing.Size(155, 20);
			textBox2.Size = size;
			this.TextBox1.TabIndex = 2;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(25, 25, 25);
			size = new global::System.Drawing.Size(196, 66);
			this.ClientSize = size;
			this.Controls.Add(this.TextBox1);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.Label1);
			this.ForeColor = global::System.Drawing.Color.Lime;
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form3";
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form3";
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x0400004D RID: 77
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}
