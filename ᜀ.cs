using System;
using System.Collections.Generic;
using System.Data;

// Token: 0x02000096 RID: 150
internal class ᜀ
{
	// Token: 0x06000562 RID: 1378 RVA: 0x00076A0C File Offset: 0x00074C0C
	public int[] ᜁ()
	{
		return this.ᜄ.ToArray();
	}

	// Token: 0x06000563 RID: 1379 RVA: 0x00076A24 File Offset: 0x00074C24
	public int[] ᜀ()
	{
		return this.ᜅ.ToArray();
	}

	// Token: 0x06000564 RID: 1380 RVA: 0x00076A3C File Offset: 0x00074C3C
	public void ᜀ(DataRow A_0)
	{
		int num = 3;
		int item;
		for (;;)
		{
			int num2;
			switch (num)
			{
			case 0:
				num2 = Convert.ToInt32(A_0["ItemAttrib1"]);
				goto IL_F1;
			case 1:
				goto IL_51;
			case 2:
				this.ᜆ = A_0.Table.Clone();
				num = 1;
				continue;
			case 4:
				goto IL_A2;
			case 5:
				num2 = 0;
				goto IL_F1;
			case 6:
				if (A_0["ItemQty"] != DBNull.Value)
				{
					num = 8;
					continue;
				}
				num = 4;
				continue;
			case 7:
				num = 0;
				continue;
			case 8:
				num = 9;
				continue;
			case 9:
				goto IL_B0;
			case 10:
				if (true)
				{
				}
				if (A_0["ItemAttrib1"] != DBNull.Value)
				{
					num = 7;
					continue;
				}
				num = 5;
				continue;
			}
			if (this.ᜆ == null)
			{
				num = 2;
				continue;
			}
			IL_51:
			num = 10;
			continue;
			IL_F1:
			item = num2;
			num = 6;
		}
		IL_A2:
		int num3 = 0;
		goto IL_11C;
		IL_B0:
		num3 = Convert.ToInt32(A_0["ItemQty"]);
		IL_11C:
		int item2 = num3;
		this.ᜄ.Add(item);
		this.ᜅ.Add(item2);
		this.ᜆ.ImportRow(A_0);
	}

	// Token: 0x0400036D RID: 877
	public long ᜀ;

	// Token: 0x0400036E RID: 878
	public string ᜁ;

	// Token: 0x0400036F RID: 879
	public string ᜂ;

	// Token: 0x04000370 RID: 880
	public string ᜃ;

	// Token: 0x04000371 RID: 881
	private List<int> ᜄ = new List<int>();

	// Token: 0x04000372 RID: 882
	private List<int> ᜅ = new List<int>();

	// Token: 0x04000373 RID: 883
	public DataTable ᜆ;
}
