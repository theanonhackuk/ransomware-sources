namespace BlueWorm
{
	// Token: 0x0200000F RID: 15
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Form2 : global::System.Windows.Forms.Form
	{
		// Token: 0x060000B3 RID: 179 RVA: 0x00006EDC File Offset: 0x000050DC
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

		// Token: 0x060000B4 RID: 180 RVA: 0x00006F20 File Offset: 0x00005120
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.icontainer_0 = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::BlueWorm.Form2));
			this.vmethod_1(new global::System.Windows.Forms.ContextMenuStrip(this.icontainer_0));
			this.AddPortToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.RemovePortToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ExitButWillDeleteVictimsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.vmethod_3(new global::System.Windows.Forms.ImageList(this.icontainer_0));
			this.ListView1 = new global::System.Windows.Forms.ListView();
			this.vmethod_5(new global::System.Windows.Forms.ColumnHeader());
			this.vmethod_7(new global::System.Windows.Forms.ColumnHeader());
			this.vmethod_8(new global::System.Windows.Forms.ColumnHeader());
			this.vmethod_0().SuspendLayout();
			this.SuspendLayout();
			this.vmethod_0().BackColor = global::System.Drawing.Color.FromArgb(25, 25, 25);
			this.vmethod_0().Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.AddPortToolStripMenuItem,
				this.RemovePortToolStripMenuItem,
				this.ExitButWillDeleteVictimsToolStripMenuItem
			});
			this.vmethod_0().Name = "ContextMenuStrip1";
			global::System.Windows.Forms.Control control = this.vmethod_0();
			global::System.Drawing.Size size = new global::System.Drawing.Size(215, 70);
			control.Size = size;
			this.AddPortToolStripMenuItem.BackColor = global::System.Drawing.Color.FromArgb(25, 25, 25);
			this.AddPortToolStripMenuItem.ForeColor = global::System.Drawing.Color.Lime;
			this.AddPortToolStripMenuItem.Name = "AddPortToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem addPortToolStripMenuItem = this.AddPortToolStripMenuItem;
			size = new global::System.Drawing.Size(214, 22);
			addPortToolStripMenuItem.Size = size;
			this.AddPortToolStripMenuItem.Text = "Add Port ";
			this.RemovePortToolStripMenuItem.BackColor = global::System.Drawing.Color.FromArgb(25, 25, 25);
			this.RemovePortToolStripMenuItem.ForeColor = global::System.Drawing.Color.Lime;
			this.RemovePortToolStripMenuItem.Name = "RemovePortToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem removePortToolStripMenuItem = this.RemovePortToolStripMenuItem;
			size = new global::System.Drawing.Size(214, 22);
			removePortToolStripMenuItem.Size = size;
			this.RemovePortToolStripMenuItem.Text = "Remove Port ";
			this.ExitButWillDeleteVictimsToolStripMenuItem.ForeColor = global::System.Drawing.Color.Red;
			this.ExitButWillDeleteVictimsToolStripMenuItem.Name = "ExitButWillDeleteVictimsToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem exitButWillDeleteVictimsToolStripMenuItem = this.ExitButWillDeleteVictimsToolStripMenuItem;
			size = new global::System.Drawing.Size(214, 22);
			exitButWillDeleteVictimsToolStripMenuItem.Size = size;
			this.ExitButWillDeleteVictimsToolStripMenuItem.Text = "Exit But Will Delete Victims";
			this.vmethod_2().ColorDepth = global::System.Windows.Forms.ColorDepth.Depth8Bit;
			global::System.Windows.Forms.ImageList imageList = this.vmethod_2();
			size = new global::System.Drawing.Size(16, 16);
			imageList.ImageSize = size;
			this.vmethod_2().TransparentColor = global::System.Drawing.Color.Transparent;
			this.ListView1.BackColor = global::System.Drawing.Color.FromArgb(25, 25, 25);
			this.ListView1.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.vmethod_4(),
				this.vmethod_6(),
				this.HdJsnjmybB()
			});
			this.ListView1.ContextMenuStrip = this.vmethod_0();
			this.ListView1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.ListView1.ForeColor = global::System.Drawing.Color.Lime;
			this.ListView1.FullRowSelect = true;
			global::System.Windows.Forms.Control listView = this.ListView1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 0);
			listView.Location = location;
			this.ListView1.Name = "ListView1";
			global::System.Windows.Forms.Control listView2 = this.ListView1;
			size = new global::System.Drawing.Size(313, 155);
			listView2.Size = size;
			this.ListView1.SmallImageList = this.vmethod_2();
			this.ListView1.TabIndex = 1;
			this.ListView1.UseCompatibleStateImageBehavior = false;
			this.ListView1.View = global::System.Windows.Forms.View.Details;
			this.vmethod_4().Text = "";
			this.vmethod_4().Width = 30;
			this.vmethod_6().Text = "Port";
			this.vmethod_6().Width = 81;
			this.HdJsnjmybB().Text = "Status";
			this.HdJsnjmybB().Width = 161;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(25, 25, 25);
			size = new global::System.Drawing.Size(313, 155);
			this.ClientSize = size;
			this.Controls.Add(this.ListView1);
			this.ForeColor = global::System.Drawing.Color.Lime;
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.Name = "Form2";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Port Manager";
			this.TopMost = true;
			this.vmethod_0().ResumeLayout(false);
			this.ResumeLayout(false);
		}

		// Token: 0x04000040 RID: 64
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}
