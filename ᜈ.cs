using System;
using TS.Win.AppConfig;

// Token: 0x02000094 RID: 148
internal class ᜈ
{
	// Token: 0x0600055B RID: 1371 RVA: 0x00075DC0 File Offset: 0x00073FC0
	internal static long ᜁ()
	{
		string text;
		Settings.GetConfigValue("LeavingMeterialHeader", out text);
		if (!(text == ""))
		{
			if (true)
			{
			}
			return Convert.ToInt64(text);
		}
		return 0L;
	}

	// Token: 0x0600055C RID: 1372 RVA: 0x00075DFC File Offset: 0x00073FFC
	internal static int ᜀ()
	{
		string text;
		Settings.GetConfigValue("CuttingSew", out text);
		if (!(text == ""))
		{
			if (true)
			{
			}
			return Convert.ToInt32(text);
		}
		return 0;
	}
}
