using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using CustomWindowsForm;
using Ryuk.Net.Properties;

namespace Ryuk.Net
{
	// Token: 0x02000007 RID: 7
	public partial class extensions : Form
	{
		// Token: 0x0600008E RID: 142 RVA: 0x00007F70 File Offset: 0x00006170
		public extensions()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00007F89 File Offset: 0x00006189
		private void _CloseButton_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00007F93 File Offset: 0x00006193
		private void button1_Click(object sender, EventArgs e)
		{
			Settings.Default.extensions = this.textBox1.Text;
			MessageBox.Show("Saved successfully");
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00007FB7 File Offset: 0x000061B7
		private void extensions_Load(object sender, EventArgs e)
		{
			this.textBox1.Text = Settings.Default.extensions;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00007FD0 File Offset: 0x000061D0
		private void extensions_MouseDown(object sender, MouseEventArgs e)
		{
			this.mouseDown = true;
			this.lastLocation = e.Location;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00007FE6 File Offset: 0x000061E6
		private void extensions_MouseUp(object sender, MouseEventArgs e)
		{
			this.mouseDown = false;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00007FF0 File Offset: 0x000061F0
		private void extensions_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.mouseDown)
			{
				base.Location = new Point(base.Location.X - this.lastLocation.X + e.X, base.Location.Y - this.lastLocation.Y + e.Y);
				base.Update();
			}
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00008062 File Offset: 0x00006262
		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			this.mouseDown = true;
			this.lastLocation = e.Location;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00008078 File Offset: 0x00006278
		private void panel1_MouseUp(object sender, MouseEventArgs e)
		{
			this.mouseDown = false;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00008084 File Offset: 0x00006284
		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.mouseDown)
			{
				base.Location = new Point(base.Location.X - this.lastLocation.X + e.X, base.Location.Y - this.lastLocation.Y + e.Y);
				base.Update();
			}
		}

		// Token: 0x04000057 RID: 87
		private bool mouseDown;

		// Token: 0x04000058 RID: 88
		private Point lastLocation;
	}
}
