using System;
using System.Runtime.CompilerServices;

// Token: 0x02000099 RID: 153
[CompilerGenerated]
internal sealed class ᜄ
{
	// Token: 0x0600056A RID: 1386 RVA: 0x00076D10 File Offset: 0x00074F10
	internal static uint ᜀ(string A_0)
	{
		int num = 5;
		uint num2;
		for (;;)
		{
			switch (num)
			{
			case 0:
				return num2;
			case 1:
				goto IL_3D;
			case 2:
				goto IL_3D;
			case 3:
			{
				int num3;
				if (num3 >= A_0.Length)
				{
					num = 0;
					continue;
				}
				num2 = ((uint)A_0[num3] ^ num2) * 16777619U;
				num3++;
				num = 1;
				continue;
			}
			case 4:
			{
				num2 = 2166136261U;
				int num3 = 0;
				num = 2;
				continue;
			}
			}
			if (A_0 != null)
			{
				if (true)
				{
				}
				num = 4;
				continue;
			}
			break;
			IL_3D:
			num = 3;
		}
		return num2;
	}
}
