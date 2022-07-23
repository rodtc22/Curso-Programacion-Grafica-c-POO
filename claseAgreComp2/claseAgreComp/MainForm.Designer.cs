/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 22/7/2022
 * Time: 13:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace claseAgreComp
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.panel16 = new System.Windows.Forms.Panel();
			this.panel17 = new System.Windows.Forms.Panel();
			this.buttonEliminarDoctor = new System.Windows.Forms.Button();
			this.panel18 = new System.Windows.Forms.Panel();
			this.panel13 = new System.Windows.Forms.Panel();
			this.panel14 = new System.Windows.Forms.Panel();
			this.buttonAtiende = new System.Windows.Forms.Button();
			this.panel15 = new System.Windows.Forms.Panel();
			this.panel10 = new System.Windows.Forms.Panel();
			this.panel11 = new System.Windows.Forms.Panel();
			this.buttonAgregarAsegurados = new System.Windows.Forms.Button();
			this.panel12 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.panel8 = new System.Windows.Forms.Panel();
			this.buttonAgregarDoctor = new System.Windows.Forms.Button();
			this.panel9 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.buttonMostrarAsegurados = new System.Windows.Forms.Button();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.labelConsola = new System.Windows.Forms.Label();
			this.dataGridViewListaDoctores = new System.Windows.Forms.DataGridView();
			this.idDoctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ver = new System.Windows.Forms.DataGridViewButtonColumn();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel19 = new System.Windows.Forms.Panel();
			this.textBoxEspecialidad = new System.Windows.Forms.TextBox();
			this.buttonFiltrar = new System.Windows.Forms.Button();
			this.labeldirector = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.panel16.SuspendLayout();
			this.panel13.SuspendLayout();
			this.panel10.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaDoctores)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel19.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 92);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(100)))));
			this.splitContainer1.Panel1.Controls.Add(this.panel16);
			this.splitContainer1.Panel1.Controls.Add(this.panel13);
			this.splitContainer1.Panel1.Controls.Add(this.panel10);
			this.splitContainer1.Panel1.Controls.Add(this.panel7);
			this.splitContainer1.Panel1.Controls.Add(this.panel4);
			this.splitContainer1.Panel1.Controls.Add(this.panel2);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(218)))), ((int)(((byte)(222)))));
			this.splitContainer1.Panel2.Controls.Add(this.dataGridViewListaDoctores);
			this.splitContainer1.Size = new System.Drawing.Size(578, 330);
			this.splitContainer1.SplitterDistance = 154;
			this.splitContainer1.TabIndex = 2;
			// 
			// panel16
			// 
			this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(100)))));
			this.panel16.Controls.Add(this.panel17);
			this.panel16.Controls.Add(this.buttonEliminarDoctor);
			this.panel16.Controls.Add(this.panel18);
			this.panel16.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel16.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel16.Location = new System.Drawing.Point(0, 230);
			this.panel16.Name = "panel16";
			this.panel16.Size = new System.Drawing.Size(154, 46);
			this.panel16.TabIndex = 7;
			// 
			// panel17
			// 
			this.panel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
			this.panel17.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel17.Location = new System.Drawing.Point(144, 0);
			this.panel17.Name = "panel17";
			this.panel17.Size = new System.Drawing.Size(10, 46);
			this.panel17.TabIndex = 2;
			// 
			// buttonEliminarDoctor
			// 
			this.buttonEliminarDoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
			this.buttonEliminarDoctor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonEliminarDoctor.FlatAppearance.BorderSize = 0;
			this.buttonEliminarDoctor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(218)))), ((int)(((byte)(222)))));
			this.buttonEliminarDoctor.Location = new System.Drawing.Point(10, 0);
			this.buttonEliminarDoctor.Name = "buttonEliminarDoctor";
			this.buttonEliminarDoctor.Size = new System.Drawing.Size(144, 46);
			this.buttonEliminarDoctor.TabIndex = 0;
			this.buttonEliminarDoctor.Text = "Eliminar Doctor";
			this.buttonEliminarDoctor.UseVisualStyleBackColor = false;
			this.buttonEliminarDoctor.Click += new System.EventHandler(this.ButtonEliminarDoctorClick);
			// 
			// panel18
			// 
			this.panel18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
			this.panel18.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel18.Location = new System.Drawing.Point(0, 0);
			this.panel18.Name = "panel18";
			this.panel18.Size = new System.Drawing.Size(10, 46);
			this.panel18.TabIndex = 1;
			// 
			// panel13
			// 
			this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(100)))));
			this.panel13.Controls.Add(this.panel14);
			this.panel13.Controls.Add(this.buttonAtiende);
			this.panel13.Controls.Add(this.panel15);
			this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel13.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel13.Location = new System.Drawing.Point(0, 184);
			this.panel13.Name = "panel13";
			this.panel13.Size = new System.Drawing.Size(154, 46);
			this.panel13.TabIndex = 6;
			// 
			// panel14
			// 
			this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
			this.panel14.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel14.Location = new System.Drawing.Point(144, 0);
			this.panel14.Name = "panel14";
			this.panel14.Size = new System.Drawing.Size(10, 46);
			this.panel14.TabIndex = 2;
			// 
			// buttonAtiende
			// 
			this.buttonAtiende.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
			this.buttonAtiende.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonAtiende.FlatAppearance.BorderSize = 0;
			this.buttonAtiende.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(218)))), ((int)(((byte)(222)))));
			this.buttonAtiende.Location = new System.Drawing.Point(10, 0);
			this.buttonAtiende.Name = "buttonAtiende";
			this.buttonAtiende.Size = new System.Drawing.Size(144, 46);
			this.buttonAtiende.TabIndex = 0;
			this.buttonAtiende.Text = "Mostrar Atiende";
			this.buttonAtiende.UseVisualStyleBackColor = false;
			this.buttonAtiende.Click += new System.EventHandler(this.ButtonMostrarEspecialidadClick);
			// 
			// panel15
			// 
			this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
			this.panel15.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel15.Location = new System.Drawing.Point(0, 0);
			this.panel15.Name = "panel15";
			this.panel15.Size = new System.Drawing.Size(10, 46);
			this.panel15.TabIndex = 1;
			// 
			// panel10
			// 
			this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(100)))));
			this.panel10.Controls.Add(this.panel11);
			this.panel10.Controls.Add(this.buttonAgregarAsegurados);
			this.panel10.Controls.Add(this.panel12);
			this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel10.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel10.Location = new System.Drawing.Point(0, 138);
			this.panel10.Name = "panel10";
			this.panel10.Size = new System.Drawing.Size(154, 46);
			this.panel10.TabIndex = 5;
			// 
			// panel11
			// 
			this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
			this.panel11.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel11.Location = new System.Drawing.Point(144, 0);
			this.panel11.Name = "panel11";
			this.panel11.Size = new System.Drawing.Size(10, 46);
			this.panel11.TabIndex = 2;
			// 
			// buttonAgregarAsegurados
			// 
			this.buttonAgregarAsegurados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
			this.buttonAgregarAsegurados.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonAgregarAsegurados.FlatAppearance.BorderSize = 0;
			this.buttonAgregarAsegurados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(218)))), ((int)(((byte)(222)))));
			this.buttonAgregarAsegurados.Location = new System.Drawing.Point(10, 0);
			this.buttonAgregarAsegurados.Name = "buttonAgregarAsegurados";
			this.buttonAgregarAsegurados.Size = new System.Drawing.Size(144, 46);
			this.buttonAgregarAsegurados.TabIndex = 0;
			this.buttonAgregarAsegurados.Text = "Agregar Asegurados";
			this.buttonAgregarAsegurados.UseVisualStyleBackColor = false;
			this.buttonAgregarAsegurados.Click += new System.EventHandler(this.ButtonAgregarAseguradosClick);
			// 
			// panel12
			// 
			this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
			this.panel12.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel12.Location = new System.Drawing.Point(0, 0);
			this.panel12.Name = "panel12";
			this.panel12.Size = new System.Drawing.Size(10, 46);
			this.panel12.TabIndex = 1;
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(100)))));
			this.panel7.Controls.Add(this.panel8);
			this.panel7.Controls.Add(this.buttonAgregarDoctor);
			this.panel7.Controls.Add(this.panel9);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel7.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel7.Location = new System.Drawing.Point(0, 92);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(154, 46);
			this.panel7.TabIndex = 4;
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
			this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel8.Location = new System.Drawing.Point(141, 0);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(13, 46);
			this.panel8.TabIndex = 2;
			// 
			// buttonAgregarDoctor
			// 
			this.buttonAgregarDoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
			this.buttonAgregarDoctor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonAgregarDoctor.Location = new System.Drawing.Point(13, 0);
			this.buttonAgregarDoctor.Name = "buttonAgregarDoctor";
			this.buttonAgregarDoctor.Size = new System.Drawing.Size(141, 46);
			this.buttonAgregarDoctor.TabIndex = 0;
			this.buttonAgregarDoctor.Text = "AgregarDoctor";
			this.buttonAgregarDoctor.UseVisualStyleBackColor = false;
			this.buttonAgregarDoctor.Click += new System.EventHandler(this.ButtonAgregarDoctorClick);
			// 
			// panel9
			// 
			this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
			this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel9.Location = new System.Drawing.Point(0, 0);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(13, 46);
			this.panel9.TabIndex = 1;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(100)))));
			this.panel4.Controls.Add(this.panel6);
			this.panel4.Controls.Add(this.buttonMostrarAsegurados);
			this.panel4.Controls.Add(this.panel5);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel4.Location = new System.Drawing.Point(0, 46);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(154, 46);
			this.panel4.TabIndex = 3;
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
			this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel6.Location = new System.Drawing.Point(144, 0);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(10, 46);
			this.panel6.TabIndex = 2;
			// 
			// buttonMostrarAsegurados
			// 
			this.buttonMostrarAsegurados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
			this.buttonMostrarAsegurados.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonMostrarAsegurados.FlatAppearance.BorderSize = 0;
			this.buttonMostrarAsegurados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(218)))), ((int)(((byte)(222)))));
			this.buttonMostrarAsegurados.Location = new System.Drawing.Point(10, 0);
			this.buttonMostrarAsegurados.Name = "buttonMostrarAsegurados";
			this.buttonMostrarAsegurados.Size = new System.Drawing.Size(144, 46);
			this.buttonMostrarAsegurados.TabIndex = 0;
			this.buttonMostrarAsegurados.Text = "Mostrar Asegurados";
			this.buttonMostrarAsegurados.UseVisualStyleBackColor = false;
			this.buttonMostrarAsegurados.Click += new System.EventHandler(this.ButtonMostrarAseguradosClick);
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
			this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel5.Location = new System.Drawing.Point(0, 0);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(10, 46);
			this.panel5.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Red;
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(154, 46);
			this.panel2.TabIndex = 1;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(100)))));
			this.panel3.Controls.Add(this.labelConsola);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(154, 46);
			this.panel3.TabIndex = 2;
			// 
			// labelConsola
			// 
			this.labelConsola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(100)))));
			this.labelConsola.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelConsola.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelConsola.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.labelConsola.Location = new System.Drawing.Point(0, 0);
			this.labelConsola.Name = "labelConsola";
			this.labelConsola.Size = new System.Drawing.Size(154, 46);
			this.labelConsola.TabIndex = 0;
			// 
			// dataGridViewListaDoctores
			// 
			this.dataGridViewListaDoctores.AllowUserToAddRows = false;
			this.dataGridViewListaDoctores.AllowUserToDeleteRows = false;
			this.dataGridViewListaDoctores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewListaDoctores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.idDoctor,
									this.Nombre,
									this.Especialidad,
									this.Ver});
			this.dataGridViewListaDoctores.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewListaDoctores.Location = new System.Drawing.Point(0, 0);
			this.dataGridViewListaDoctores.Name = "dataGridViewListaDoctores";
			this.dataGridViewListaDoctores.ReadOnly = true;
			this.dataGridViewListaDoctores.Size = new System.Drawing.Size(420, 330);
			this.dataGridViewListaDoctores.TabIndex = 0;
			this.dataGridViewListaDoctores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewListaDoctoresCellContentClick);
			// 
			// idDoctor
			// 
			this.idDoctor.Frozen = true;
			this.idDoctor.HeaderText = "idDoctor";
			this.idDoctor.Name = "idDoctor";
			this.idDoctor.ReadOnly = true;
			// 
			// Nombre
			// 
			this.Nombre.Frozen = true;
			this.Nombre.HeaderText = "Nombre";
			this.Nombre.Name = "Nombre";
			this.Nombre.ReadOnly = true;
			// 
			// Especialidad
			// 
			this.Especialidad.Frozen = true;
			this.Especialidad.HeaderText = "Especialidad";
			this.Especialidad.Name = "Especialidad";
			this.Especialidad.ReadOnly = true;
			// 
			// Ver
			// 
			this.Ver.Frozen = true;
			this.Ver.HeaderText = "Ver";
			this.Ver.Name = "Ver";
			this.Ver.ReadOnly = true;
			this.Ver.Text = "Ver";
			this.Ver.UseColumnTextForButtonValue = true;
			this.Ver.Width = 50;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
			this.panel1.Controls.Add(this.panel19);
			this.panel1.Controls.Add(this.labeldirector);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(218)))), ((int)(((byte)(222)))));
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(578, 92);
			this.panel1.TabIndex = 1;
			// 
			// panel19
			// 
			this.panel19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
			this.panel19.Controls.Add(this.textBoxEspecialidad);
			this.panel19.Controls.Add(this.buttonFiltrar);
			this.panel19.Location = new System.Drawing.Point(397, 24);
			this.panel19.Name = "panel19";
			this.panel19.Size = new System.Drawing.Size(159, 35);
			this.panel19.TabIndex = 3;
			// 
			// textBoxEspecialidad
			// 
			this.textBoxEspecialidad.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxEspecialidad.Location = new System.Drawing.Point(0, 0);
			this.textBoxEspecialidad.Name = "textBoxEspecialidad";
			this.textBoxEspecialidad.Size = new System.Drawing.Size(119, 39);
			this.textBoxEspecialidad.TabIndex = 0;
			// 
			// buttonFiltrar
			// 
			this.buttonFiltrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonFiltrar.BackgroundImage")));
			this.buttonFiltrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonFiltrar.Dock = System.Windows.Forms.DockStyle.Right;
			this.buttonFiltrar.Location = new System.Drawing.Point(119, 0);
			this.buttonFiltrar.Name = "buttonFiltrar";
			this.buttonFiltrar.Size = new System.Drawing.Size(40, 35);
			this.buttonFiltrar.TabIndex = 3;
			this.buttonFiltrar.UseVisualStyleBackColor = true;
			this.buttonFiltrar.Click += new System.EventHandler(this.ButtonFiltrarClick);
			// 
			// labeldirector
			// 
			this.labeldirector.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labeldirector.Location = new System.Drawing.Point(23, 53);
			this.labeldirector.Name = "labeldirector";
			this.labeldirector.Size = new System.Drawing.Size(308, 23);
			this.labeldirector.TabIndex = 2;
			this.labeldirector.Text = "label2";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(319, 14);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(72, 72);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(370, 50);
			this.label1.TabIndex = 0;
			this.label1.Text = "HOSPITAL JUAN PABLO II";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(578, 422);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.panel1);
			this.Name = "MainForm";
			this.Text = "claseAgreComp";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.panel16.ResumeLayout(false);
			this.panel13.ResumeLayout(false);
			this.panel10.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaDoctores)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel19.ResumeLayout(false);
			this.panel19.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Panel panel19;
		private System.Windows.Forms.Label labelConsola;
		private System.Windows.Forms.TextBox textBoxEspecialidad;
		private System.Windows.Forms.Button buttonFiltrar;
		private System.Windows.Forms.Panel panel12;
		private System.Windows.Forms.Button buttonAgregarAsegurados;
		private System.Windows.Forms.Panel panel11;
		private System.Windows.Forms.Panel panel10;
		private System.Windows.Forms.Panel panel15;
		private System.Windows.Forms.Button buttonAtiende;
		private System.Windows.Forms.Panel panel14;
		private System.Windows.Forms.Panel panel13;
		private System.Windows.Forms.Panel panel18;
		private System.Windows.Forms.Button buttonEliminarDoctor;
		private System.Windows.Forms.Panel panel17;
		private System.Windows.Forms.Panel panel16;
		private System.Windows.Forms.DataGridViewButtonColumn Ver;
		private System.Windows.Forms.DataGridViewTextBoxColumn Especialidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDoctor;
		private System.Windows.Forms.DataGridView dataGridViewListaDoctores;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Button buttonMostrarAsegurados;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.Button buttonAgregarDoctor;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Label labeldirector;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.SplitContainer splitContainer1;
	}
}
