namespace TS.Win.BT
{
	// Token: 0x02000026 RID: 38
	public partial class BTVideoPlay : global::System.Windows.Forms.Form
	{
		// Token: 0x0600018F RID: 399 RVA: 0x000266C0 File Offset: 0x000248C0
		protected override void Dispose(bool disposing)
		{
			int num = 4;
			for (;;)
			{
				switch (num)
				{
				case 0:
					if (this.ᜂ != null)
					{
						if (true)
						{
						}
						num = 1;
						continue;
					}
					goto IL_68;
				case 1:
					this.ᜂ.Dispose();
					num = 2;
					continue;
				case 2:
					goto IL_44;
				case 3:
					num = 0;
					continue;
				}
				if (!disposing)
				{
					break;
				}
				num = 3;
			}
			IL_44:
			IL_68:
			base.Dispose(disposing);
		}

		// Token: 0x040000F0 RID: 240
		private global::System.ComponentModel.IContainer ᜂ;
	}
}
