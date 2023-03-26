using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

// Token: 0x0200008C RID: 140
internal class a : UserControl
{
	// Token: 0x06000538 RID: 1336 RVA: 0x00075040 File Offset: 0x00073240
	[CompilerGenerated]
	public void ᜀ(EventHandler A_0)
	{
		for (;;)
		{
			if (true)
			{
			}
			EventHandler eventHandler = this.ᜀ;
			int num = 2;
			for (;;)
			{
				EventHandler eventHandler2;
				switch (num)
				{
				case 0:
					return;
				case 1:
					if (eventHandler == eventHandler2)
					{
						num = 0;
						continue;
					}
					goto IL_2D;
				case 2:
					goto IL_2D;
				}
				break;
				IL_2D:
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, A_0);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.ᜀ, value, eventHandler2);
				num = 1;
			}
		}
	}

	// Token: 0x06000539 RID: 1337 RVA: 0x000750B0 File Offset: 0x000732B0
	[CompilerGenerated]
	public void ᜂ(EventHandler A_0)
	{
		for (;;)
		{
			if (true)
			{
			}
			EventHandler eventHandler = this.ᜀ;
			int num = 0;
			for (;;)
			{
				EventHandler eventHandler2;
				switch (num)
				{
				case 0:
					goto IL_2D;
				case 1:
					return;
				case 2:
					if (eventHandler == eventHandler2)
					{
						num = 1;
						continue;
					}
					goto IL_2D;
				}
				break;
				IL_2D:
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, A_0);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.ᜀ, value, eventHandler2);
				num = 2;
			}
		}
	}

	// Token: 0x0600053A RID: 1338 RVA: 0x00075120 File Offset: 0x00073320
	[CompilerGenerated]
	public void ᜁ(EventHandler A_0)
	{
		for (;;)
		{
			EventHandler eventHandler = this.ᜁ;
			int num = 0;
			for (;;)
			{
				EventHandler eventHandler2;
				switch (num)
				{
				case 0:
					goto IL_25;
				case 1:
					if (eventHandler == eventHandler2)
					{
						if (true)
						{
						}
						num = 2;
						continue;
					}
					goto IL_25;
				case 2:
					return;
				}
				break;
				IL_25:
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, A_0);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.ᜁ, value, eventHandler2);
				num = 1;
			}
		}
	}

	// Token: 0x0600053B RID: 1339 RVA: 0x00075190 File Offset: 0x00073390
	[CompilerGenerated]
	public void ᜃ(EventHandler A_0)
	{
		for (;;)
		{
			EventHandler eventHandler = this.ᜁ;
			int num = 1;
			for (;;)
			{
				EventHandler eventHandler2;
				switch (num)
				{
				case 0:
					if (eventHandler == eventHandler2)
					{
						num = 2;
						continue;
					}
					goto IL_25;
				case 1:
					goto IL_25;
				case 2:
					goto IL_56;
				}
				break;
				IL_25:
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, A_0);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.ᜁ, value, eventHandler2);
				num = 0;
			}
		}
		IL_56:
		if (true)
		{
		}
	}

	// Token: 0x0600053C RID: 1340 RVA: 0x00075200 File Offset: 0x00073400
	public Color ᜁ()
	{
		return this.ᜂ;
	}

	// Token: 0x0600053D RID: 1341 RVA: 0x00075214 File Offset: 0x00073414
	public void ᜀ(Color A_0)
	{
		this.ᜂ = A_0;
	}

	// Token: 0x0600053E RID: 1342 RVA: 0x00075228 File Offset: 0x00073428
	public a()
	{
		this.ᜀ();
	}

	// Token: 0x0600053F RID: 1343 RVA: 0x0007524C File Offset: 0x0007344C
	protected override void OnSizeChanged(EventArgs e)
	{
		base.OnSizeChanged(e);
	}

	// Token: 0x06000540 RID: 1344 RVA: 0x00075260 File Offset: 0x00073460
	public virtual string ᜂ()
	{
		return this.ᜄ.Text;
	}

	// Token: 0x06000541 RID: 1345 RVA: 0x00075278 File Offset: 0x00073478
	public virtual void ᜀ(string A_0)
	{
		this.ᜄ.Text = A_0;
	}

	// Token: 0x06000542 RID: 1346 RVA: 0x00075294 File Offset: 0x00073494
	protected override void OnGotFocus(EventArgs e)
	{
		if (true)
		{
		}
		base.OnGotFocus(e);
		this.ᜄ.Visible = true;
		this.ᜄ.Focus();
		this.Refresh();
	}

	// Token: 0x06000543 RID: 1347 RVA: 0x000752D0 File Offset: 0x000734D0
	private void ᜁ(object A_0, EventArgs A_1)
	{
		for (;;)
		{
			this.ᜄ.Visible = false;
			int num = 0;
			int num2 = 4;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_68;
				case 1:
					if (this.Text != num.ToString())
					{
						num2 = 2;
						continue;
					}
					goto IL_93;
				case 2:
					this.Text = num.ToString();
					num2 = 0;
					continue;
				case 3:
					num2 = 1;
					continue;
				case 4:
					if (true)
					{
					}
					if (int.TryParse(this.Text, out num))
					{
						num2 = 3;
						continue;
					}
					goto IL_93;
				}
				break;
			}
		}
		IL_68:
		IL_93:
		this.Refresh();
	}

	// Token: 0x06000544 RID: 1348 RVA: 0x00075378 File Offset: 0x00073578
	protected override void OnPaint(PaintEventArgs e)
	{
		base.OnPaint(e);
		e.Graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), new PointF(0f, 0f));
		if (!this.ᜄ.Visible)
		{
			if (true)
			{
			}
			e.Graphics.DrawLine(new Pen(this.ᜁ()), new Point(0, base.Height - 1), new Point(base.Width, base.Height - 1));
			return;
		}
		e.Graphics.DrawRectangle(new Pen(this.ᜁ()), new Rectangle(0, 0, base.Width - 1, base.Height - 1));
	}

	// Token: 0x06000545 RID: 1349 RVA: 0x0007543C File Offset: 0x0007363C
	private void ᜀ(object A_0, EventArgs A_1)
	{
		if (this.ᜀ != null)
		{
			this.ᜀ(this, A_1);
		}
	}

	// Token: 0x06000546 RID: 1350 RVA: 0x00075464 File Offset: 0x00073664
	private void ᜀ(object A_0, KeyPressEventArgs A_1)
	{
		for (;;)
		{
			int num = 0;
			int num2 = 3;
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					char keyChar;
					if (!int.TryParse(keyChar.ToString(), out num))
					{
						num2 = 4;
						continue;
					}
					return;
				}
				case 1:
				{
					char keyChar = A_1.KeyChar;
					num2 = 0;
					continue;
				}
				case 2:
					goto IL_48;
				case 3:
					if (A_1.KeyChar != '\b')
					{
						num2 = 1;
						continue;
					}
					return;
				case 4:
					A_1.Handled = true;
					num2 = 2;
					continue;
				}
				break;
			}
		}
		IL_48:
		if (true)
		{
		}
	}

	// Token: 0x06000547 RID: 1351 RVA: 0x000754EC File Offset: 0x000736EC
	private void ᜀ(object A_0, KeyEventArgs A_1)
	{
		int num = 4;
		for (;;)
		{
			switch (num)
			{
			case 0:
				num = 3;
				continue;
			case 1:
				return;
			case 2:
				this.ᜁ(this, new EventArgs());
				num = 1;
				continue;
			case 3:
				if (this.ᜁ != null)
				{
					num = 2;
					continue;
				}
				return;
			}
			if (true)
			{
			}
			if (A_1.KeyCode != Keys.Return)
			{
				break;
			}
			num = 0;
		}
	}

	// Token: 0x06000548 RID: 1352 RVA: 0x00075570 File Offset: 0x00073770
	protected override void Dispose(bool disposing)
	{
		int num = 1;
		for (;;)
		{
			switch (num)
			{
			case 0:
				if (this.ᜃ != null)
				{
					if (true)
					{
					}
					num = 3;
					continue;
				}
				goto IL_68;
			case 2:
				num = 0;
				continue;
			case 3:
				this.ᜃ.Dispose();
				num = 4;
				continue;
			case 4:
				goto IL_44;
			}
			if (!disposing)
			{
				break;
			}
			num = 2;
		}
		IL_44:
		IL_68:
		base.Dispose(disposing);
	}

	// Token: 0x06000549 RID: 1353 RVA: 0x000755EC File Offset: 0x000737EC
	private void ᜀ()
	{
		if (true)
		{
		}
		this.ᜄ = new TextBox();
		base.SuspendLayout();
		this.ᜄ.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
		this.ᜄ.BorderStyle = BorderStyle.None;
		this.ᜄ.Location = new Point(1, 1);
		this.ᜄ.Name = "TextBox";
		this.ᜄ.Size = new Size(272, 14);
		this.ᜄ.TabIndex = 0;
		this.ᜄ.Visible = false;
		this.ᜄ.TextChanged += this.ᜀ;
		this.ᜄ.KeyDown += this.ᜀ;
		this.ᜄ.Leave += this.ᜁ;
		this.ᜄ.KeyPress += this.ᜀ;
		base.AutoScaleDimensions = new SizeF(6f, 12f);
		base.AutoScaleMode = AutoScaleMode.Font;
		this.BackColor = Color.Transparent;
		base.Controls.Add(this.ᜄ);
		base.Name = "PointTextBox";
		base.Size = new Size(274, 24);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x04000363 RID: 867
	[CompilerGenerated]
	private EventHandler ᜀ;

	// Token: 0x04000364 RID: 868
	[CompilerGenerated]
	private EventHandler ᜁ;

	// Token: 0x04000365 RID: 869
	private Color ᜂ = Color.Black;

	// Token: 0x04000366 RID: 870
	private IContainer ᜃ;

	// Token: 0x04000367 RID: 871
	private TextBox ᜄ;
}
