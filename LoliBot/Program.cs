/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2017-11-06
 * Time: 12:55
 * 
 */
using System;
using System.Windows.Forms;

namespace LoliBot
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
