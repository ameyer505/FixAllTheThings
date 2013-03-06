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
			
		}
		
		//Screenshot Button
		void Button2Click(object sender, EventArgs e)
		{
			
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
	}
}
