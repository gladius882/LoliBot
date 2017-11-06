/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2017-11-06
 * Time: 12:55
 * 
 */
namespace LoliBot
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem animeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem downloadAnimeInfoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem otakustreamToolStripMenuItem;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
		private System.Windows.Forms.WebBrowser webBrowser1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.animeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.downloadAnimeInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.otakustreamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.webBrowser1 = new System.Windows.Forms.WebBrowser();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.animeToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(743, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// animeToolStripMenuItem
			// 
			this.animeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.downloadAnimeInfoToolStripMenuItem});
			this.animeToolStripMenuItem.Name = "animeToolStripMenuItem";
			this.animeToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
			this.animeToolStripMenuItem.Text = "Anime";
			// 
			// downloadAnimeInfoToolStripMenuItem
			// 
			this.downloadAnimeInfoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.otakustreamToolStripMenuItem});
			this.downloadAnimeInfoToolStripMenuItem.Name = "downloadAnimeInfoToolStripMenuItem";
			this.downloadAnimeInfoToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
			this.downloadAnimeInfoToolStripMenuItem.Text = "Download anime info";
			// 
			// otakustreamToolStripMenuItem
			// 
			this.otakustreamToolStripMenuItem.Name = "otakustreamToolStripMenuItem";
			this.otakustreamToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
			this.otakustreamToolStripMenuItem.Text = "otakustream";
			this.otakustreamToolStripMenuItem.Click += new System.EventHandler(this.OtakustreamToolStripMenuItemClick);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripProgressBar1,
			this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 316);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(743, 22);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripProgressBar1
			// 
			this.toolStripProgressBar1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripProgressBar1.Maximum = 45;
			this.toolStripProgressBar1.Name = "toolStripProgressBar1";
			this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
			this.toolStripStatusLabel1.Text = "Ready";
			// 
			// webBrowser1
			// 
			this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webBrowser1.Location = new System.Drawing.Point(0, 24);
			this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.Size = new System.Drawing.Size(743, 292);
			this.webBrowser1.TabIndex = 3;
			this.webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(743, 338);
			this.Controls.Add(this.webBrowser1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.KeyPreview = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "LoliBot";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
