/*
 * Created by SharpDevelop.
 * User: alex.meyer
 * Date: 3/8/2013
 * Time: 9:48 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FixAllTheThings
{
	/// <summary>
	/// Description of Shutdown.
	/// </summary>
	public partial class Shutdown : Form
	{
		public Shutdown()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			timer1.Enabled = true;
			timer1.Start();
		}
		
		
	}
}
