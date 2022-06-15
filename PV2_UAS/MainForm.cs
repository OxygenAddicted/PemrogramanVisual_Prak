using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.IO;
using System.Drawing.Imaging;

namespace PV2_UAS
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		public MainForm()
		{
			InitializeComponent();
		}
		
		void CloseToolStripMenuItemClick(object sender, EventArgs e)
		{
			// Asking for user confirmation before exit
			if (MessageBox.Show("Are you sure want to exit and close the application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				Application.Exit();
			}
		}
	
		void InsertToolStripMenuItemClick(object sender, EventArgs e) // For MDI settings. MdiParent (MainForm.cs) and FormChild (FormCreate.cs).
		{
			IsMdiContainer = true;
			FormCreate fc = new FormCreate();
			fc.MdiParent = this;
			fc.Show();
		}
		
		void CascadeToolStripMenuItemClick(object sender, EventArgs e) // Turn forms into Cascade style.
		{
			this.LayoutMdi(MdiLayout.Cascade);
		}
		
		void HorizontalToolStripMenuItemClick(object sender, EventArgs e) // Turn forms into Horizontal style.
		{
			 this.LayoutMdi(MdiLayout.TileHorizontal);
		}
		
		void VerticalToolStripMenuItemClick(object sender, EventArgs e) // Turn forms into Vertical style.
		{
			this.LayoutMdi(MdiLayout.TileVertical);
		}		
		
	}
}
