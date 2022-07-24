/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 23/7/2022
 * Time: 15:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace clasePersistencia
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
			this.labelConsola = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.labelFecha = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panelIzquierdo = new System.Windows.Forms.Panel();
			this.buttonDepartamentos = new System.Windows.Forms.Button();
			this.buttonInquilinos = new System.Windows.Forms.Button();
			this.panelCascada = new System.Windows.Forms.Panel();
			this.button2 = new System.Windows.Forms.Button();
			this.buttonAgregaDepto = new System.Windows.Forms.Button();
			this.panel4 = new System.Windows.Forms.Panel();
			this.buttonCascada = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panelContenido = new System.Windows.Forms.Panel();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.labelTelefono = new System.Windows.Forms.Label();
			this.labeldireccion = new System.Windows.Forms.Label();
			this.labelNombreCondominio = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.labelnacimiento = new System.Windows.Forms.Label();
			this.labelnombreDuenio = new System.Windows.Forms.Label();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panelIzquierdo.SuspendLayout();
			this.panelCascada.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panelContenido.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// labelConsola
			// 
			this.labelConsola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(164)))), ((int)(((byte)(187)))));
			this.labelConsola.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelConsola.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelConsola.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.labelConsola.Location = new System.Drawing.Point(0, 0);
			this.labelConsola.Name = "labelConsola";
			this.labelConsola.Size = new System.Drawing.Size(167, 43);
			this.labelConsola.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(73)))), ((int)(((byte)(64)))));
			this.panel1.Controls.Add(this.labelFecha);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(650, 74);
			this.panel1.TabIndex = 1;
			// 
			// labelFecha
			// 
			this.labelFecha.Location = new System.Drawing.Point(477, 15);
			this.labelFecha.Name = "labelFecha";
			this.labelFecha.Size = new System.Drawing.Size(161, 41);
			this.labelFecha.TabIndex = 2;
			this.labelFecha.Text = "label2";
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
			this.label1.Location = new System.Drawing.Point(85, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(377, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "Bievenido Administrador";
			// 
			// panelIzquierdo
			// 
			this.panelIzquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(164)))), ((int)(((byte)(187)))));
			this.panelIzquierdo.Controls.Add(this.buttonDepartamentos);
			this.panelIzquierdo.Controls.Add(this.buttonInquilinos);
			this.panelIzquierdo.Controls.Add(this.panelCascada);
			this.panelIzquierdo.Controls.Add(this.buttonCascada);
			this.panelIzquierdo.Controls.Add(this.panel2);
			this.panelIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelIzquierdo.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panelIzquierdo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(73)))), ((int)(((byte)(64)))));
			this.panelIzquierdo.Location = new System.Drawing.Point(0, 74);
			this.panelIzquierdo.Name = "panelIzquierdo";
			this.panelIzquierdo.Size = new System.Drawing.Size(167, 348);
			this.panelIzquierdo.TabIndex = 2;
			// 
			// buttonDepartamentos
			// 
			this.buttonDepartamentos.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonDepartamentos.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonDepartamentos.Location = new System.Drawing.Point(0, 223);
			this.buttonDepartamentos.Name = "buttonDepartamentos";
			this.buttonDepartamentos.Size = new System.Drawing.Size(167, 45);
			this.buttonDepartamentos.TabIndex = 4;
			this.buttonDepartamentos.Text = "Departamentos";
			this.buttonDepartamentos.UseVisualStyleBackColor = true;
			this.buttonDepartamentos.Click += new System.EventHandler(this.ButtonDepartamentosClick);
			// 
			// buttonInquilinos
			// 
			this.buttonInquilinos.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonInquilinos.Location = new System.Drawing.Point(0, 178);
			this.buttonInquilinos.Name = "buttonInquilinos";
			this.buttonInquilinos.Size = new System.Drawing.Size(167, 45);
			this.buttonInquilinos.TabIndex = 3;
			this.buttonInquilinos.Text = "Inquilinos";
			this.buttonInquilinos.UseVisualStyleBackColor = true;
			this.buttonInquilinos.Click += new System.EventHandler(this.ButtonInquilinosClick);
			// 
			// panelCascada
			// 
			this.panelCascada.Controls.Add(this.button2);
			this.panelCascada.Controls.Add(this.buttonAgregaDepto);
			this.panelCascada.Controls.Add(this.panel4);
			this.panelCascada.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelCascada.Location = new System.Drawing.Point(0, 88);
			this.panelCascada.Name = "panelCascada";
			this.panelCascada.Size = new System.Drawing.Size(167, 90);
			this.panelCascada.TabIndex = 0;
			this.panelCascada.Visible = false;
			// 
			// button2
			// 
			this.button2.Dock = System.Windows.Forms.DockStyle.Top;
			this.button2.Location = new System.Drawing.Point(18, 45);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(149, 45);
			this.button2.TabIndex = 4;
			this.button2.Text = "Cascada2";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// buttonAgregaDepto
			// 
			this.buttonAgregaDepto.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonAgregaDepto.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonAgregaDepto.Location = new System.Drawing.Point(18, 0);
			this.buttonAgregaDepto.Name = "buttonAgregaDepto";
			this.buttonAgregaDepto.Size = new System.Drawing.Size(149, 45);
			this.buttonAgregaDepto.TabIndex = 3;
			this.buttonAgregaDepto.Text = "Agrega Dpto.";
			this.buttonAgregaDepto.UseVisualStyleBackColor = true;
			this.buttonAgregaDepto.Click += new System.EventHandler(this.ButtonAgregaDeptoClick);
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(164)))), ((int)(((byte)(187)))));
			this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(18, 90);
			this.panel4.TabIndex = 0;
			// 
			// buttonCascada
			// 
			this.buttonCascada.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonCascada.Location = new System.Drawing.Point(0, 43);
			this.buttonCascada.Name = "buttonCascada";
			this.buttonCascada.Size = new System.Drawing.Size(167, 45);
			this.buttonCascada.TabIndex = 2;
			this.buttonCascada.Text = "Opciones";
			this.buttonCascada.UseVisualStyleBackColor = true;
			this.buttonCascada.Click += new System.EventHandler(this.ButtonCascadaClick);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.labelConsola);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(167, 43);
			this.panel2.TabIndex = 1;
			// 
			// panelContenido
			// 
			this.panelContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
			this.panelContenido.Controls.Add(this.groupBox2);
			this.panelContenido.Controls.Add(this.groupBox1);
			this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelContenido.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panelContenido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(73)))), ((int)(((byte)(64)))));
			this.panelContenido.Location = new System.Drawing.Point(167, 74);
			this.panelContenido.Name = "panelContenido";
			this.panelContenido.Size = new System.Drawing.Size(483, 348);
			this.panelContenido.TabIndex = 3;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.labelTelefono);
			this.groupBox2.Controls.Add(this.labeldireccion);
			this.groupBox2.Controls.Add(this.labelNombreCondominio);
			this.groupBox2.Controls.Add(this.pictureBox2);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(0, 116);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(483, 232);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Condominio:";
			// 
			// labelTelefono
			// 
			this.labelTelefono.Location = new System.Drawing.Point(6, 103);
			this.labelTelefono.Name = "labelTelefono";
			this.labelTelefono.Size = new System.Drawing.Size(296, 23);
			this.labelTelefono.TabIndex = 6;
			this.labelTelefono.Text = "Telefono:";
			// 
			// labeldireccion
			// 
			this.labeldireccion.Location = new System.Drawing.Point(6, 66);
			this.labeldireccion.Name = "labeldireccion";
			this.labeldireccion.Size = new System.Drawing.Size(296, 23);
			this.labeldireccion.TabIndex = 5;
			this.labeldireccion.Text = "Direccion: ";
			// 
			// labelNombreCondominio
			// 
			this.labelNombreCondominio.Location = new System.Drawing.Point(6, 30);
			this.labelNombreCondominio.Name = "labelNombreCondominio";
			this.labelNombreCondominio.Size = new System.Drawing.Size(329, 23);
			this.labelNombreCondominio.TabIndex = 4;
			this.labelNombreCondominio.Text = "Nombre Condominio: ";
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox2.Location = new System.Drawing.Point(310, 56);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(139, 170);
			this.pictureBox2.TabIndex = 0;
			this.pictureBox2.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.labelnacimiento);
			this.groupBox1.Controls.Add(this.labelnombreDuenio);
			this.groupBox1.Controls.Add(this.pictureBox3);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(483, 116);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Fundador:";
			// 
			// labelnacimiento
			// 
			this.labelnacimiento.Location = new System.Drawing.Point(105, 65);
			this.labelnacimiento.Name = "labelnacimiento";
			this.labelnacimiento.Size = new System.Drawing.Size(329, 45);
			this.labelnacimiento.TabIndex = 3;
			this.labelnacimiento.Text = "Fecha Nacimiento: ";
			// 
			// labelnombreDuenio
			// 
			this.labelnombreDuenio.Location = new System.Drawing.Point(105, 30);
			this.labelnombreDuenio.Name = "labelnombreDuenio";
			this.labelnombreDuenio.Size = new System.Drawing.Size(329, 23);
			this.labelnombreDuenio.TabIndex = 1;
			this.labelnombreDuenio.Text = "Duenio: ";
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(6, 30);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(83, 80);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 2;
			this.pictureBox3.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(650, 422);
			this.Controls.Add(this.panelContenido);
			this.Controls.Add(this.panelIzquierdo);
			this.Controls.Add(this.panel1);
			this.Name = "MainForm";
			this.Text = "clasePersistencia";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panelIzquierdo.ResumeLayout(false);
			this.panelCascada.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panelContenido.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button buttonDepartamentos;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label labelnombreDuenio;
		private System.Windows.Forms.Label labelnacimiento;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label labelNombreCondominio;
		private System.Windows.Forms.Label labeldireccion;
		private System.Windows.Forms.Label labelTelefono;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button buttonInquilinos;
		private System.Windows.Forms.Panel panelContenido;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button buttonCascada;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Button buttonAgregaDepto;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Panel panelCascada;
		private System.Windows.Forms.Panel panelIzquierdo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label labelFecha;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label labelConsola;
	}
}
