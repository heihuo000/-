using System;
using System.Data;
using System.Windows.Forms;
using TS.Win.BaseType;
using TS.Win.Presentation;

// Token: 0x0200008E RID: 142
internal class ᜃ : PresentationQuery
{
	// Token: 0x0600054D RID: 1357 RVA: 0x0007583C File Offset: 0x00073A3C
	public ᜃ(StringDict A_0, Control.ControlCollection A_1) : base(A_0, A_1)
	{
		base.PageTitle = A_0["Title"].ToString().TrimEnd(new char[0]);
	}

	// Token: 0x0600054E RID: 1358 RVA: 0x00075874 File Offset: 0x00073A74
	internal DataView ᜀ()
	{
		return this.ᜀ;
	}

	// Token: 0x0600054F RID: 1359 RVA: 0x00075888 File Offset: 0x00073A88
	internal void ᜀ(DataView A_0)
	{
		this.ᜀ = A_0;
	}

	// Token: 0x04000368 RID: 872
	private DataView ᜀ;
}
