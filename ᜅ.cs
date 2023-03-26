using System;
using System.Data;
using System.Data.OleDb;
using TS.Win.Helper;

// Token: 0x02000093 RID: 147
internal class ᜅ
{
	// Token: 0x06000557 RID: 1367 RVA: 0x000759E8 File Offset: 0x00073BE8
	public static void ᜀ(string A_0, out DataTable A_1)
	{
		switch (0)
		{
		default:
		{
			if (true)
			{
			}
			A_1 = new DataTable();
			OleDbCommand oleDbCommand = null;
			OleDbDataAdapter oleDbDataAdapter = null;
			try
			{
				for (;;)
				{
					string connectionString = "";
					connectionString = ᜅ.ᜀ(true, A_0);
					int num = 15;
					for (;;)
					{
						string text;
						switch (num)
						{
						case 0:
							if (oleDbCommand == null)
							{
								num = 8;
								continue;
							}
							oleDbCommand.CommandText = text;
							num = 14;
							continue;
						case 1:
						{
							bool flag;
							if (flag)
							{
								num = 11;
								continue;
							}
							goto IL_23C;
						}
						case 2:
							goto IL_13C;
						case 3:
							oleDbDataAdapter = new OleDbDataAdapter(oleDbCommand);
							num = 10;
							continue;
						case 4:
							goto IL_18F;
						case 5:
							goto IL_23C;
						case 6:
							ᜅ.ᜀ.Open();
							num = 2;
							continue;
						case 7:
							goto IL_12A;
						case 8:
							oleDbCommand = new OleDbCommand(text, ᜅ.ᜀ);
							num = 7;
							continue;
						case 9:
							ᜅ.ᜀ = new OleDbConnection(connectionString);
							num = 19;
							continue;
						case 10:
							goto IL_18F;
						case 11:
							text = "select * from [Sheet1$]";
							oleDbCommand.CommandText = text;
							num = 16;
							continue;
						case 12:
							if (ᜅ.ᜀ.State != ConnectionState.Open)
							{
								num = 6;
								continue;
							}
							goto IL_13C;
						case 13:
							try
							{
								oleDbCommand.ExecuteNonQuery();
								bool flag = true;
								goto IL_F4;
							}
							catch
							{
								bool flag = false;
								goto IL_F4;
							}
							goto IL_23C;
							IL_F4:
							num = 1;
							continue;
						case 14:
							goto IL_12A;
						case 15:
							if (ᜅ.ᜀ == null)
							{
								num = 9;
								continue;
							}
							ᜅ.ᜀ.ConnectionString = connectionString;
							num = 17;
							continue;
						case 16:
							if (oleDbDataAdapter == null)
							{
								num = 3;
								continue;
							}
							oleDbDataAdapter.SelectCommand = oleDbCommand;
							num = 4;
							continue;
						case 17:
							goto IL_1DF;
						case 18:
							goto IL_248;
						case 19:
							goto IL_1DF;
						}
						break;
						IL_12A:
						num = 13;
						continue;
						IL_13C:
						text = "select 1 from [Sheet1$]";
						num = 0;
						continue;
						IL_18F:
						oleDbDataAdapter.Fill(A_1);
						num = 5;
						continue;
						IL_1DF:
						num = 12;
						continue;
						IL_23C:
						num = 18;
					}
				}
				IL_248:;
			}
			catch (Exception err)
			{
				WinFunction.DealWithError(err);
			}
			finally
			{
				int num = 1;
				for (;;)
				{
					switch (num)
					{
					case 0:
						oleDbCommand.Dispose();
						num = 5;
						continue;
					case 2:
						oleDbDataAdapter.Dispose();
						num = 7;
						continue;
					case 3:
						if (oleDbDataAdapter != null)
						{
							num = 2;
							continue;
						}
						goto IL_2D8;
					case 4:
						ᜅ.ᜀ.Close();
						num = 6;
						continue;
					case 5:
						goto IL_2B0;
					case 6:
						goto IL_2AE;
					case 7:
						goto IL_2D8;
					case 8:
						if (ᜅ.ᜀ.State != ConnectionState.Closed)
						{
							num = 4;
							continue;
						}
						goto IL_30F;
					}
					if (oleDbCommand != null)
					{
						num = 0;
						continue;
					}
					IL_2B0:
					num = 3;
					continue;
					IL_2D8:
					num = 8;
				}
				IL_2AE:
				IL_30F:;
			}
			return;
		}
		}
	}

	// Token: 0x06000558 RID: 1368 RVA: 0x00075D54 File Offset: 0x00073F54
	private static string ᜀ(bool A_0, string A_1)
	{
		if (true)
		{
		}
		return string.Concat(new string[]
		{
			"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=",
			A_1,
			";Extended Properties=\"Excel 8.0;Imex=",
			A_0 ? "1" : "2",
			";HDR=No;\""
		});
	}

	// Token: 0x0400036C RID: 876
	private static OleDbConnection ᜀ;
}
