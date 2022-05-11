namespace UTS_PV2
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxNim;
		private System.Windows.Forms.TextBox textBoxNama;
		private System.Windows.Forms.TextBox textBoxKom;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnInsert;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.TextBox textBoxIp1;
		private System.Windows.Forms.TextBox textBoxIp3;
		private System.Windows.Forms.TextBox textBoxIp2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBoxIpk;
		private System.Windows.Forms.Button btnCalc;
		private System.Windows.Forms.Button btnClear;
		
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxNim = new System.Windows.Forms.TextBox();
			this.textBoxNama = new System.Windows.Forms.TextBox();
			this.textBoxKom = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnInsert = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.textBoxIp1 = new System.Windows.Forms.TextBox();
			this.textBoxIp3 = new System.Windows.Forms.TextBox();
			this.textBoxIp2 = new System.Windows.Forms.TextBox();
			this.textBoxIpk = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.btnCalc = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.Location = new System.Drawing.Point(362, 126);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(404, 263);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.label1.Location = new System.Drawing.Point(188, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(333, 70);
			this.label1.TabIndex = 1;
			this.label1.Text = "Pangkalan Data Mahasiswa Prodi Ilmu Komputer 2020";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxNim
			// 
			this.textBoxNim.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxNim.Location = new System.Drawing.Point(145, 113);
			this.textBoxNim.Name = "textBoxNim";
			this.textBoxNim.Size = new System.Drawing.Size(176, 25);
			this.textBoxNim.TabIndex = 2;
			// 
			// textBoxNama
			// 
			this.textBoxNama.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxNama.Location = new System.Drawing.Point(145, 150);
			this.textBoxNama.Name = "textBoxNama";
			this.textBoxNama.Size = new System.Drawing.Size(176, 25);
			this.textBoxNama.TabIndex = 3;
			// 
			// textBoxKom
			// 
			this.textBoxKom.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxKom.Location = new System.Drawing.Point(145, 189);
			this.textBoxKom.Name = "textBoxKom";
			this.textBoxKom.Size = new System.Drawing.Size(176, 25);
			this.textBoxKom.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(54, 116);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "NIM";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(54, 152);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Nama";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(54, 192);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(45, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "KOM";
			// 
			// btnInsert
			// 
			this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnInsert.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnInsert.Location = new System.Drawing.Point(49, 357);
			this.btnInsert.Name = "btnInsert";
			this.btnInsert.Size = new System.Drawing.Size(75, 34);
			this.btnInsert.TabIndex = 8;
			this.btnInsert.Text = "INSERT";
			this.btnInsert.UseVisualStyleBackColor = false;
			this.btnInsert.Click += new System.EventHandler(this.BtnInsertClick);
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnUpdate.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdate.Location = new System.Drawing.Point(149, 356);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(75, 34);
			this.btnUpdate.TabIndex = 9;
			this.btnUpdate.Text = "UPDATE";
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.BtnUpdateClick);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.Red;
			this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnDelete.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnDelete.Location = new System.Drawing.Point(246, 355);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 34);
			this.btnDelete.TabIndex = 10;
			this.btnDelete.Text = "DELETE";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.BtnDeleteClick);
			// 
			// textBoxIp1
			// 
			this.textBoxIp1.Location = new System.Drawing.Point(79, 263);
			this.textBoxIp1.Name = "textBoxIp1";
			this.textBoxIp1.Size = new System.Drawing.Size(45, 20);
			this.textBoxIp1.TabIndex = 11;
			this.textBoxIp1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBoxIp3
			// 
			this.textBoxIp3.Location = new System.Drawing.Point(276, 263);
			this.textBoxIp3.Name = "textBoxIp3";
			this.textBoxIp3.Size = new System.Drawing.Size(45, 20);
			this.textBoxIp3.TabIndex = 12;
			this.textBoxIp3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBoxIp2
			// 
			this.textBoxIp2.Location = new System.Drawing.Point(179, 263);
			this.textBoxIp2.Name = "textBoxIp2";
			this.textBoxIp2.Size = new System.Drawing.Size(45, 20);
			this.textBoxIp2.TabIndex = 13;
			this.textBoxIp2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBoxIpk
			// 
			this.textBoxIpk.Location = new System.Drawing.Point(79, 314);
			this.textBoxIpk.Name = "textBoxIpk";
			this.textBoxIpk.Size = new System.Drawing.Size(45, 20);
			this.textBoxIpk.TabIndex = 14;
			this.textBoxIpk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(179, 237);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(45, 23);
			this.label5.TabIndex = 15;
			this.label5.Text = "IP2";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(79, 237);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(45, 23);
			this.label6.TabIndex = 16;
			this.label6.Text = "IP1";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(276, 237);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(45, 23);
			this.label7.TabIndex = 17;
			this.label7.Text = "IP3";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(79, 288);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(45, 23);
			this.label8.TabIndex = 18;
			this.label8.Text = "IPK";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnCalc
			// 
			this.btnCalc.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.btnCalc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCalc.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCalc.Location = new System.Drawing.Point(149, 311);
			this.btnCalc.Name = "btnCalc";
			this.btnCalc.Size = new System.Drawing.Size(75, 23);
			this.btnCalc.TabIndex = 19;
			this.btnCalc.Text = "CALC";
			this.btnCalc.UseVisualStyleBackColor = false;
			this.btnCalc.Click += new System.EventHandler(this.BtnCalcClick);
			// 
			// btnClear
			// 
			this.btnClear.BackColor = System.Drawing.Color.LightGray;
			this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClear.Location = new System.Drawing.Point(246, 311);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(75, 23);
			this.btnClear.TabIndex = 20;
			this.btnClear.Text = "CLEAR";
			this.btnClear.UseVisualStyleBackColor = false;
			this.btnClear.Click += new System.EventHandler(this.BtnClearClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(778, 411);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnCalc);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBoxIpk);
			this.Controls.Add(this.textBoxIp2);
			this.Controls.Add(this.textBoxIp3);
			this.Controls.Add(this.textBoxIp1);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnInsert);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxKom);
			this.Controls.Add(this.textBoxNama);
			this.Controls.Add(this.textBoxNim);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "MainForm";
			this.Text = "Database Akademik";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}