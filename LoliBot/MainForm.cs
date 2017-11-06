/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2017-11-06
 * Time: 12:55
 * 
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Threading;

namespace LoliBot
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private Thread helperThread;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			this.webBrowser1.Url = new Uri(String.Format("file://{0}/content/home.html", 
			                                             Directory.GetCurrentDirectory()));
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		

		void OtakustreamToolStripMenuItemClick(object sender, EventArgs e)
		{	
			this.helperThread = new Thread(this.AnimeUpdateOtakustream);
			this.helperThread.Start();
		}
		
		private void AnimeUpdateOtakustream()
		{
			using(WebClient client = new WebClient())
			{
				int maxPage = 45;
//				this.toolStripProgressBar1.Maximum = maxPage;
				
				for(int i=1; i<=maxPage; i++)
				{
					try {
						this.toolStripStatusLabel1.Text = "Downloading anime info from otakustream.tv...\t\t\t"+
							i.ToString()+"/"+maxPage.ToString();
						string response = client.DownloadString("http://otakustream.tv/anime/page/"+i.ToString());
						
						string[] lines = response.Split(
						    new[] { "\r\n", "\r", "\n" },
						    StringSplitOptions.None
						);
						
						File.WriteAllLines("temp/otakustream"+i.ToString()+".html", lines);
						this.toolStripProgressBar1.Value = i;
					}
					catch(Exception ex) {
						this.toolStripStatusLabel1.Text = "Downloading anime info from otakustream, "+ex.Message;
						break;
					}
				}
				
			}	
		}
		
	}
}
