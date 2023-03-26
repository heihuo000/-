using System;
using System.Security.Cryptography;
using System.Text;

// Token: 0x0200008D RID: 141
internal class ᜆ
{
	// Token: 0x0600054A RID: 1354 RVA: 0x0007573C File Offset: 0x0007393C
	public static string ᜀ(string A_0, string A_1)
	{
		switch (0)
		{
		default:
		{
			StringBuilder stringBuilder;
			for (;;)
			{
				if (true)
				{
				}
				string text = "TutorSoftWareGuideSystem";
				string[] array = new string[]
				{
					text,
					A_0,
					A_1
				};
				stringBuilder = new StringBuilder();
				int num = 0;
				int num2 = array.Length;
				int num3 = 3;
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_77;
					case 1:
						if (num >= num2)
						{
							num3 = 0;
							continue;
						}
						stringBuilder.Append(array[num]);
						num++;
						num3 = 2;
						continue;
					case 2:
						goto IL_60;
					case 3:
						goto IL_60;
					}
					break;
					IL_60:
					num3 = 1;
				}
			}
			IL_77:
			return ᜆ.ᜀ(stringBuilder.ToString());
		}
		}
	}

	// Token: 0x0600054B RID: 1355 RVA: 0x000757E8 File Offset: 0x000739E8
	public static string ᜀ(string A_0)
	{
		if (true)
		{
		}
		SHA1CryptoServiceProvider sha1CryptoServiceProvider = new SHA1CryptoServiceProvider();
		byte[] bytes = Encoding.UTF8.GetBytes(A_0);
		byte[] inArray = sha1CryptoServiceProvider.ComputeHash(bytes);
		sha1CryptoServiceProvider.Clear();
		((IDisposable)sha1CryptoServiceProvider).Dispose();
		return Convert.ToBase64String(inArray);
	}
}
