using System;
using System.Drawing;
using System.Windows.Forms;

namespace CustomWindowsForm
{
	// Token: 0x02000004 RID: 4
	public class ButtonX : Button
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000067 RID: 103 RVA: 0x000076F0 File Offset: 0x000058F0
		// (set) Token: 0x06000068 RID: 104 RVA: 0x00007708 File Offset: 0x00005908
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

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000069 RID: 105 RVA: 0x0000771C File Offset: 0x0000591C
		// (set) Token: 0x0600006A RID: 106 RVA: 0x00007734 File Offset: 0x00005934
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

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600006B RID: 107 RVA: 0x00007748 File Offset: 0x00005948
		// (set) Token: 0x0600006C RID: 108 RVA: 0x00007760 File Offset: 0x00005960
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

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600006D RID: 109 RVA: 0x00007774 File Offset: 0x00005974
		// (set) Token: 0x0600006E RID: 110 RVA: 0x0000778C File Offset: 0x0000598C
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

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600006F RID: 111 RVA: 0x000077A0 File Offset: 0x000059A0
		// (set) Token: 0x06000070 RID: 112 RVA: 0x000077B8 File Offset: 0x000059B8
		public bool ChangeColorMouseHC
		{
			get
			{
				return this.isChanged;
			}
			set
			{
				this.isChanged = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000071 RID: 113 RVA: 0x000077CC File Offset: 0x000059CC
		// (set) Token: 0x06000072 RID: 114 RVA: 0x000077E4 File Offset: 0x000059E4
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

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000073 RID: 115 RVA: 0x000077F8 File Offset: 0x000059F8
		// (set) Token: 0x06000074 RID: 116 RVA: 0x00007810 File Offset: 0x00005A10
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

		// Token: 0x06000075 RID: 117 RVA: 0x00007824 File Offset: 0x00005A24
		public ButtonX()
		{
			base.Size = new Size(31, 24);
			this.ForeColor = Color.White;
			base.FlatStyle = FlatStyle.Flat;
			this.Font = new Font("Microsoft YaHei UI", 20.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.Text = "_";
			this.text = this.Text;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000078E7 File Offset: 0x00005AE7
		protected override void OnMouseEnter(EventArgs e)
		{
			base.OnMouseEnter(e);
			this.clr1 = this.color;
			this.color = this.m_hovercolor;
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000790C File Offset: 0x00005B0C
		protected override void OnMouseLeave(EventArgs e)
		{
			base.OnMouseLeave(e);
			if (this.isChanged)
			{
				this.color = this.clr1;
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00007940 File Offset: 0x00005B40
		protected override void OnMouseDown(MouseEventArgs mevent)
		{
			base.OnMouseDown(mevent);
			if (this.isChanged)
			{
				this.color = this.clickcolor;
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00007974 File Offset: 0x00005B74
		protected override void OnMouseUp(MouseEventArgs mevent)
		{
			base.OnMouseUp(mevent);
			if (this.isChanged)
			{
				this.color = this.clr1;
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000079A8 File Offset: 0x00005BA8
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

		// Token: 0x04000048 RID: 72
		private Color clr1;

		// Token: 0x04000049 RID: 73
		private Color color = Color.Teal;

		// Token: 0x0400004A RID: 74
		private Color m_hovercolor = Color.FromArgb(0, 0, 140);

		// Token: 0x0400004B RID: 75
		private Color clickcolor = Color.FromArgb(160, 180, 200);

		// Token: 0x0400004C RID: 76
		private int textX = 6;

		// Token: 0x0400004D RID: 77
		private int textY = -20;

		// Token: 0x0400004E RID: 78
		private string text = "_";

		// Token: 0x0400004F RID: 79
		private bool isChanged = true;
	}
}
