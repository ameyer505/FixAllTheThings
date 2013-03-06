/*
 * Created by SharpDevelop.
 * User: alex.meyer
 * Date: 3/6/2013
 * Time: 2:28 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace FixAllTheThings
{
	partial class MainForm
	{
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.label1 = new System.Windows.Forms.Label();
			this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.label3 = new System.Windows.Forms.Label();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(22, 194);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(168, 50);
			this.button1.TabIndex = 0;
			this.button1.Text = "Restart Computer";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(237, 194);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(168, 50);
			this.button2.TabIndex = 1;
			this.button2.Text = "Take Screenshot";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(237, 127);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(168, 50);
			this.button3.TabIndex = 2;
			this.button3.Text = "Save Configuration";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// trackBar1
			// 
			this.trackBar1.Location = new System.Drawing.Point(22, 32);
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(190, 45);
			this.trackBar1.TabIndex = 3;
			this.trackBar1.Value = 5;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(60, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = "Buffer Override:";
			// 
			// checkedListBox1
			// 
			this.checkedListBox1.FormattingEnabled = true;
			this.checkedListBox1.Items.AddRange(new object[] {
									"Reset RAM Timings",
									"Lower CPU Voltage",
									"Full Power on Front Side Bus",
									"Reset Server",
									"Force Multi-Threaded Execution"});
			this.checkedListBox1.Location = new System.Drawing.Point(229, 19);
			this.checkedListBox1.Name = "checkedListBox1";
			this.checkedListBox1.Size = new System.Drawing.Size(176, 79);
			this.checkedListBox1.TabIndex = 5;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
									"0 %",
									"10 %",
									"20 %",
									"30 %",
									"40 %",
									"50 %",
									"60 %",
									"70 %",
									"80 %",
									"90 %",
									"100%",
									"MAX",
									"ULTRA-MAX"});
			this.comboBox1.Location = new System.Drawing.Point(22, 156);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(190, 21);
			this.comboBox1.TabIndex = 6;
			this.comboBox1.SelectedIndex = 5;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(82, 127);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 23);
			this.label2.TabIndex = 7;
			this.label2.Text = "DOS:";
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(22, 101);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(190, 23);
			this.progressBar1.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(31, 75);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(159, 23);
			this.label3.TabIndex = 9;
			this.label3.Text = "Hard Drive Crash Prevention:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(429, 258);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.checkedListBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.trackBar1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "MainForm";
			this.Text = "FixAllTheThings";
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.CheckedListBox checkedListBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
	}
}
