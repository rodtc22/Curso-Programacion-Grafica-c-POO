/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 23/7/2022
 * Time: 00:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace claseAgreComp
{
	partial class VentanaDoctor
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaDoctor));
			this.panel2 = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.buttonAgregar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxIdAsegurado = new System.Windows.Forms.TextBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
			this.labelNroCitas = new System.Windows.Forms.Label();
			this.dataGridViewListaCitas = new System.Windows.Forms.DataGridView();
			this.idAsegurado = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Reservado = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.labelDoctor = new System.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaCitas)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(218)))), ((int)(((byte)(222)))));
			this.panel2.Controls.Add(this.groupBox1);
			this.panel2.Controls.Add(this.labelNroCitas);
			this.panel2.Controls.Add(this.dataGridViewListaCitas);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel2.Location = new System.Drawing.Point(0, 69);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(669, 352);
			this.panel2.TabIndex = 5;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.buttonAgregar);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.textBoxIdAsegurado);
			this.groupBox1.Controls.Add(this.dateTimePicker1);
			this.groupBox1.Controls.Add(this.monthCalendar1);
			this.groupBox1.Location = new System.Drawing.Point(384, 22);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(258, 308);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Agregar Citas";
			// 
			// buttonAgregar
			// 
			this.buttonAgregar.Location = new System.Drawing.Point(165, 271);
			this.buttonAgregar.Name = "buttonAgregar";
			this.buttonAgregar.Size = new System.Drawing.Size(87, 31);
			this.buttonAgregar.TabIndex = 4;
			this.buttonAgregar.Text = "Agregar";
			this.buttonAgregar.UseVisualStyleBackColor = true;
			this.buttonAgregar.Click += new System.EventHandler(this.ButtonAgregar);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 244);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(79, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "IdAsegurado";
			// 
			// textBoxIdAsegurado
			// 
			this.textBoxIdAsegurado.Location = new System.Drawing.Point(93, 244);
			this.textBoxIdAsegurado.Name = "textBoxIdAsegurado";
			this.textBoxIdAsegurado.Size = new System.Drawing.Size(159, 23);
			this.textBoxIdAsegurado.TabIndex = 2;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dateTimePicker1.Location = new System.Drawing.Point(165, 202);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.ShowUpDown = true;
			this.dateTimePicker1.Size = new System.Drawing.Size(87, 23);
			this.dateTimePicker1.TabIndex = 1;
			// 
			// monthCalendar1
			// 
			this.monthCalendar1.Location = new System.Drawing.Point(4, 28);
			this.monthCalendar1.Name = "monthCalendar1";
			this.monthCalendar1.TabIndex = 0;
			// 
			// labelNroCitas
			// 
			this.labelNroCitas.Location = new System.Drawing.Point(13, 7);
			this.labelNroCitas.Name = "labelNroCitas";
			this.labelNroCitas.Size = new System.Drawing.Size(100, 23);
			this.labelNroCitas.TabIndex = 1;
			this.labelNroCitas.Text = "label1";
			// 
			// dataGridViewListaCitas
			// 
			this.dataGridViewListaCitas.AllowUserToAddRows = false;
			this.dataGridViewListaCitas.AllowUserToDeleteRows = false;
			this.dataGridViewListaCitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridViewListaCitas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridViewListaCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewListaCitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.idAsegurado,
									this.Dia,
									this.Hora,
									this.Reservado});
			this.dataGridViewListaCitas.Location = new System.Drawing.Point(13, 33);
			this.dataGridViewListaCitas.Name = "dataGridViewListaCitas";
			this.dataGridViewListaCitas.ReadOnly = true;
			this.dataGridViewListaCitas.Size = new System.Drawing.Size(348, 284);
			this.dataGridViewListaCitas.TabIndex = 0;
			// 
			// idAsegurado
			// 
			this.idAsegurado.Frozen = true;
			this.idAsegurado.HeaderText = "idAsegurado";
			this.idAsegurado.Name = "idAsegurado";
			this.idAsegurado.ReadOnly = true;
			this.idAsegurado.Width = 102;
			// 
			// Dia
			// 
			this.Dia.Frozen = true;
			this.Dia.HeaderText = "Dia";
			this.Dia.Name = "Dia";
			this.Dia.ReadOnly = true;
			this.Dia.Width = 52;
			// 
			// Hora
			// 
			this.Hora.Frozen = true;
			this.Hora.HeaderText = "Hora";
			this.Hora.Name = "Hora";
			this.Hora.ReadOnly = true;
			this.Hora.Width = 60;
			// 
			// Reservado
			// 
			this.Reservado.Frozen = true;
			this.Reservado.HeaderText = "Reservado";
			this.Reservado.Name = "Reservado";
			this.Reservado.ReadOnly = true;
			this.Reservado.Width = 92;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.labelDoctor);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(218)))), ((int)(((byte)(222)))));
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(669, 69);
			this.panel1.TabIndex = 4;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(597, 7);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(58, 56);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// labelDoctor
			// 
			this.labelDoctor.Location = new System.Drawing.Point(12, 7);
			this.labelDoctor.Name = "labelDoctor";
			this.labelDoctor.Size = new System.Drawing.Size(569, 50);
			this.labelDoctor.TabIndex = 0;
			this.labelDoctor.Text = "Doctor";
			// 
			// VentanaDoctor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(669, 421);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "VentanaDoctor";
			this.Text = "VentanaDoctor";
			this.panel2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaCitas)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.MonthCalendar monthCalendar1;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.TextBox textBoxIdAsegurado;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonAgregar;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Reservado;
		private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
		private System.Windows.Forms.DataGridViewTextBoxColumn Dia;
		private System.Windows.Forms.Label labelNroCitas;
		private System.Windows.Forms.Label labelDoctor;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridViewTextBoxColumn idAsegurado;
		private System.Windows.Forms.DataGridView dataGridViewListaCitas;
		private System.Windows.Forms.Panel panel2;
	}
}
