/*
 * Created by SharpDevelop.
 * User: alex.meyer
 * Date: 3/6/2013
 * Time: 2:28 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Security.Permissions;
using System.Security.Principal;

namespace FixAllTheThings
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			Shown += new EventHandler(Form1_Shown);
			backgroundWorker1.WorkerReportsProgress = true;
			backgroundWorker1.DoWork += new DoWorkEventHandler(doWork);
			backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(updateProgress);
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Form1_Shown(object sender, EventArgs e){
			backgroundWorker1.RunWorkerAsync();
		}
		
		void Label2Click(object sender, EventArgs e)
		{
			
		}
		
		//Restart Button
		void Button1Click(object sender, EventArgs e)
		{
			MessageBox.Show("Your computer will restart in 10 seconds");
			ProcessStartInfo proc = new ProcessStartInfo();
			proc.WindowStyle = ProcessWindowStyle.Hidden;
			proc.FileName = "cmd";
			proc.Arguments = "/C shutdown /f /r";
			System.Threading.Thread.Sleep(9000);
			Process.Start(proc);
		}
		
		//Screenshot Button
		void Button2Click(object sender, EventArgs e)
		{
			this.Hide();
			System.Threading.Thread.Sleep(200);
			string current = WindowsIdentity.GetCurrent().Name;
			string[] user_split = current.Split('\\');
			takeScreenshot().Save(@"C:\Users\"+user_split[1]+@"\Desktop\screenshot.bmp");
			System.Threading.Thread.Sleep(200);
			this.Show();
		}
		
		Bitmap takeScreenshot(){
			Bitmap screenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb);
			Graphics screenshotGraphics = Graphics.FromImage(screenshot);
			screenshotGraphics.CopyFromScreen(Screen.PrimaryScreen.Bounds.X,Screen.PrimaryScreen.Bounds.Y,0,0,Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);
			screenshotGraphics.Dispose();
			return screenshot;
		}
		
		void doWork(object sender, DoWorkEventArgs e){
			Random r = new Random();
			int i = r.Next(0,100);
			while(true){
				i = (i+5)%100;
				backgroundWorker1.ReportProgress(i);
				System.Threading.Thread.Sleep(100);
			}
		}
		
		void updateProgress(object sender, ProgressChangedEventArgs e){
			progressBar1.Value = e.ProgressPercentage;
		}
		
		//Ping Test
		void Button4Click(object sender, EventArgs e)
		{
			Ping ping = new Ping();
			PingReply reply = ping.Send("www.google.com");
			if(reply.Status == IPStatus.Success){
				MessageBox.Show("Ping response received\nInternet is Working!");
			}
			else{
				MessageBox.Show("No ping response...,\nNo Network Connectivity!");
			}
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			MessageBox.Show("Configuration Saved!");
		}
	}
}
