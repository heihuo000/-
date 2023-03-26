using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using TS.Win.PageCommon.MTOptimize;
using TS.Win.PageCommon.PageCommonHelper;

// Token: 0x02000095 RID: 149
internal class ᜊ
{
	// Token: 0x0600055E RID: 1374 RVA: 0x00075E48 File Offset: 0x00074048
	internal static DataView ᜁ(DataTable A_0)
	{
		switch (0)
		{
		default:
		{
			string text;
			for (;;)
			{
				new DataTable();
				text = "";
				IEnumerator enumerator = A_0.Rows.GetEnumerator();
				if (true)
				{
				}
				int num = 2;
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_236;
					case 1:
						if (text == "")
						{
							num = 3;
							continue;
						}
						goto IL_238;
					case 2:
						try
						{
							num = 8;
							for (;;)
							{
								long num2;
								string text2;
								switch (num)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = 4;
										continue;
									}
									DataRow dataRow = (DataRow)enumerator.Current;
									num = 5;
									continue;
								}
								case 1:
									goto IL_ED;
								case 2:
									if (text != "")
									{
										num = 9;
										continue;
									}
									goto IL_ED;
								case 4:
									num = 6;
									continue;
								case 5:
								{
									DataRow dataRow;
									if (dataRow["ItemNCodeID"] != DBNull.Value)
									{
										num = 7;
										continue;
									}
									break;
								}
								case 6:
									goto IL_1D7;
								case 7:
								{
									DataRow dataRow;
									num2 = Convert.ToInt64(dataRow["ItemNCodeID"]);
									text2 = dataRow["ItemAttrib4"].ToString().TrimEnd(new char[0]);
									num = 2;
									continue;
								}
								case 9:
									text += " or ";
									num = 1;
									continue;
								}
								goto IL_B3;
								IL_ED:
								text = string.Concat(new object[]
								{
									text,
									"(ItemNCodeID = ",
									num2,
									" and ItemAttrib4='",
									text2,
									"')"
								});
								num = 3;
								continue;
								IL_131:
								num = 0;
								continue;
								IL_B3:
								goto IL_131;
							}
							IL_1D7:
							goto IL_52;
						}
						finally
						{
							for (;;)
							{
								IDisposable disposable = enumerator as IDisposable;
								num = 0;
								for (;;)
								{
									switch (num)
									{
									case 0:
										if (disposable != null)
										{
											num = 2;
											continue;
										}
										goto IL_223;
									case 1:
										goto IL_221;
									case 2:
										disposable.Dispose();
										num = 1;
										continue;
									}
									break;
								}
							}
							IL_221:
							IL_223:;
						}
						goto IL_224;
						IL_52:
						num = 1;
						continue;
					case 3:
						goto IL_224;
					}
					break;
					IL_224:
					text = "1<>1";
					num = 0;
				}
			}
			IL_236:
			IL_238:
			return ClientExcuteSQL.ExecuteViewQuery(229900, text);
		}
		}
	}

	// Token: 0x0600055F RID: 1375 RVA: 0x000760B4 File Offset: 0x000742B4
	internal static List<ᜀ> ᜀ(DataTable A_0)
	{
		switch (0)
		{
		default:
		{
			if (true)
			{
			}
			List<ᜀ> list = new List<ᜀ>();
			Dictionary<long, Dictionary<string, ᜀ>> dictionary = new Dictionary<long, Dictionary<string, ᜀ>>();
			A_0.DefaultView.Sort = "ItemNCodeID asc,ItemAttrib4 asc";
			A_0 = A_0.DefaultView.ToTable();
			IEnumerator enumerator = A_0.Rows.GetEnumerator();
			try
			{
				int num = 3;
				for (;;)
				{
					switch (num)
					{
					case 0:
					{
						if (!enumerator.MoveNext())
						{
							num = 6;
							continue;
						}
						DataRow dataRow = (DataRow)enumerator.Current;
						num = 7;
						continue;
					}
					case 1:
					{
						Dictionary<string, ᜀ> dictionary2;
						string text;
						if (dictionary2.ContainsKey(text))
						{
							num = 4;
							continue;
						}
						ᜀ ᜀ = new ᜀ();
						DataRow dataRow;
						ᜀ.ᜀ(dataRow);
						ᜀ.ᜃ = text;
						long num2;
						ᜀ.ᜀ = num2;
						string ᜂ;
						ᜀ.ᜂ = ᜂ;
						string ᜁ;
						ᜀ.ᜁ = ᜁ;
						dictionary2.Add(text, ᜀ);
						list.Add(ᜀ);
						num = 9;
						continue;
					}
					case 4:
					{
						DataRow dataRow;
						Dictionary<string, ᜀ> dictionary2;
						string text;
						dictionary2[text].ᜀ(dataRow);
						num = 11;
						continue;
					}
					case 5:
					{
						long num2;
						if (dictionary.ContainsKey(num2))
						{
							num = 8;
							continue;
						}
						Dictionary<string, ᜀ> dictionary3 = new Dictionary<string, ᜀ>();
						ᜀ ᜀ2 = new ᜀ();
						DataRow dataRow;
						ᜀ2.ᜀ(dataRow);
						string text;
						ᜀ2.ᜃ = text;
						ᜀ2.ᜀ = num2;
						string ᜂ;
						ᜀ2.ᜂ = ᜂ;
						string ᜁ;
						ᜀ2.ᜁ = ᜁ;
						dictionary3.Add(text, ᜀ2);
						dictionary.Add(num2, dictionary3);
						list.Add(ᜀ2);
						num = 2;
						continue;
					}
					case 6:
						num = 10;
						continue;
					case 7:
					{
						DataRow dataRow;
						if (dataRow["ItemNCodeID"] != DBNull.Value)
						{
							num = 12;
							continue;
						}
						break;
					}
					case 8:
					{
						long num2;
						Dictionary<string, ᜀ> dictionary2 = dictionary[num2];
						num = 1;
						continue;
					}
					case 10:
						goto IL_2A5;
					case 12:
					{
						DataRow dataRow;
						long num2 = Convert.ToInt64(dataRow["ItemNCodeID"]);
						string ᜂ = dataRow["ItemNCodeName"].ToString().TrimEnd(new char[0]);
						string ᜁ = dataRow["ItemNCode"].ToString().TrimEnd(new char[0]);
						string text = dataRow["ItemAttrib4"].ToString().TrimEnd(new char[0]);
						num = 5;
						continue;
					}
					}
					IL_222:
					num = 0;
					continue;
					goto IL_222;
				}
				IL_2A5:;
			}
			finally
			{
				for (;;)
				{
					IDisposable disposable = enumerator as IDisposable;
					int num = 0;
					for (;;)
					{
						switch (num)
						{
						case 0:
							if (disposable != null)
							{
								num = 1;
								continue;
							}
							goto IL_2EE;
						case 1:
							disposable.Dispose();
							num = 2;
							continue;
						case 2:
							goto IL_2EC;
						}
						break;
					}
				}
				IL_2EC:
				IL_2EE:;
			}
			return list;
		}
		}
	}

	// Token: 0x06000560 RID: 1376 RVA: 0x000763D0 File Offset: 0x000745D0
	internal static void ᜀ(DataTable A_0, ᜀ A_1)
	{
		switch (0)
		{
		default:
		{
			int num = 5;
			for (;;)
			{
				DataTable dataTable;
				IEnumerator enumerator3;
				switch (num)
				{
				case 0:
					try
					{
						num = 5;
						for (;;)
						{
							switch (num)
							{
							case 0:
							{
								List<CuttingDistribute> list;
								try
								{
									num = 1;
									for (;;)
									{
										int key;
										int num6;
										Dictionary<int, int>.Enumerator enumerator2;
										switch (num)
										{
										case 0:
											try
											{
												DataView dataView;
												dataView.RowFilter = "ItemLength=" + key;
												IEnumerator enumerator = dataView.GetEnumerator();
												try
												{
													num = 14;
													for (;;)
													{
														int num2;
														int num3;
														int num4;
														int num5;
														string detailCoding;
														switch (num)
														{
														case 0:
															num2 = 0;
															goto IL_2F9;
														case 1:
														{
															DataRowView dataRowView;
															num3 = Convert.ToInt32(dataRowView["ItemQty"]);
															goto IL_254;
														}
														case 2:
															num = 9;
															continue;
														case 3:
															num = 1;
															continue;
														case 4:
														{
															if (num4 - num5 < num6)
															{
																num = 7;
																continue;
															}
															DataRowView dataRowView;
															dataRowView["DistributeCount"] = num6;
															num6 = 0;
															num = 10;
															continue;
														}
														case 5:
														{
															DataRowView dataRowView;
															if (dataRowView["ItemQty"] != DBNull.Value)
															{
																num = 3;
																continue;
															}
															num = 11;
															continue;
														}
														case 6:
														{
															if (!enumerator.MoveNext())
															{
																num = 2;
																continue;
															}
															DataRowView dataRowView = (DataRowView)enumerator.Current;
															detailCoding = dataRowView["DetailCoding"].ToString().TrimEnd(new char[0]);
															num = 5;
															continue;
														}
														case 7:
														{
															DataRowView dataRowView;
															dataRowView["DistributeCount"] = num4 - num5;
															num6 -= num4 - num5;
															num = 15;
															continue;
														}
														case 8:
														{
															DataRowView dataRowView;
															if (dataRowView["DistributeCount"] != DBNull.Value)
															{
																num = 13;
																continue;
															}
															num = 0;
															continue;
														}
														case 9:
															goto IL_380;
														case 10:
															goto IL_324;
														case 11:
															num3 = 0;
															goto IL_254;
														case 12:
														{
															DataRowView dataRowView;
															num2 = Convert.ToInt32(dataRowView["DistributeCount"]);
															goto IL_2F9;
														}
														case 13:
															num = 12;
															continue;
														case 15:
															goto IL_324;
														}
														goto IL_1AA;
														IL_254:
														num4 = num3;
														num = 8;
														continue;
														IL_2D3:
														num = 6;
														continue;
														IL_1AA:
														goto IL_2D3;
														IL_2F9:
														num5 = num2;
														num = 4;
														continue;
														IL_324:
														list.Add(new CuttingDistribute
														{
															DetailCoding = detailCoding,
															MeterialLength = key
														});
														num = 16;
													}
													IL_380:
													break;
												}
												finally
												{
													for (;;)
													{
														IDisposable disposable = enumerator as IDisposable;
														num = 1;
														for (;;)
														{
															switch (num)
															{
															case 0:
																goto IL_3CB;
															case 1:
																if (disposable != null)
																{
																	num = 2;
																	continue;
																}
																goto IL_3CD;
															case 2:
																disposable.Dispose();
																num = 0;
																continue;
															}
															break;
														}
													}
													IL_3CB:
													IL_3CD:;
												}
											}
											finally
											{
												num = 0;
												for (;;)
												{
													DataView dataView;
													switch (num)
													{
													case 1:
														goto IL_40B;
													case 2:
														((IDisposable)dataView).Dispose();
														num = 1;
														continue;
													}
													if (dataView == null)
													{
														break;
													}
													num = 2;
												}
												IL_40B:;
											}
											goto IL_40E;
										case 2:
											num = 6;
											continue;
										case 3:
										{
											DataView dataView = new DataView(dataTable);
											num = 0;
											continue;
										}
										case 4:
											if (num6 > 0)
											{
												num = 3;
												continue;
											}
											break;
										case 5:
											if (!enumerator2.MoveNext())
											{
												num = 2;
												continue;
											}
											goto IL_40E;
										case 6:
											goto IL_496;
										}
										goto IL_12C;
										IL_40E:
										KeyValuePair<int, int> keyValuePair = enumerator2.Current;
										key = keyValuePair.Key;
										num6 = keyValuePair.Value;
										num = 4;
										continue;
										IL_464:
										num = 5;
										continue;
										IL_12C:
										goto IL_464;
									}
									IL_496:
									goto IL_E4;
								}
								finally
								{
									Dictionary<int, int>.Enumerator enumerator2;
									((IDisposable)enumerator2).Dispose();
								}
								goto IL_4A9;
								IL_E4:
								DataRow dataRow;
								dataRow["CuttingDistribute"] = list;
								num = 2;
								continue;
							}
							case 1:
							{
								if (!enumerator3.MoveNext())
								{
									num = 4;
									continue;
								}
								DataRow dataRow = (DataRow)enumerator3.Current;
								List<CuttingDistribute> list = new List<CuttingDistribute>();
								Dictionary<int, int>.Enumerator enumerator2 = (dataRow["CutProject"] as Dictionary<int, int>).GetEnumerator();
								num = 0;
								continue;
							}
							case 3:
								goto IL_4B5;
							case 4:
								goto IL_4A9;
							}
							IL_8E:
							num = 1;
							continue;
							goto IL_8E;
							IL_4A9:
							num = 3;
						}
						IL_4B5:
						return;
					}
					finally
					{
						for (;;)
						{
							IDisposable disposable = enumerator3 as IDisposable;
							num = 0;
							for (;;)
							{
								switch (num)
								{
								case 0:
									if (disposable != null)
									{
										num = 2;
										continue;
									}
									goto IL_501;
								case 1:
									goto IL_4FF;
								case 2:
									disposable.Dispose();
									num = 1;
									continue;
								}
								break;
							}
						}
						IL_4FF:
						IL_501:;
					}
					goto IL_502;
				case 1:
					if (true)
					{
					}
					goto IL_502;
				case 2:
					if (!dataTable.Columns.Contains("DistributeCount"))
					{
						num = 1;
						continue;
					}
					goto IL_597;
				case 3:
					goto IL_554;
				case 4:
					A_0.Columns.Add("CuttingDistribute", typeof(List<CuttingDistribute>));
					num = 3;
					continue;
				case 6:
					goto IL_597;
				}
				if (!A_0.Columns.Contains("CuttingDistribute"))
				{
					num = 4;
					continue;
				}
				goto IL_554;
				IL_502:
				dataTable.Columns.Add("DistributeCount", typeof(int));
				num = 6;
				continue;
				IL_554:
				dataTable = A_1.ᜆ.Copy();
				num = 2;
				continue;
				IL_597:
				enumerator3 = A_0.Rows.GetEnumerator();
				num = 0;
			}
			return;
		}
		}
	}
}
