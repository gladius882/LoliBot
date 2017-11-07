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
using System.Threading.Tasks;

namespace LoliBot
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private Thread helperThread = null;
		
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
				
				for(int i=1; i<=maxPage; i++)
				{
//					try {
					updateStatusLabel("Downloading anime info from otakustream.tv...\t\t\t"+
					                  i.ToString()+"/"+maxPage.ToString());
					
						string response = client.DownloadString("http://otakustream.tv/anime/page/"+i.ToString());
						
						string[] lines = response.Split(
						    new[] { "\r\n", "\r", "\n" },
						    StringSplitOptions.None
						);
						
						File.WriteAllLines("temp/otakustream"+i.ToString()+".html", lines);
						
						
						updateProgressBar(i);
//					}
//					catch(Exception ex) {
//						MessageBox.Show(ex.Message, "Unexpeected error while downloading anime info",
//						                MessageBoxButtons.OK, MessageBoxIcon.Error);
//						
//						this.toolStripStatusLabel1.Text = "Error, "+ex.Message;
//						break;
//					}
				}
				
			}	
		}
		
		private void AbortToolStripMenuItemClick(object sender, EventArgs e)
		{
			try {
				if(this.helperThread != null)
					this.helperThread.Abort();
				this.toolStripStatusLabel1.Text = "Aborted";
			}
			catch(Exception ex) {
				this.toolStripStatusLabel1.Text = ex.Message;
			}
		}
		
		private void updateStatusLabel(string text)
		{
			if(this.statusStrip1.InvokeRequired)
			{
				this.statusStrip1.Invoke(
					new MethodInvoker( () => this.toolStripStatusLabel1.Text = text));
			}
			else
			{
				this.toolStripStatusLabel1.Text = text;
			}
		}
		
		private void updateProgressBar(int value, int max = 0)
		{
			if(max != 0)
			{
				if(this.statusStrip1.InvokeRequired)
				{
					this.statusStrip1.Invoke(
						new MethodInvoker( () => this.toolStripProgressBar1.Maximum = max));
				}
				else
				{
					this.toolStripProgressBar1.Maximum = max;
				}
			}
			
			if(this.statusStrip1.InvokeRequired)
			{
				this.statusStrip1.Invoke(
					new MethodInvoker( () => this.toolStripProgressBar1.Value = value));
			}
			else
			{
				this.toolStripProgressBar1.Value = value;
			}
		}
		
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			Environment.Exit(0);
		}

	}
}
