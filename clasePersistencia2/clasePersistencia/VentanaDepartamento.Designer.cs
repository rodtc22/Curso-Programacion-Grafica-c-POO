/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 24/7/2022
 * Time: 00:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace clasePersistencia
{
	partial class VentanaDepartamento
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaDepartamento));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.buttonEditar = new System.Windows.Forms.Button();
			this.pictureBoxPanelSecreto = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panelSecreto = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.buttonFiltrar = new System.Windows.Forms.Button();
			this.textBoxFiltrar = new System.Windows.Forms.TextBox();
			this.dataGridViewDepartamentos = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Superficie = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tipo = new System.Windows.Forms.DataGridViewImageColumn();
			this.Opcion = new System.Windows.Forms.DataGridViewButtonColumn();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPanelSecreto)).BeginInit();
			this.panelSecreto.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartamentos)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(73)))), ((int)(((byte)(64)))));
			this.panel1.Controls.Add(this.buttonEditar);
			this.panel1.Controls.Add(this.pictureBoxPanelSecreto);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(605, 74);
			this.panel1.TabIndex = 3;
			// 
			// buttonEditar
			// 
			this.buttonEditar.BackColor = System.Drawing.Color.Red;
			this.buttonEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEditar.BackgroundImage")));
			this.buttonEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonEditar.FlatAppearance.BorderSize = 0;
			this.buttonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonEditar.Location = new System.Drawing.Point(552, 15);
			this.buttonEditar.Name = "buttonEditar";
			this.buttonEditar.Size = new System.Drawing.Size(41, 38);
			this.buttonEditar.TabIndex = 2;
			this.buttonEditar.UseVisualStyleBackColor = false;
			this.buttonEditar.Click += new System.EventHandler(this.ButtonEditarClick);
			// 
			// pictureBoxPanelSecreto
			// 
			this.pictureBoxPanelSecreto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxPanelSecreto.BackgroundImage")));
			this.pictureBoxPanelSecreto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBoxPanelSecreto.Location = new System.Drawing.Point(12, 3);
			this.pictureBoxPanelSecreto.Name = "pictureBoxPanelSecreto";
			this.pictureBoxPanelSecreto.Size = new System.Drawing.Size(67, 64);
			this.pictureBoxPanelSecreto.TabIndex = 1;
			this.pictureBoxPanelSecreto.TabStop = false;
			this.pictureBoxPanelSecreto.Click += new System.EventHandler(this.PictureBoxPanelSecretoClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(101, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(377, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "Lista de Departamentos";
			// 
			// panelSecreto
			// 
			this.panelSecreto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(73)))), ((int)(((byte)(64)))));
			this.panelSecreto.Controls.Add(this.panel4);
			this.panelSecreto.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelSecreto.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panelSecreto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
			this.panelSecreto.Location = new System.Drawing.Point(0, 74);
			this.panelSecreto.Name = "panelSecreto";
			this.panelSecreto.Size = new System.Drawing.Size(605, 32);
			this.panelSecreto.TabIndex = 4;
			this.panelSecreto.Visible = false;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(73)))), ((int)(((byte)(64)))));
			this.panel4.Controls.Add(this.buttonFiltrar);
			this.panel4.Controls.Add(this.textBoxFiltrar);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel4.Location = new System.Drawing.Point(357, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(248, 32);
			this.panel4.TabIndex = 0;
			// 
			// buttonFiltrar
			// 
			this.buttonFiltrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonFiltrar.BackgroundImage")));
			this.buttonFiltrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonFiltrar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonFiltrar.Location = new System.Drawing.Point(204, 0);
			this.buttonFiltrar.Name = "buttonFiltrar";
			this.buttonFiltrar.Size = new System.Drawing.Size(44, 32);
			this.buttonFiltrar.TabIndex = 1;
			this.buttonFiltrar.UseVisualStyleBackColor = true;
			// 
			// textBoxFiltrar
			// 
			this.textBoxFiltrar.Dock = System.Windows.Forms.DockStyle.Left;
			this.textBoxFiltrar.Location = new System.Drawing.Point(0, 0);
			this.textBoxFiltrar.Name = "textBoxFiltrar";
			this.textBoxFiltrar.Size = new System.Drawing.Size(204, 41);
			this.textBoxFiltrar.TabIndex = 0;
			// 
			// dataGridViewDepartamentos
			// 
			this.dataGridViewDepartamentos.AllowUserToAddRows = false;
			this.dataGridViewDepartamentos.AllowUserToDeleteRows = false;
			this.dataGridViewDepartamentos.AllowUserToResizeColumns = false;
			this.dataGridViewDepartamentos.AllowUserToResizeRows = false;
			this.dataGridViewDepartamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridViewDepartamentos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewDepartamentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridViewDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewDepartamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID,
									this.Costo,
									this.Superficie,
									this.Tipo,
									this.Opcion});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewDepartamentos.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewDepartamentos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewDepartamentos.Location = new System.Drawing.Point(0, 106);
			this.dataGridViewDepartamentos.Name = "dataGridViewDepartamentos";
			this.dataGridViewDepartamentos.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewDepartamentos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridViewDepartamentos.Size = new System.Drawing.Size(605, 317);
			this.dataGridViewDepartamentos.TabIndex = 5;
			this.dataGridViewDepartamentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewDepartamentosCellContentClick);
			// 
			// ID
			// 
			this.ID.Frozen = true;
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Width = 48;
			// 
			// Costo
			// 
			this.Costo.Frozen = true;
			this.Costo.HeaderText = "Costo";
			this.Costo.Name = "Costo";
			this.Costo.ReadOnly = true;
			this.Costo.Width = 77;
			// 
			// Superficie
			// 
			this.Superficie.Frozen = true;
			this.Superficie.HeaderText = "Superficie";
			this.Superficie.Name = "Superficie";
			this.Superficie.ReadOnly = true;
			this.Superficie.Width = 106;
			// 
			// Tipo
			// 
			this.Tipo.Frozen = true;
			this.Tipo.HeaderText = "Tipo";
			this.Tipo.Name = "Tipo";
			this.Tipo.ReadOnly = true;
			this.Tipo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Tipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.Tipo.Width = 67;
			// 
			// Opcion
			// 
			this.Opcion.Frozen = true;
			this.Opcion.HeaderText = "Opcion";
			this.Opcion.Name = "Opcion";
			this.Opcion.ReadOnly = true;
			this.Opcion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Opcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.Opcion.Text = "Alquilar";
			this.Opcion.UseColumnTextForButtonValue = true;
			this.Opcion.Width = 86;
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "depatipo0.jpg");
			this.imageList1.Images.SetKeyName(1, "depatipo1.jpg");
			this.imageList1.Images.SetKeyName(2, "depatitpo2.jpg");
			this.imageList1.Images.SetKeyName(3, "depatipo3.jpg");
			this.imageList1.Images.SetKeyName(4, "depatipo4.jpg");
			this.imageList1.Images.SetKeyName(5, "depatipo5.jpg");
			// 
			// VentanaDepartamento
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(605, 423);
			this.Controls.Add(this.dataGridViewDepartamentos);
			this.Controls.Add(this.panelSecreto);
			this.Controls.Add(this.panel1);
			this.Name = "VentanaDepartamento";
			this.Text = "VentanaDepartamento";
			this.Load += new System.EventHandler(this.VentanaDepartamentoLoad);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPanelSecreto)).EndInit();
			this.panelSecreto.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartamentos)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button buttonEditar;
		private System.Windows.Forms.DataGridViewButtonColumn Opcion;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.DataGridViewImageColumn Tipo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Superficie;
		private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridView dataGridViewDepartamentos;
		private System.Windows.Forms.TextBox textBoxFiltrar;
		private System.Windows.Forms.Button buttonFiltrar;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panelSecreto;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBoxPanelSecreto;
		private System.Windows.Forms.Panel panel1;
	}
}
