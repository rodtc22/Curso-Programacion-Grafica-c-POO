/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 23/7/2022
 * Time: 23:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace clasePersistencia
{
	partial class VentanaInquilino
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaInquilino));
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridViewInquilinos = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Paterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Materno = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CI = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Contrato = new System.Windows.Forms.DataGridViewButtonColumn();
			this.buttonEliminaInquilino = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewInquilinos)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(73)))), ((int)(((byte)(64)))));
			this.panel1.Controls.Add(this.buttonEliminaInquilino);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(674, 74);
			this.panel1.TabIndex = 2;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(12, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(67, 64);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(101, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(377, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "Lista de Inquilinos";
			// 
			// dataGridViewInquilinos
			// 
			this.dataGridViewInquilinos.AllowUserToAddRows = false;
			this.dataGridViewInquilinos.AllowUserToDeleteRows = false;
			this.dataGridViewInquilinos.AllowUserToResizeColumns = false;
			this.dataGridViewInquilinos.AllowUserToResizeRows = false;
			this.dataGridViewInquilinos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridViewInquilinos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewInquilinos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridViewInquilinos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewInquilinos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID,
									this.Nombre,
									this.Paterno,
									this.Materno,
									this.CI,
									this.Nacimiento,
									this.Contrato});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewInquilinos.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewInquilinos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewInquilinos.Location = new System.Drawing.Point(0, 74);
			this.dataGridViewInquilinos.Name = "dataGridViewInquilinos";
			this.dataGridViewInquilinos.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewInquilinos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridViewInquilinos.Size = new System.Drawing.Size(674, 309);
			this.dataGridViewInquilinos.TabIndex = 3;
			this.dataGridViewInquilinos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewInquilinosCellContentClick);
			// 
			// ID
			// 
			this.ID.Frozen = true;
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Width = 48;
			// 
			// Nombre
			// 
			this.Nombre.Frozen = true;
			this.Nombre.HeaderText = "Nombre";
			this.Nombre.Name = "Nombre";
			this.Nombre.ReadOnly = true;
			this.Nombre.Width = 93;
			// 
			// Paterno
			// 
			this.Paterno.Frozen = true;
			this.Paterno.HeaderText = "Paterno";
			this.Paterno.Name = "Paterno";
			this.Paterno.ReadOnly = true;
			this.Paterno.Width = 90;
			// 
			// Materno
			// 
			this.Materno.Frozen = true;
			this.Materno.HeaderText = "Materno";
			this.Materno.Name = "Materno";
			this.Materno.ReadOnly = true;
			this.Materno.Width = 94;
			// 
			// CI
			// 
			this.CI.Frozen = true;
			this.CI.HeaderText = "CI";
			this.CI.Name = "CI";
			this.CI.ReadOnly = true;
			this.CI.Width = 48;
			// 
			// Nacimiento
			// 
			this.Nacimiento.Frozen = true;
			this.Nacimiento.HeaderText = "Nacimiento";
			this.Nacimiento.Name = "Nacimiento";
			this.Nacimiento.ReadOnly = true;
			this.Nacimiento.Width = 116;
			// 
			// Contrato
			// 
			this.Contrato.Frozen = true;
			this.Contrato.HeaderText = "Contrato";
			this.Contrato.Name = "Contrato";
			this.Contrato.ReadOnly = true;
			this.Contrato.Text = "Ver";
			this.Contrato.UseColumnTextForButtonValue = true;
			this.Contrato.Width = 80;
			// 
			// buttonEliminaInquilino
			// 
			this.buttonEliminaInquilino.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEliminaInquilino.BackgroundImage")));
			this.buttonEliminaInquilino.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonEliminaInquilino.FlatAppearance.BorderSize = 0;
			this.buttonEliminaInquilino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonEliminaInquilino.Location = new System.Drawing.Point(609, 12);
			this.buttonEliminaInquilino.Name = "buttonEliminaInquilino";
			this.buttonEliminaInquilino.Size = new System.Drawing.Size(42, 48);
			this.buttonEliminaInquilino.TabIndex = 2;
			this.buttonEliminaInquilino.UseVisualStyleBackColor = true;
			this.buttonEliminaInquilino.Click += new System.EventHandler(this.ButtonEliminaInquilinoClick);
			// 
			// VentanaInquilino
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(674, 383);
			this.Controls.Add(this.dataGridViewInquilinos);
			this.Controls.Add(this.panel1);
			this.Name = "VentanaInquilino";
			this.Text = "VentanaInquilino";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewInquilinos)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button buttonEliminaInquilino;
		private System.Windows.Forms.DataGridViewButtonColumn Contrato;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nacimiento;
		private System.Windows.Forms.DataGridViewTextBoxColumn CI;
		private System.Windows.Forms.DataGridViewTextBoxColumn Materno;
		private System.Windows.Forms.DataGridViewTextBoxColumn Paterno;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridView dataGridViewInquilinos;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
	}
}
