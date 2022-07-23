/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 22/7/2022
 * Time: 23:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace claseAgreComp
{
	partial class VentanaListaAsegurados
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaListaAsegurados));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dataGridViewListaAsegurados = new System.Windows.Forms.DataGridView();
			this.idAsegurado = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Paterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Materno = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaAsegurados)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(218)))), ((int)(((byte)(222)))));
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(428, 69);
			this.panel1.TabIndex = 2;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(352, 7);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(58, 56);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(23, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(370, 50);
			this.label1.TabIndex = 0;
			this.label1.Text = "LISTA DE ASEGURADOS";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(218)))), ((int)(((byte)(222)))));
			this.panel2.Controls.Add(this.dataGridViewListaAsegurados);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 69);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(428, 332);
			this.panel2.TabIndex = 3;
			// 
			// dataGridViewListaAsegurados
			// 
			this.dataGridViewListaAsegurados.AllowUserToAddRows = false;
			this.dataGridViewListaAsegurados.AllowUserToDeleteRows = false;
			this.dataGridViewListaAsegurados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridViewListaAsegurados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridViewListaAsegurados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewListaAsegurados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.idAsegurado,
									this.Nombre,
									this.Paterno,
									this.Materno,
									this.Nacimiento});
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewListaAsegurados.DefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridViewListaAsegurados.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewListaAsegurados.Location = new System.Drawing.Point(0, 0);
			this.dataGridViewListaAsegurados.Name = "dataGridViewListaAsegurados";
			this.dataGridViewListaAsegurados.ReadOnly = true;
			this.dataGridViewListaAsegurados.Size = new System.Drawing.Size(428, 332);
			this.dataGridViewListaAsegurados.TabIndex = 0;
			// 
			// idAsegurado
			// 
			this.idAsegurado.Frozen = true;
			this.idAsegurado.HeaderText = "idAsegurado";
			this.idAsegurado.Name = "idAsegurado";
			this.idAsegurado.ReadOnly = true;
			this.idAsegurado.Width = 91;
			// 
			// Nombre
			// 
			this.Nombre.Frozen = true;
			this.Nombre.HeaderText = "Nombre";
			this.Nombre.Name = "Nombre";
			this.Nombre.ReadOnly = true;
			this.Nombre.Width = 69;
			// 
			// Paterno
			// 
			this.Paterno.Frozen = true;
			this.Paterno.HeaderText = "Paterno";
			this.Paterno.Name = "Paterno";
			this.Paterno.ReadOnly = true;
			this.Paterno.Width = 69;
			// 
			// Materno
			// 
			this.Materno.Frozen = true;
			this.Materno.HeaderText = "Materno";
			this.Materno.Name = "Materno";
			this.Materno.ReadOnly = true;
			this.Materno.Width = 71;
			// 
			// Nacimiento
			// 
			this.Nacimiento.Frozen = true;
			this.Nacimiento.HeaderText = "Nacimiento";
			this.Nacimiento.Name = "Nacimiento";
			this.Nacimiento.ReadOnly = true;
			this.Nacimiento.Width = 85;
			// 
			// VentanaListaAsegurados
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(428, 401);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "VentanaListaAsegurados";
			this.Text = "VentanaListaAsegurados";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaAsegurados)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn Nacimiento;
		private System.Windows.Forms.DataGridViewTextBoxColumn Materno;
		private System.Windows.Forms.DataGridViewTextBoxColumn Paterno;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn idAsegurado;
		private System.Windows.Forms.DataGridView dataGridViewListaAsegurados;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
	}
}
