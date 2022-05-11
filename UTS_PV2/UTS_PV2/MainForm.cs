using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace UTS_PV2
{
	
	public partial class MainForm : Form
	{
		MySqlConnection co = new MySqlConnection(@"server=localhost; userid=root ; password=; database=akademik2;");
		MySqlCommand mycommand = new MySqlCommand();
		MySqlDataAdapter myadapter = new MySqlDataAdapter();
		public MainForm()
		{
			InitializeComponent();
			co.Open();
			ReadData();
		}
		
		public void ReadData() //Reading data from the table then write them in dataGridView
		{
			try{
				DataTable dt = new DataTable();
				mycommand.Connection = co;
				myadapter.SelectCommand = mycommand;
				mycommand.CommandText = "select * from data_mahasiswa";
				MySqlDataReader reader = mycommand.ExecuteReader();
				dt.Load(reader);
				
				if (dt.Rows.Count > 0)
				{
					dataGridView1.DataSource = dt;
				}
				//Setting the columns width
				dataGridView1.Columns[2].Width = 43;
				dataGridView1.Columns[3].Width = 40;
				dataGridView1.Columns[4].Width = 40;
				dataGridView1.Columns[5].Width = 40;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		
		public void InsertData() //Inserting new data to the table
		{
			try
			{
				mycommand.Connection=co;
				mycommand.CommandText="insert into data_mahasiswa values('"+textBoxNim.Text+"','"+textBoxNama.Text+"','"+textBoxKom.Text+"', '"+textBoxIp1.Text+"', '"+textBoxIp2.Text+"', '"+textBoxIp3.Text+"')";
				myadapter.SelectCommand= mycommand;
				if (mycommand.ExecuteNonQuery()==1)
				{
					MessageBox.Show("Data berhasil dimasukan","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
					ReadData();
					}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		
		public void UpdateData() //Updating data from the table
		{
			try{
				mycommand.CommandText = "update data_mahasiswa set nim='"+textBoxNim.Text+"',nama='"+textBoxNama.Text+"',kom='"+textBoxKom.Text+"',ip1='"+textBoxIp1.Text+"',ip2='"+textBoxIp2.Text+"',ip3='"+textBoxIp3.Text+"' where nim ='"+textBoxNim.Text+"'";
				myadapter.SelectCommand = mycommand;
				if (mycommand.ExecuteNonQuery()==1)
				{
					MessageBox.Show("Data berhasil diupdate","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
					ReadData();
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		
		public void DeleteData() //Deleting data from the table
		{
			try
			{
				mycommand.CommandText="delete from data_mahasiswa where nim='"+textBoxNim.Text+"'";
				myadapter.SelectCommand = mycommand;
				if (mycommand.ExecuteNonQuery() == 1)
				{
					MessageBox.Show("Data berhasil dihapus","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
					ReadData();
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		
		public void mean()
		{
			try
			{
				mycommand.CommandText = "select ip1, ip2, ip3 from data_mahasiswa where nim='"+textBoxNim.Text+"'";
				MySqlDataReader reader = mycommand.ExecuteReader();
				
				while (reader.Read())
				{
					float ip1 = (float) reader["ip1"];
					float ip2 = (float) reader["ip2"];
					float ip3 = (float) reader["ip3"];
					float ipk = (ip1+ip2+ip3)/3;
					textBoxIpk.Text = ipk.ToString("0.00");
				}
				
				reader.Close();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		
		public bool dbOpen()
		{
			try
			{
				co.Open();
			}
			catch
			{
				MessageBox.Show("Tidak Terhubung");
				return false;
			}
			return true;
		}
		
		void BtnInsertClick(object sender, EventArgs e)
		{
			InsertData();
		}
		
		void BtnUpdateClick(object sender, EventArgs e)
		{
			UpdateData();
		}
		
		void BtnDeleteClick(object sender, EventArgs e)
		{
			DeleteData();
		}
		
		void BtnCalcClick(object sender, EventArgs e)
		{
			mean();
		}
		void BtnClearClick(object sender, EventArgs e)
		{
			textBoxIpk.Text = "";
		}
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			textBoxNim.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
			textBoxNama.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			textBoxKom.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
			textBoxIp1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
			textBoxIp2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
			textBoxIp3.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
		}
		
	}
}