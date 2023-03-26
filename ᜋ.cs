using System;
using System.Windows.Forms;
using TS.Win.BaseType;
using TS.Win.Presentation;

// Token: 0x02000091 RID: 145
internal class ᜋ : PresentationQuery
{
	// Token: 0x06000554 RID: 1364 RVA: 0x0007596C File Offset: 0x00073B6C
	public ᜋ(StringDict A_0, Control.ControlCollection A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06000555 RID: 1365 RVA: 0x00075984 File Offset: 0x00073B84
	protected virtual void ᜀ(PerformQueryEventArgs A_0)
	{
		if (true)
		{
		}
		string strFieldsCriteria = A_0.FieldsCriteria;
		string gridCriteria = A_0.GridCriteria;
		int toPageIndex = A_0.ToPageIndex;
		bool toFirstPage = A_0.ToFirstPage;
		bool toLastPage = A_0.ToLastPage;
		strFieldsCriteria = "0<>0";
		base.OnPerformQuery(new PerformQueryEventArgs(strFieldsCriteria, gridCriteria, toPageIndex, toFirstPage, toLastPage));
	}
}
