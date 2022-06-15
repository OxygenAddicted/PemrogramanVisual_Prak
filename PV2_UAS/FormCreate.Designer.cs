/*
 * Created by SharpDevelop.
 * User: user
 * Date: 6/15/2022
 * Time: 7:37 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PV2_UAS
{
	partial class FormCreate
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox textBoxJabatan;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBoxDomisili;
		private System.Windows.Forms.TextBox textBoxNama;
		private System.Windows.Forms.TextBox textBoxNIP;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBoxJK;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnCreate;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreate));
			this.textBoxJabatan = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxDomisili = new System.Windows.Forms.TextBox();
			this.textBoxNama = new System.Windows.Forms.TextBox();
			this.textBoxNIP = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBoxJK = new System.Windows.Forms.ComboBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnCreate = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// textBoxJabatan
			// 
			this.textBoxJabatan.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxJabatan.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxJabatan.Location = new System.Drawing.Point(293, 217);
			this.textBoxJabatan.Name = "textBoxJabatan";
			this.textBoxJabatan.Size = new System.Drawing.Size(185, 25);
			this.textBoxJabatan.TabIndex = 27;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(171, 219);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(123, 23);
			this.label6.TabIndex = 26;
			this.label6.Text = "Jabatan            :";
			// 
			// textBoxDomisili
			// 
			this.textBoxDomisili.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxDomisili.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxDomisili.Location = new System.Drawing.Point(293, 135);
			this.textBoxDomisili.Name = "textBoxDomisili";
			this.textBoxDomisili.Size = new System.Drawing.Size(185, 25);
			this.textBoxDomisili.TabIndex = 23;
			// 
			// textBoxNama
			// 
			this.textBoxNama.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxNama.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxNama.Location = new System.Drawing.Point(293, 94);
			this.textBoxNama.Name = "textBoxNama";
			this.textBoxNama.Size = new System.Drawing.Size(185, 25);
			this.textBoxNama.TabIndex = 22;
			// 
			// textBoxNIP
			// 
			this.textBoxNIP.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxNIP.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxNIP.Location = new System.Drawing.Point(293, 53);
			this.textBoxNIP.Name = "textBoxNIP";
			this.textBoxNIP.Size = new System.Drawing.Size(185, 25);
			this.textBoxNIP.TabIndex = 21;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(171, 180);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(123, 23);
			this.label4.TabIndex = 20;
			this.label4.Text = "Jenis Kelamin  :";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(171, 139);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(123, 23);
			this.label3.TabIndex = 19;
			this.label3.Text = "Domisili            :";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(171, 98);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(123, 23);
			this.label2.TabIndex = 18;
			this.label2.Text = "Nama               :";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(171, 57);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(123, 23);
			this.label1.TabIndex = 17;
			this.label1.Text = "NIP                   :";
			// 
			// comboBoxJK
			// 
			this.comboBoxJK.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBoxJK.FormattingEnabled = true;
			this.comboBoxJK.Items.AddRange(new object[] {
			"Laki-laki",
			"Perempuan"});
			this.comboBoxJK.Location = new System.Drawing.Point(293, 177);
			this.comboBoxJK.Name = "comboBoxJK";
			this.comboBoxJK.Size = new System.Drawing.Size(185, 25);
			this.comboBoxJK.TabIndex = 30;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(22, 349);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(598, 192);
			this.dataGridView1.TabIndex = 31;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnDelete.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.Location = new System.Drawing.Point(459, 282);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(91, 49);
			this.btnDelete.TabIndex = 32;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.BtnDeleteClick);
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnUpdate.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdate.Location = new System.Drawing.Point(339, 282);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(91, 49);
			this.btnUpdate.TabIndex = 33;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.BtnUpdateClick);
			// 
			// btnCreate
			// 
			this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCreate.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCreate.Location = new System.Drawing.Point(216, 282);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(91, 49);
			this.btnCreate.TabIndex = 34;
			this.btnCreate.Text = "Create";
			this.btnCreate.UseVisualStyleBackColor = false;
			this.btnCreate.Click += new System.EventHandler(this.ButtonCreateClick);
			// 
			// btnClear
			// 
			this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnClear.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClear.Location = new System.Drawing.Point(98, 282);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(91, 49);
			this.btnClear.TabIndex = 35;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = false;
			this.btnClear.Click += new System.EventHandler(this.BtnClearClick);
			// 
			// FormCreate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(648, 561);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.comboBoxJK);
			this.Controls.Add(this.textBoxJabatan);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBoxDomisili);
			this.Controls.Add(this.textBoxNama);
			this.Controls.Add(this.textBoxNIP);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormCreate";
			this.Text = "FormCreate";
			this.Click += new System.EventHandler(this.ButtonCreateClick);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
