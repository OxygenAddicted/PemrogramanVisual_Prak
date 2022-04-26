/*
 * Created by SharpDevelop.
 * User: user
 * Date: 4/26/2022
 * Time: 9:41 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace Tugas1_PV2
{
	
	public partial class MainForm : Form
	{
		MySqlConnection co = new MySqlConnection(@"server=localhost; userid=root ; password=; database=akademik;");
		MySqlCommand mycommand = new MySqlCommand();
		MySqlDataAdapter myadapter = new MySqlDataAdapter();
		public MainForm()
		{
			InitializeComponent();
			co.Open();
			ReadData();
		}
		
		public void ReadData()
		{
			try{
				mycommand.Connection = co;
				myadapter.SelectCommand = mycommand;
				mycommand.CommandText = "select * from data_mahasiswa";
				DataSet ds = new DataSet();
				
				if (myadapter.Fill(ds,"dftpesan")>0)
				{
					dataGridView1.DataSource = ds;
					dataGridView1.DataMember = "dftpesan";
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		
		public void InsertData()
		{
			try
			{
				mycommand.Connection=co;
				mycommand.CommandText="insert into data_mahasiswa values('"+textBoxNim.Text+"','"+textBoxNama.Text+"','"+textBoxKom.Text+"')";
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
		
		public void UpdateData()
		{
			try{
				mycommand.CommandText = "update data_mahasiswa set nim='"+textBoxNim.Text+"',nama='"+textBoxNama.Text+"',kom='"+textBoxKom.Text+"' where nim ='"+textBoxNim.Text+"'";
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
		
		public void DeleteData()
		{
			try
			{
				mycommand.CommandText="delete from data_mahasiswa where nim='"+textBoxNim.Text+"'";
				myadapter.SelectCommand = mycommand;
				if (mycommand.ExecuteNonQuery()==1)
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
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			textBoxNim.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
			textBoxNama.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			textBoxKom.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
		}
		
	}
}
