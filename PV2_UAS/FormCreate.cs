using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Text;
using System.Data.OleDb;
using MySql.Data.MySqlClient;

namespace PV2_UAS
{
	/// <summary>
	/// Description of FormCreate.
	/// </summary>
	public partial class FormCreate : Form
	{
			
		// Connection to database stuff.
		
		MySqlConnection conn = new MySqlConnection
			(@"server = localhost; userid = root; password = ; database = dbkantor;");
		MySqlCommand mycommand = new MySqlCommand();
		MySqlDataAdapter myadapter = new MySqlDataAdapter();
		
		public FormCreate()
		{
			InitializeComponent();
			conn.Open(); // Opening access to database.
			ReadData();
		}
		
		public void ReadData() //Reading data from the table then write them in dataGridView
		{
			try{
				DataTable dt = new DataTable();
				mycommand.Connection = conn;
				myadapter.SelectCommand = mycommand;
				mycommand.CommandText = "SELECT * FROM data_pegawai";
				MySqlDataReader reader = mycommand.ExecuteReader();
				dt.Load(reader);
				
				if (dt.Rows.Count > 0)
				{
					dataGridView1.DataSource = dt;
				}
				 dataGridView1.Columns[1].Width = 158; // Setting Nama column width.
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e) // Put all data in the datagridview to textboxes.
		{
			textBoxNIP.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
			textBoxNama.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			textBoxDomisili.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
			comboBoxJK.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
			textBoxJabatan.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
		}
		
		void BtnClearClick(object sender, EventArgs e) // Clear the textboxes.
		{
			textBoxNIP.Clear();
			textBoxNama.Clear();
			textBoxDomisili.Clear();
			textBoxJabatan.Clear();
		}
		
		void ButtonCreateClick(object sender, EventArgs e) // Create new data.
		{
            try
			{
				mycommand.Connection = conn;
				mycommand.CommandText = "INSERT INTO data_pegawai VALUES('"+textBoxNIP.Text+"','"+textBoxNama.Text+"','"+textBoxDomisili.Text+"', '"+comboBoxJK.Text+"', '"+textBoxJabatan.Text+"')";
				myadapter.SelectCommand = mycommand;
				if (mycommand.ExecuteNonQuery() == 1)
				{
					MessageBox.Show("Data created successfully","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
					ReadData();
					}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
            
        }
		
		void BtnUpdateClick(object sender, EventArgs e) // Update existing data.
		{
			try{
				mycommand.Connection = conn;
				mycommand.CommandText = "UPDATE data_pegawai SET NIP='"+textBoxNIP.Text+"',Nama='"+textBoxNama.Text+"',Domisili='"+textBoxDomisili.Text+"',Jenis_Kelamin='"+comboBoxJK.Text+"',Jabatan='"+textBoxJabatan.Text+"' WHERE NIP = '" + textBoxNIP.Text + "'";
				myadapter.SelectCommand = mycommand;
				if (mycommand.ExecuteNonQuery() == 1)
				{
					MessageBox.Show("Data updated succesfully","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
					ReadData();
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		
		void BtnDeleteClick(object sender, EventArgs e) // Delete a data.
		{
			try
			{
				if (MessageBox.Show("Are you sure to delete "+ textBoxNIP.Text + " " + textBoxNama.Text + "?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
				{
					mycommand.CommandText ="DELETE FROM data_pegawai where NIP='"+textBoxNIP.Text+"'";
					myadapter.SelectCommand = mycommand;
					if (mycommand.ExecuteNonQuery() == 1)
					{
						MessageBox.Show("Data deleted successfully","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
						ReadData();
					}
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		
		
		
		
	}
}
