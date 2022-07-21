namespace BlueWorm
{
	// Token: 0x02000012 RID: 18
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Form5 : global::System.Windows.Forms.Form
	{
		// Token: 0x060000FE RID: 254 RVA: 0x000086EC File Offset: 0x000068EC
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

		// Token: 0x060000FF RID: 255 RVA: 0x00008730 File Offset: 0x00006930
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::BlueWorm.Form5));
			this.SaveToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.TextBox1 = new global::System.Windows.Forms.TextBox();
			this.ToolStripSplitButton1 = new global::System.Windows.Forms.ToolStripSplitButton();
			this.ExitToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ToolStrip1 = new global::System.Windows.Forms.ToolStrip();
			this.ToolStrip1.SuspendLayout();
			this.SuspendLayout();
			this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem saveToolStripMenuItem = this.SaveToolStripMenuItem;
			global::System.Drawing.Size size = new global::System.Drawing.Size(101, 22);
			saveToolStripMenuItem.Size = size;
			this.SaveToolStripMenuItem.Text = "Save ";
			this.TextBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			global::System.Windows.Forms.Control textBox = this.TextBox1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 25);
			textBox.Location = location;
			this.TextBox1.Multiline = true;
			this.TextBox1.Name = "TextBox1";
			global::System.Windows.Forms.Control textBox2 = this.TextBox1;
			size = new global::System.Drawing.Size(284, 236);
			textBox2.Size = size;
			this.TextBox1.TabIndex = 3;
			this.ToolStripSplitButton1.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.ToolStripSplitButton1.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.SaveToolStripMenuItem,
				this.ExitToolStripMenuItem
			});
			this.ToolStripSplitButton1.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.ToolStripSplitButton1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ToolStripSplitButton1.Image");
			this.ToolStripSplitButton1.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.ToolStripSplitButton1.Name = "ToolStripSplitButton1";
			global::System.Windows.Forms.ToolStripItem toolStripSplitButton = this.ToolStripSplitButton1;
			size = new global::System.Drawing.Size(41, 22);
			toolStripSplitButton.Size = size;
			this.ToolStripSplitButton1.Text = "File";
			this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem exitToolStripMenuItem = this.ExitToolStripMenuItem;
			size = new global::System.Drawing.Size(101, 22);
			exitToolStripMenuItem.Size = size;
			this.ExitToolStripMenuItem.Text = "Exit ";
			this.ToolStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.ToolStripSplitButton1
			});
			global::System.Windows.Forms.Control toolStrip = this.ToolStrip1;
			location = new global::System.Drawing.Point(0, 0);
			toolStrip.Location = location;
			this.ToolStrip1.Name = "ToolStrip1";
			global::System.Windows.Forms.Control toolStrip2 = this.ToolStrip1;
			size = new global::System.Drawing.Size(284, 25);
			toolStrip2.Size = size;
			this.ToolStrip1.TabIndex = 2;
			this.ToolStrip1.Text = "ToolStrip1";
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(284, 261);
			this.ClientSize = size;
			this.Controls.Add(this.TextBox1);
			this.Controls.Add(this.ToolStrip1);
			this.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.Name = "Form5";
			this.Text = "Form5";
			this.ToolStrip1.ResumeLayout(false);
			this.ToolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x04000062 RID: 98
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}
