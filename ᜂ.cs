using System;
using TS.Win.BaseType;
using TS.Win.PageCommon;

// Token: 0x02000098 RID: 152
internal class ᜂ
{
	// Token: 0x06000568 RID: 1384 RVA: 0x00076BCC File Offset: 0x00074DCC
	public static void ᜀ(GetPageEventArgs A_0)
	{
		for (;;)
		{
			int pageType = A_0.PageType;
			int num = 2;
			for (;;)
			{
				switch (num)
				{
				case 0:
					switch (pageType)
					{
					case 301:
						goto IL_B1;
					case 302:
						goto IL_4F;
					case 303:
						goto IL_7F;
					case 304:
						goto IL_C3;
					case 305:
						goto IL_111;
					default:
						num = 7;
						continue;
					}
					break;
				case 1:
					if (pageType >= 301)
					{
						num = 6;
						continue;
					}
					return;
				case 2:
					if (pageType != 0)
					{
						num = 3;
						continue;
					}
					return;
				case 3:
					if (true)
					{
					}
					num = 1;
					continue;
				case 4:
					if (pageType > 400)
					{
						num = 5;
						continue;
					}
					num = 0;
					continue;
				case 5:
					goto IL_7A;
				case 6:
					num = 4;
					continue;
				case 7:
					return;
				}
				break;
			}
		}
		IL_4F:
		A_0.PageResult = new ItemAttribRefSource_q(A_0.PageParams);
		return;
		IL_7A:
		return;
		IL_7F:
		A_0.PageResult = new ItemAttribQuery_q(A_0.PageParams);
		return;
		IL_B1:
		A_0.PageResult = new LimitPrice_q(A_0.PageParams);
		return;
		IL_C3:
		A_0.PageResult = new ImagePage_d(A_0.PageParams);
		return;
		IL_111:
		A_0.PageResult = new CommonRefSource_q(A_0.PageParams);
	}

	// Token: 0x04000374 RID: 884
	private const int ᜀ = 301;

	// Token: 0x04000375 RID: 885
	private const int ᜁ = 400;
}
