using System;
using System.Drawing;
using System.Windows.Forms;

namespace CustomWindowsForm
{
	// Token: 0x02000005 RID: 5
	public class ButtonZ : Button
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600007B RID: 123 RVA: 0x00007A68 File Offset: 0x00005C68
		// (set) Token: 0x0600007C RID: 124 RVA: 0x00007A80 File Offset: 0x00005C80
		public string DisplayText
		{
			get
			{
				return this.text;
			}
			set
			{
				this.text = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00007A94 File Offset: 0x00005C94
		// (set) Token: 0x0600007E RID: 126 RVA: 0x00007AAC File Offset: 0x00005CAC
		public Color BZBackColor
		{
			get
			{
				return this.color;
			}
			set
			{
				this.color = value;
				base.Invalidate();
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00007AC0 File Offset: 0x00005CC0
		// (set) Token: 0x06000080 RID: 128 RVA: 0x00007AD8 File Offset: 0x00005CD8
		public Color MouseHoverColor
		{
			get
			{
				return this.m_hovercolor;
			}
			set
			{
				this.m_hovercolor = value;
				base.Invalidate();
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000081 RID: 129 RVA: 0x00007AEC File Offset: 0x00005CEC
		// (set) Token: 0x06000082 RID: 130 RVA: 0x00007B04 File Offset: 0x00005D04
		public Color MouseClickColor1
		{
			get
			{
				return this.clickcolor;
			}
			set
			{
				this.clickcolor = value;
				base.Invalidate();
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00007B18 File Offset: 0x00005D18
		// (set) Token: 0x06000084 RID: 132 RVA: 0x00007B30 File Offset: 0x00005D30
		public int TextLocation_X
		{
			get
			{
				return this.textX;
			}
			set
			{
				this.textX = value;
				base.Invalidate();
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000085 RID: 133 RVA: 0x00007B44 File Offset: 0x00005D44
		// (set) Token: 0x06000086 RID: 134 RVA: 0x00007B5C File Offset: 0x00005D5C
		public int TextLocation_Y
		{
			get
			{
				return this.textY;
			}
			set
			{
				this.textY = value;
				base.Invalidate();
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00007B70 File Offset: 0x00005D70
		public ButtonZ()
		{
			base.Size = new Size(31, 24);
			this.ForeColor = Color.White;
			base.FlatStyle = FlatStyle.Flat;
			this.Font = new Font("Microsoft YaHei UI", 20.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.Text = "_";
			this.text = this.Text;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00007C2C File Offset: 0x00005E2C
		protected override void OnMouseEnter(EventArgs e)
		{
			base.OnMouseEnter(e);
			this.clr1 = this.color;
			this.color = this.m_hovercolor;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00007C4F File Offset: 0x00005E4F
		protected override void OnMouseLeave(EventArgs e)
		{
			base.OnMouseLeave(e);
			this.color = this.clr1;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00007C66 File Offset: 0x00005E66
		protected override void OnMouseDown(MouseEventArgs mevent)
		{
			base.OnMouseDown(mevent);
			this.color = this.clickcolor;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00007C7D File Offset: 0x00005E7D
		protected override void OnMouseUp(MouseEventArgs mevent)
		{
			base.OnMouseUp(mevent);
			this.color = this.clr1;
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00007C94 File Offset: 0x00005E94
		protected override void OnPaint(PaintEventArgs pe)
		{
			base.OnPaint(pe);
			this.text = this.Text;
			if (this.textX == 100 && this.textY == 25)
			{
				this.textX = base.Width / 3 + 10;
				this.textY = base.Height / 2 - 1;
			}
			Point p = new Point(this.textX, this.textY);
			pe.Graphics.FillRectangle(new SolidBrush(this.color), base.ClientRectangle);
			pe.Graphics.DrawString(this.text, this.Font, new SolidBrush(this.ForeColor), p);
		}

		// Token: 0x04000050 RID: 80
		private Color clr1;

		// Token: 0x04000051 RID: 81
		private Color color = Color.Teal;

		// Token: 0x04000052 RID: 82
		private Color m_hovercolor = Color.FromArgb(0, 0, 140);

		// Token: 0x04000053 RID: 83
		private Color clickcolor = Color.FromArgb(160, 180, 200);

		// Token: 0x04000054 RID: 84
		private int textX = 6;

		// Token: 0x04000055 RID: 85
		private int textY = -20;

		// Token: 0x04000056 RID: 86
		private string text = "_";
	}
}
