namespace BlueWorm
{
	// Token: 0x02000014 RID: 20
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Form7 : global::System.Windows.Forms.Form
	{
		// Token: 0x0600011F RID: 287 RVA: 0x0000932C File Offset: 0x0000752C
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

		// Token: 0x06000120 RID: 288 RVA: 0x00009370 File Offset: 0x00007570
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::BlueWorm.Form7));
			this.TextBox1 = new global::System.Windows.Forms.TextBox();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.SuspendLayout();
			global::System.Windows.Forms.Control textBox = this.TextBox1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(33, 2);
			textBox.Location = location;
			this.TextBox1.Multiline = true;
			this.TextBox1.Name = "TextBox1";
			global::System.Windows.Forms.Control textBox2 = this.TextBox1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(117, 22);
			textBox2.Size = size;
			this.TextBox1.TabIndex = 5;
			this.TextBox1.Text = "9091";
			this.Button1.BackColor = global::System.Drawing.Color.White;
			this.Button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.Button1.ForeColor = global::System.Drawing.Color.Black;
			global::System.Windows.Forms.Control button = this.Button1;
			location = new global::System.Drawing.Point(156, 2);
			button.Location = location;
			this.Button1.Name = "Button1";
			global::System.Windows.Forms.Control button2 = this.Button1;
			size = new global::System.Drawing.Size(41, 22);
			button2.Size = size;
			this.Button1.TabIndex = 4;
			this.Button1.Text = "Start";
			this.Button1.UseVisualStyleBackColor = false;
			this.Label1.AutoSize = true;
			global::System.Windows.Forms.Control label = this.Label1;
			location = new global::System.Drawing.Point(1, 7);
			label.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control label2 = this.Label1;
			size = new global::System.Drawing.Size(26, 13);
			label2.Size = size;
			this.Label1.TabIndex = 3;
			this.Label1.Text = "Port";
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.White;
			size = new global::System.Drawing.Size(201, 28);
			this.ClientSize = size;
			this.Controls.Add(this.TextBox1);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.Label1);
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MaximizeBox = false;
			this.Name = "Form7";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x04000075 RID: 117
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}
