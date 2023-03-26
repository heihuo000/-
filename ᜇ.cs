using System;
using System.Windows.Forms;
using TS.Win.BaseType;
using TS.Win.Presentation;

// Token: 0x02000090 RID: 144
internal class ᜇ : PresentationQuery
{
	// Token: 0x06000552 RID: 1362 RVA: 0x00075904 File Offset: 0x00073B04
	public ᜇ(StringDict A_0, Control.ControlCollection A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06000553 RID: 1363 RVA: 0x0007591C File Offset: 0x00073B1C
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
