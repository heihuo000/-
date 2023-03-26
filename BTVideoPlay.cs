using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using TS.Data.Contants;
using TS.Win.Data;
using TS.Win.Helper;
using TS.Win.PageCommon.HelperCenter;
using TS.Win.Styles;

namespace TS.Win.BT
{
	// Token: 0x02000026 RID: 38
	public partial class BTVideoPlay : Form
	{
		// Token: 0x06000188 RID: 392 RVA: 0x00026144 File Offset: 0x00024344
		public BTVideoPlay(string strVideoPath, long lTutorialsClassifyNo)
		{
			this.ᜀ();
			this.ᜀ = strVideoPath;
			this.ᜁ = lTutorialsClassifyNo;
			if (lTutorialsClassifyNo == 0L)
			{
				this.ᜆ.Visible = false;
				base.Width = 1080;
			}
			this.ᜀ(this.ᜁ);
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00026198 File Offset: 0x00024398
		private void ᜁ(object A_0, EventArgs A_1)
		{
			try
			{
				if (true)
				{
				}
				this.ᜅ.Url = new Uri(this.ᜀ);
				ImageList imageList = new ImageList();
				imageList.Images.Add(Sheet.GetDocumentImage("Document_022G"));
				this.ᜇ.LargeImageList = imageList;
			}
			catch (Exception err)
			{
				WinFunction.DealWithError(err);
			}
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00026204 File Offset: 0x00024404
		private DataView ᜁ(long A_0)
		{
			if (true)
			{
			}
			int errorDataBase = 0;
			enDataProxyError errorDataProxy = enDataProxyError.NoError;
			string errorDescription = "";
			int selectType = 1012000;
			DataView onePage = WSSynCaller.GetOnePage(0, 0, false, false, selectType, "TutorialsClassifyNo in (" + A_0 + ")", ref errorDataBase, ref errorDataProxy, ref errorDescription);
			WinFunction.ParseDBReturn(errorDataBase, errorDataProxy, errorDescription);
			return onePage;
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00026258 File Offset: 0x00024458
		private void ᜀ(long A_0)
		{
			switch (0)
			{
			default:
				for (;;)
				{
					this.ᜇ.Clear();
					int num = 5;
					for (;;)
					{
						switch (num)
						{
						case 0:
							goto IL_54;
						case 1:
						{
							int num2;
							int count;
							if (num2 >= count)
							{
								num = 2;
								continue;
							}
							DataView dataView;
							DataRowView dataRowView = dataView[num2];
							ListViewItem listViewItem = new ListViewItem(dataRowView["TutorialsRealName"].ToString().Trim());
							listViewItem.ImageIndex = 0;
							listViewItem.Tag = dataRowView;
							this.ᜇ.Items.Add(listViewItem);
							num2++;
							num = 3;
							continue;
						}
						case 2:
							return;
						case 3:
							goto IL_54;
						case 4:
						{
							if (true)
							{
							}
							DataView dataView = this.ᜁ(A_0);
							int num2 = 0;
							int count = dataView.Count;
							num = 0;
							continue;
						}
						case 5:
							if (A_0 != 0L)
							{
								num = 4;
								continue;
							}
							return;
						}
						break;
						IL_54:
						num = 1;
					}
				}
				return;
			}
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00026358 File Offset: 0x00024558
		private void ᜀ(object A_0, EventArgs A_1)
		{
			try
			{
				switch (0)
				{
				default:
				{
					int num = 0;
					for (;;)
					{
						switch (num)
						{
						case 1:
						{
							string text;
							string a_;
							this.ᜀ(text, a_);
							num = 4;
							continue;
						}
						case 2:
						{
							string text;
							this.ᜅ.Url = new Uri(text);
							num = 3;
							continue;
						}
						case 3:
							goto IL_179;
						case 4:
							goto IL_65;
						case 5:
						{
							DataRowView dataRowView = this.ᜇ.SelectedItems[0].Tag as DataRowView;
							string a_;
							BTVideoTutorialsUpload.PerformDownloadAction(Convert.ToInt64(dataRowView["TutorialsInfoID"]), out a_);
							dataRowView["TutorialsPath"].ToString().TrimEnd(new char[0]);
							string str = dataRowView["TutorialsName"].ToString().TrimEnd(new char[0]);
							dataRowView["TutorialsExtension"].ToString().TrimEnd(new char[0]);
							string text = Path.GetTempPath() + str + ".html";
							num = 8;
							continue;
						}
						case 6:
							goto IL_185;
						case 7:
						{
							string text;
							if (File.Exists(text))
							{
								num = 2;
								continue;
							}
							goto IL_179;
						}
						case 8:
						{
							string text;
							if (!File.Exists(text))
							{
								num = 1;
								continue;
							}
							goto IL_65;
						}
						}
						if (this.ᜇ.SelectedItems.Count > 0)
						{
							num = 5;
							continue;
						}
						goto IL_179;
						IL_65:
						num = 7;
						continue;
						IL_179:
						num = 6;
					}
					IL_185:
					break;
				}
				}
			}
			catch (Exception err)
			{
				WinFunction.DealWithError(err);
			}
			if (true)
			{
			}
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00026518 File Offset: 0x00024718
		private void ᜀ(string A_0, string A_1)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(this.ᜀ(A_1));
			try
			{
				StreamWriter streamWriter = new StreamWriter(A_0, false, Encoding.GetEncoding("UTF-8"));
				try
				{
					if (true)
					{
					}
					streamWriter.WriteLine(stringBuilder);
					streamWriter.Flush();
					streamWriter.Close();
				}
				finally
				{
					int num = 2;
					for (;;)
					{
						switch (num)
						{
						case 0:
							goto IL_7E;
						case 1:
							((IDisposable)streamWriter).Dispose();
							num = 0;
							continue;
						}
						if (streamWriter == null)
						{
							break;
						}
						num = 1;
					}
					IL_7E:;
				}
			}
			catch
			{
				WinFunction.ShowNormalMessage("生成失败");
			}
		}

		// Token: 0x0600018E RID: 398 RVA: 0x000265D4 File Offset: 0x000247D4
		private string ᜀ(string A_0)
		{
			if (true)
			{
			}
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("<HTML>");
			stringBuilder.Append("<HEAD>");
			stringBuilder.Append("<!-- saved from url=(0013)about:internet -->");
			stringBuilder.Append("<TITLE>");
			stringBuilder.Append("</TITLE>");
			stringBuilder.Append("</HEAD>");
			stringBuilder.Append("<BODY style='font-family: arial; font-size: 9pt; background-color: #FFFFFF'>");
			stringBuilder.Append("<OBJECT classid='clsid:D27CDB6E-AE6D-11cf-96B8-444553540000'codebase='http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=9,0,0,28;' WIDTH=956 HEIGHT=561>");
			stringBuilder.Append("<PARAM NAME=movie VALUE='" + A_0 + "'> ");
			stringBuilder.Append("<PARAM NAME=quality VALUE=high>");
			stringBuilder.Append("<PARAM NAME=bgcolor VALUE='#FFFFFF'>");
			stringBuilder.Append("<param name='allowFullScreen'value='true' >");
			stringBuilder.Append("<EMBED src='MapPath' allowfullscreen='true' quality=high bgcolor='#FFFFFF'  WIDTH=956 HEIGHT=561 TYPE='application/x-shockwave-flash' PLUGINSPAGE='http://www.macromedia.com/shockwave/download/index.cgi?P1_Prod_Version=ShockwaveFlash'>");
			stringBuilder.Append("</EMBED>");
			stringBuilder.Append("</BODY>");
			stringBuilder.Append("</HTML>");
			return stringBuilder.ToString();
		}

		// Token: 0x06000190 RID: 400 RVA: 0x0002673C File Offset: 0x0002493C
		private void ᜀ()
		{
			if (true)
			{
			}
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(BTVideoPlay));
			this.ᜃ = new Splitter();
			this.ᜄ = new GroupBox();
			this.ᜅ = new WebBrowser();
			this.ᜆ = new GroupBox();
			this.ᜇ = new ListView();
			this.ᜄ.SuspendLayout();
			this.ᜆ.SuspendLayout();
			base.SuspendLayout();
			this.ᜃ.Location = new Point(158, 0);
			this.ᜃ.Name = "splitter1";
			this.ᜃ.Size = new Size(3, 650);
			this.ᜃ.TabIndex = 3;
			this.ᜃ.TabStop = false;
			this.ᜄ.Controls.Add(this.ᜅ);
			this.ᜄ.Dock = DockStyle.Fill;
			this.ᜄ.Location = new Point(161, 0);
			this.ᜄ.Name = "groupBox2";
			this.ᜄ.Size = new Size(1031, 650);
			this.ᜄ.TabIndex = 4;
			this.ᜄ.TabStop = false;
			this.ᜄ.Text = "视频播放区域";
			this.ᜅ.Dock = DockStyle.Fill;
			this.ᜅ.Location = new Point(3, 17);
			this.ᜅ.MinimumSize = new Size(20, 20);
			this.ᜅ.Name = "webBrowser1";
			this.ᜅ.ScrollBarsEnabled = false;
			this.ᜅ.Size = new Size(1025, 630);
			this.ᜅ.TabIndex = 0;
			this.ᜆ.Controls.Add(this.ᜇ);
			this.ᜆ.Dock = DockStyle.Left;
			this.ᜆ.Location = new Point(0, 0);
			this.ᜆ.Name = "groupBox1";
			this.ᜆ.Size = new Size(158, 650);
			this.ᜆ.TabIndex = 5;
			this.ᜆ.TabStop = false;
			this.ᜆ.Text = "视频播放文件";
			this.ᜇ.Dock = DockStyle.Fill;
			this.ᜇ.ForeColor = SystemColors.Desktop;
			this.ᜇ.Location = new Point(3, 17);
			this.ᜇ.Name = "listView1";
			this.ᜇ.Size = new Size(152, 630);
			this.ᜇ.TabIndex = 0;
			this.ᜇ.UseCompatibleStateImageBehavior = false;
			this.ᜇ.View = View.Tile;
			this.ᜇ.DoubleClick += this.ᜀ;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(1192, 650);
			base.Controls.Add(this.ᜄ);
			base.Controls.Add(this.ᜃ);
			base.Controls.Add(this.ᜆ);
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "BTVideoPlay";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "视频播放窗口";
			base.Load += this.ᜁ;
			this.ᜄ.ResumeLayout(false);
			this.ᜆ.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x040000EE RID: 238
		private string ᜀ;

		// Token: 0x040000EF RID: 239
		private long ᜁ;

		// Token: 0x040000F1 RID: 241
		private Splitter ᜃ;

		// Token: 0x040000F2 RID: 242
		private GroupBox ᜄ;

		// Token: 0x040000F3 RID: 243
		private WebBrowser ᜅ;

		// Token: 0x040000F4 RID: 244
		private GroupBox ᜆ;

		// Token: 0x040000F5 RID: 245
		private ListView ᜇ;
	}
}
