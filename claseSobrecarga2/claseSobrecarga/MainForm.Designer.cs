/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 7/7/2022
 * Time: 9:08 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace claseSobrecarga
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
			this.panelTitulo = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.buttoneditardatos = new System.Windows.Forms.Button();
			this.labelNroProductos = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.labeldireccion = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.labeltelefono = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.labelduenio = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBoxproductos = new System.Windows.Forms.PictureBox();
			this.buttonAgregarProductos = new System.Windows.Forms.Button();
			this.panelTitulo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxproductos)).BeginInit();
			this.SuspendLayout();
			// 
			// labelConsola
			// 
			this.labelConsola.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.labelConsola.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelConsola.ForeColor = System.Drawing.SystemColors.Control;
			this.labelConsola.Location = new System.Drawing.Point(328, 24);
			this.labelConsola.Name = "labelConsola";
			this.labelConsola.Size = new System.Drawing.Size(144, 33);
			this.labelConsola.TabIndex = 0;
			this.labelConsola.Text = "label1";
			// 
			// panelTitulo
			// 
			this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(25)))), ((int)(((byte)(20)))));
			this.panelTitulo.Controls.Add(this.pictureBox1);
			this.panelTitulo.Controls.Add(this.label1);
			this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTitulo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panelTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(165)))), ((int)(((byte)(182)))));
			this.panelTitulo.Location = new System.Drawing.Point(0, 0);
			this.panelTitulo.Name = "panelTitulo";
			this.panelTitulo.Size = new System.Drawing.Size(489, 71);
			this.panelTitulo.TabIndex = 1;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(412, 8);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(60, 60);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(337, 42);
			this.label1.TabIndex = 1;
			this.label1.Text = "Bienvenido a la Pasteleria";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(105)))), ((int)(((byte)(82)))));
			this.panel1.Controls.Add(this.labelConsola);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel1.Location = new System.Drawing.Point(0, 423);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(489, 69);
			this.panel1.TabIndex = 2;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(12, 39);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(257, 27);
			this.label7.TabIndex = 10;
			this.label7.Text = "Correo: rodritc99@gmail.com";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 12);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(352, 27);
			this.label3.TabIndex = 9;
			this.label3.Text = "Autor: Aux. Rodrigo Ticona Coronel";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(205)))), ((int)(((byte)(191)))));
			this.panel2.Controls.Add(this.buttonAgregarProductos);
			this.panel2.Controls.Add(this.buttoneditardatos);
			this.panel2.Controls.Add(this.labelNroProductos);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.labeldireccion);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.labeltelefono);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.labelduenio);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.pictureBoxproductos);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel2.Location = new System.Drawing.Point(0, 71);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(489, 352);
			this.panel2.TabIndex = 3;
			// 
			// buttoneditardatos
			// 
			this.buttoneditardatos.Location = new System.Drawing.Point(12, 233);
			this.buttoneditardatos.Name = "buttoneditardatos";
			this.buttoneditardatos.Size = new System.Drawing.Size(163, 43);
			this.buttoneditardatos.TabIndex = 10;
			this.buttoneditardatos.Text = "Editar Datos";
			this.buttoneditardatos.UseVisualStyleBackColor = true;
			this.buttoneditardatos.Click += new System.EventHandler(this.ButtoneditardatosClick);
			// 
			// labelNroProductos
			// 
			this.labelNroProductos.Location = new System.Drawing.Point(172, 189);
			this.labelNroProductos.Name = "labelNroProductos";
			this.labelNroProductos.Size = new System.Drawing.Size(64, 32);
			this.labelNroProductos.TabIndex = 9;
			this.labelNroProductos.Text = ".";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(12, 189);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(163, 32);
			this.label6.TabIndex = 8;
			this.label6.Text = "NroProductos:";
			// 
			// labeldireccion
			// 
			this.labeldireccion.Location = new System.Drawing.Point(124, 157);
			this.labeldireccion.Name = "labeldireccion";
			this.labeldireccion.Size = new System.Drawing.Size(283, 32);
			this.labeldireccion.TabIndex = 7;
			this.labeldireccion.Text = ".";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(12, 157);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(115, 32);
			this.label5.TabIndex = 6;
			this.label5.Text = "Direccion:";
			// 
			// labeltelefono
			// 
			this.labeltelefono.Location = new System.Drawing.Point(310, 117);
			this.labeltelefono.Name = "labeltelefono";
			this.labeltelefono.Size = new System.Drawing.Size(162, 32);
			this.labeltelefono.TabIndex = 5;
			this.labeltelefono.Text = ".";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(310, 85);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(120, 32);
			this.label4.TabIndex = 4;
			this.label4.Text = "Telefono:";
			// 
			// labelduenio
			// 
			this.labelduenio.Location = new System.Drawing.Point(310, 44);
			this.labelduenio.Name = "labelduenio";
			this.labelduenio.Size = new System.Drawing.Size(167, 32);
			this.labelduenio.TabIndex = 3;
			this.labelduenio.Text = ".";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(310, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 32);
			this.label2.TabIndex = 2;
			this.label2.Text = "Duenio:";
			// 
			// pictureBoxproductos
			// 
			this.pictureBoxproductos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxproductos.BackgroundImage")));
			this.pictureBoxproductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBoxproductos.Location = new System.Drawing.Point(12, 0);
			this.pictureBoxproductos.Name = "pictureBoxproductos";
			this.pictureBoxproductos.Size = new System.Drawing.Size(290, 154);
			this.pictureBoxproductos.TabIndex = 1;
			this.pictureBoxproductos.TabStop = false;
			this.pictureBoxproductos.Click += new System.EventHandler(this.PictureBoxproductosClick);
			// 
			// buttonAgregarProductos
			// 
			this.buttonAgregarProductos.Location = new System.Drawing.Point(186, 233);
			this.buttonAgregarProductos.Name = "buttonAgregarProductos";
			this.buttonAgregarProductos.Size = new System.Drawing.Size(128, 77);
			this.buttonAgregarProductos.TabIndex = 11;
			this.buttonAgregarProductos.Text = "Agregar Productos";
			this.buttonAgregarProductos.UseVisualStyleBackColor = true;
			this.buttonAgregarProductos.Click += new System.EventHandler(this.ButtonAgregarProductosClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(489, 492);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panelTitulo);
			this.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "claseSobrecarga";
			this.panelTitulo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxproductos)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button buttonAgregarProductos;
		private System.Windows.Forms.Button buttoneditardatos;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.PictureBox pictureBoxproductos;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labelduenio;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label labeltelefono;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label labeldireccion;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label labelNroProductos;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panelTitulo;
		private System.Windows.Forms.Label labelConsola;
	}
}
