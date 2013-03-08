/*
 * Created by SharpDevelop.
 * User: alex.meyer
 * Date: 3/8/2013
 * Time: 9:48 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System.Windows.Forms;
using System.Diagnostics;
 
namespace FixAllTheThings
{
	partial class Shutdown
	{
		int timeleft = 10;
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(47, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(185, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Your computer will restart in:";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(64, 108);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(142, 54);
			this.button1.TabIndex = 2;
			this.button1.Text = "Abort Restart!";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(47, 54);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(171, 51);
			this.label3.TabIndex = 3;
			this.label3.Text = "10 seconds";
			// 
			// Shutdown
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(275, 191);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Name = "Shutdown";
			this.Text = "Shutdown";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		
		void Timer1Tick(object sender, System.EventArgs e)
		{
			label3.Text = timeleft.ToString()+" seconds";
			label3.Refresh();
			if(timeleft > 0){
				timeleft--;
				label3.Text = timeleft.ToString()+" seconds";
				label3.Refresh();
			}
			else{
				timer1.Stop();
				ProcessStartInfo proc = new ProcessStartInfo();
				proc.WindowStyle = ProcessWindowStyle.Hidden;
				proc.FileName = "cmd";
				proc.Arguments = "/C shutdown /f /r /t 0";
				Process.Start(proc);
			}
			
		}
		
		//Abort button
		void Button1Click(object sender, System.EventArgs e)
		{
			ProcessStartInfo proc = new ProcessStartInfo();
			proc.WindowStyle = ProcessWindowStyle.Hidden;
			proc.FileName = "cmd";
			proc.Arguments = "/C shutdown /a";
			Process.Start(proc);
			timer1.Stop();
			MessageBox.Show("Shutdown Aborted!");
			this.Dispose();
		}
	}
}
