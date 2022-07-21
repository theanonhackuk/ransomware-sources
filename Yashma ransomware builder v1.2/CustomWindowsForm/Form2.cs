using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CustomWindowsForm
{
	// Token: 0x02000008 RID: 8
	public partial class Form2 : Form
	{
		// Token: 0x0600009A RID: 154 RVA: 0x000086E5 File Offset: 0x000068E5
		public Form2()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600009B RID: 155 RVA: 0x000086FE File Offset: 0x000068FE
		private void buttonZ1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00008708 File Offset: 0x00006908
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000870B File Offset: 0x0000690B
		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			this.mouseDown = true;
			this.lastLocation = e.Location;
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00008724 File Offset: 0x00006924
		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.mouseDown)
			{
				base.Location = new Point(base.Location.X - this.lastLocation.X + e.X, base.Location.Y - this.lastLocation.Y + e.Y);
				base.Update();
			}
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00008796 File Offset: 0x00006996
		private void panel1_MouseUp(object sender, MouseEventArgs e)
		{
			this.mouseDown = false;
		}

		// Token: 0x0400005F RID: 95
		private bool mouseDown;

		// Token: 0x04000060 RID: 96
		private Point lastLocation;
	}
}
