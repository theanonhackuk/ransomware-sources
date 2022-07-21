using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CustomWindowsForm
{
	// Token: 0x0200000D RID: 13
	public class ShapedButton : Button
	{
		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000BD RID: 189 RVA: 0x00009518 File Offset: 0x00007718
		// (set) Token: 0x060000BE RID: 190 RVA: 0x00009530 File Offset: 0x00007730
		public ShapedButton.ButtonsShapes ButtonShape
		{
			get
			{
				return this.buttonShape;
			}
			set
			{
				this.buttonShape = value;
				base.Invalidate();
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000BF RID: 191 RVA: 0x00009544 File Offset: 0x00007744
		// (set) Token: 0x060000C0 RID: 192 RVA: 0x0000955C File Offset: 0x0000775C
		public string ButtonText
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

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x00009570 File Offset: 0x00007770
		// (set) Token: 0x060000C2 RID: 194 RVA: 0x00009588 File Offset: 0x00007788
		public int BorderWidth
		{
			get
			{
				return this.borderWidth;
			}
			set
			{
				this.borderWidth = value;
				base.Invalidate();
			}
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x0000959C File Offset: 0x0000779C
		private void SetBorderColor(Color bdrColor)
		{
			int num = (int)(bdrColor.R - 40);
			int num2 = (int)(bdrColor.G - 40);
			int num3 = (int)(bdrColor.B - 40);
			if (num < 0)
			{
				num = 0;
			}
			if (num2 < 0)
			{
				num2 = 0;
			}
			if (num3 < 0)
			{
				num3 = 0;
			}
			this.buttonborder = Color.FromArgb(num, num2, num3);
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x00009600 File Offset: 0x00007800
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x00009618 File Offset: 0x00007818
		public Color BorderColor
		{
			get
			{
				return this.borderColor;
			}
			set
			{
				this.borderColor = value;
				if (this.borderColor == Color.Transparent)
				{
					this.buttonborder = Color.FromArgb(220, 220, 220);
				}
				else
				{
					this.SetBorderColor(this.borderColor);
				}
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x00009674 File Offset: 0x00007874
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x0000968C File Offset: 0x0000788C
		public Color StartColor
		{
			get
			{
				return this.color1;
			}
			set
			{
				this.color1 = value;
				base.Invalidate();
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x000096A0 File Offset: 0x000078A0
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x000096B8 File Offset: 0x000078B8
		public Color EndColor
		{
			get
			{
				return this.color2;
			}
			set
			{
				this.color2 = value;
				base.Invalidate();
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000CA RID: 202 RVA: 0x000096CC File Offset: 0x000078CC
		// (set) Token: 0x060000CB RID: 203 RVA: 0x000096E4 File Offset: 0x000078E4
		public Color MouseHoverColor1
		{
			get
			{
				return this.m_hovercolor1;
			}
			set
			{
				this.m_hovercolor1 = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000CC RID: 204 RVA: 0x000096F8 File Offset: 0x000078F8
		// (set) Token: 0x060000CD RID: 205 RVA: 0x00009710 File Offset: 0x00007910
		public Color MouseHoverColor2
		{
			get
			{
				return this.m_hovercolor2;
			}
			set
			{
				this.m_hovercolor2 = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000CE RID: 206 RVA: 0x00009724 File Offset: 0x00007924
		// (set) Token: 0x060000CF RID: 207 RVA: 0x0000973C File Offset: 0x0000793C
		public Color MouseClickColor1
		{
			get
			{
				return this.clickcolor1;
			}
			set
			{
				this.clickcolor1 = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x00009750 File Offset: 0x00007950
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x00009768 File Offset: 0x00007968
		public Color MouseClickColor2
		{
			get
			{
				return this.clickcolor2;
			}
			set
			{
				this.clickcolor2 = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x0000977C File Offset: 0x0000797C
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x00009794 File Offset: 0x00007994
		public int Transparent1
		{
			get
			{
				return this.color1Transparent;
			}
			set
			{
				this.color1Transparent = value;
				if (this.color1Transparent > 255)
				{
					this.color1Transparent = 255;
					base.Invalidate();
				}
				else
				{
					base.Invalidate();
				}
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x000097DC File Offset: 0x000079DC
		// (set) Token: 0x060000D5 RID: 213 RVA: 0x000097F4 File Offset: 0x000079F4
		public int Transparent2
		{
			get
			{
				return this.color2Transparent;
			}
			set
			{
				this.color2Transparent = value;
				if (this.color2Transparent > 255)
				{
					this.color2Transparent = 255;
					base.Invalidate();
				}
				else
				{
					base.Invalidate();
				}
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x0000983C File Offset: 0x00007A3C
		// (set) Token: 0x060000D7 RID: 215 RVA: 0x00009854 File Offset: 0x00007A54
		public int GradientAngle
		{
			get
			{
				return this.angle;
			}
			set
			{
				this.angle = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x00009868 File Offset: 0x00007A68
		// (set) Token: 0x060000D9 RID: 217 RVA: 0x00009880 File Offset: 0x00007A80
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

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000DA RID: 218 RVA: 0x00009894 File Offset: 0x00007A94
		// (set) Token: 0x060000DB RID: 219 RVA: 0x000098AC File Offset: 0x00007AAC
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

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000DC RID: 220 RVA: 0x000098C0 File Offset: 0x00007AC0
		// (set) Token: 0x060000DD RID: 221 RVA: 0x000098D8 File Offset: 0x00007AD8
		public bool ShowButtontext
		{
			get
			{
				return this.showButtonText;
			}
			set
			{
				this.showButtonText = value;
				base.Invalidate();
			}
		}

		// Token: 0x060000DE RID: 222 RVA: 0x000098EC File Offset: 0x00007AEC
		public ShapedButton()
		{
			base.Size = new Size(100, 40);
			this.BackColor = Color.Transparent;
			base.FlatStyle = FlatStyle.Flat;
			base.FlatAppearance.BorderSize = 0;
			base.FlatAppearance.MouseOverBackColor = Color.Transparent;
			base.FlatAppearance.MouseDownBackColor = Color.Transparent;
			this.text = this.Text;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00009A0F File Offset: 0x00007C0F
		protected override void OnMouseEnter(EventArgs e)
		{
			base.OnMouseEnter(e);
			this.clr1 = this.color1;
			this.clr2 = this.color2;
			this.color1 = this.m_hovercolor1;
			this.color2 = this.m_hovercolor2;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00009A4A File Offset: 0x00007C4A
		protected override void OnMouseLeave(EventArgs e)
		{
			base.OnMouseLeave(e);
			this.color1 = this.clr1;
			this.color2 = this.clr2;
			this.SetBorderColor(this.borderColor);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00009A7C File Offset: 0x00007C7C
		protected override void OnMouseDown(MouseEventArgs mevent)
		{
			base.OnMouseDown(mevent);
			this.color1 = this.clickcolor1;
			this.color2 = this.clickcolor2;
			this.buttonborder = this.borderColor;
			this.SetBorderColor(this.borderColor);
			base.Invalidate();
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00009ACA File Offset: 0x00007CCA
		protected override void OnMouseUp(MouseEventArgs mevent)
		{
			base.OnMouseUp(mevent);
			this.OnMouseLeave(mevent);
			this.color1 = this.clr1;
			this.color2 = this.clr2;
			this.SetBorderColor(this.borderColor);
			base.Invalidate();
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00009B09 File Offset: 0x00007D09
		protected override void OnLostFocus(EventArgs e)
		{
			base.OnLostFocus(e);
			this.color1 = this.clr1;
			this.color2 = this.clr2;
			base.Invalidate();
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00009B33 File Offset: 0x00007D33
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			this.textX = base.Width / 3 - 1;
			this.textY = base.Height / 3 + 5;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00009B60 File Offset: 0x00007D60
		private void DrawCircularButton(Graphics g)
		{
			Color color = Color.FromArgb(this.color1Transparent, this.color1);
			Color color2 = Color.FromArgb(this.color2Transparent, this.color2);
			Brush brush = new LinearGradientBrush(base.ClientRectangle, color, color2, (float)this.angle);
			g.FillEllipse(brush, 5, 5, base.Width - 10, base.Height - 10);
			for (int i = 0; i < this.borderWidth; i++)
			{
				g.DrawEllipse(new Pen(new SolidBrush(this.buttonborder)), 5 + i, 5, base.Width - 10, base.Height - 10);
			}
			if (this.showButtonText)
			{
				Point p = new Point(this.textX, this.textY);
				SolidBrush brush2 = new SolidBrush(this.ForeColor);
				g.DrawString(this.text, this.Font, brush2, p);
			}
			brush.Dispose();
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00009C60 File Offset: 0x00007E60
		private void DrawRoundRectangularButton(Graphics g)
		{
			Color color = Color.FromArgb(this.color1Transparent, this.color1);
			Color color2 = Color.FromArgb(this.color2Transparent, this.color2);
			Brush brush = new LinearGradientBrush(base.ClientRectangle, color, color2, (float)this.angle);
			Region region = new Region(new Rectangle(5, 5, base.Width, base.Height));
			GraphicsPath graphicsPath = new GraphicsPath();
			graphicsPath.AddArc(5, 5, 40, 40, 180f, 90f);
			graphicsPath.AddLine(25, 5, base.Width - 25, 5);
			graphicsPath.AddArc(base.Width - 45, 5, 40, 40, 270f, 90f);
			graphicsPath.AddLine(base.Width - 5, 25, base.Width - 5, base.Height - 25);
			graphicsPath.AddArc(base.Width - 45, base.Height - 45, 40, 40, 0f, 90f);
			graphicsPath.AddLine(25, base.Height - 5, base.Width - 25, base.Height - 5);
			graphicsPath.AddArc(5, base.Height - 45, 40, 40, 90f, 90f);
			graphicsPath.AddLine(5, 25, 5, base.Height - 25);
			region.Intersect(graphicsPath);
			g.FillRegion(brush, region);
			for (int i = 0; i < this.borderWidth; i++)
			{
				g.DrawArc(new Pen(this.buttonborder), 5 + i, 5 + i, 40, 40, 180, 90);
				g.DrawLine(new Pen(this.buttonborder), 25, 5 + i, base.Width - 25, 5 + i);
				g.DrawArc(new Pen(this.buttonborder), base.Width - 45 - i, 5 + i, 40, 40, 270, 90);
				g.DrawLine(new Pen(this.buttonborder), 5 + i, 25, 5 + i, base.Height - 25);
				g.DrawLine(new Pen(this.buttonborder), base.Width - 5 - i, 25, base.Width - 5 - i, base.Height - 25);
				g.DrawArc(new Pen(this.buttonborder), base.Width - 45 - i, base.Height - 45 - i, 40, 40, 0, 90);
				g.DrawLine(new Pen(this.buttonborder), 25, base.Height - 5 - i, base.Width - 25, base.Height - 5 - i);
				g.DrawArc(new Pen(this.buttonborder), 5 + i, base.Height - 45 - i, 40, 40, 90, 90);
			}
			if (this.showButtonText)
			{
				Point p = new Point(this.textX, this.textY);
				SolidBrush brush2 = new SolidBrush(this.ForeColor);
				g.DrawString(this.text, this.Font, brush2, p);
			}
			brush.Dispose();
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00009FA0 File Offset: 0x000081A0
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			switch (this.buttonShape)
			{
			case ShapedButton.ButtonsShapes.RoundRect:
				this.DrawRoundRectangularButton(e.Graphics);
				break;
			case ShapedButton.ButtonsShapes.Circle:
				this.DrawCircularButton(e.Graphics);
				break;
			}
		}

		// Token: 0x04000078 RID: 120
		private Color clr1;

		// Token: 0x04000079 RID: 121
		private Color clr2;

		// Token: 0x0400007A RID: 122
		private Color color1 = Color.DodgerBlue;

		// Token: 0x0400007B RID: 123
		private Color color2 = Color.MidnightBlue;

		// Token: 0x0400007C RID: 124
		private Color m_hovercolor1 = Color.Turquoise;

		// Token: 0x0400007D RID: 125
		private Color m_hovercolor2 = Color.DarkSlateGray;

		// Token: 0x0400007E RID: 126
		private int color1Transparent = 250;

		// Token: 0x0400007F RID: 127
		private int color2Transparent = 250;

		// Token: 0x04000080 RID: 128
		private Color clickcolor1 = Color.Yellow;

		// Token: 0x04000081 RID: 129
		private Color clickcolor2 = Color.Red;

		// Token: 0x04000082 RID: 130
		private int angle = 90;

		// Token: 0x04000083 RID: 131
		private int textX = 100;

		// Token: 0x04000084 RID: 132
		private int textY = 25;

		// Token: 0x04000085 RID: 133
		private string text = "";

		// Token: 0x04000086 RID: 134
		public Color buttonborder = Color.FromArgb(220, 220, 220);

		// Token: 0x04000087 RID: 135
		public bool showButtonText = true;

		// Token: 0x04000088 RID: 136
		public int borderWidth = 2;

		// Token: 0x04000089 RID: 137
		public Color borderColor = Color.Transparent;

		// Token: 0x0400008A RID: 138
		private ShapedButton.ButtonsShapes buttonShape;

		// Token: 0x0200000E RID: 14
		public enum ButtonsShapes
		{
			// Token: 0x0400008C RID: 140
			RoundRect,
			// Token: 0x0400008D RID: 141
			Circle
		}
	}
}
