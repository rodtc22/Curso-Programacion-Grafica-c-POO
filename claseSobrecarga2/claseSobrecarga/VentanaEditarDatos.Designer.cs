/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 7/7/2022
 * Time: 11:11 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace claseSobrecarga
{
	partial class VentanaEditarDatos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaEditarDatos));
			this.panel2 = new System.Windows.Forms.Panel();
			this.textBoxdireccion = new System.Windows.Forms.TextBox();
			this.textBoxtelefono = new System.Windows.Forms.TextBox();
			this.textBoxduenio = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.labelConsola = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.buttonGuardarCambios = new System.Windows.Forms.Button();
			this.panelTitulo = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panelTitulo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(205)))), ((int)(((byte)(191)))));
			this.panel2.Controls.Add(this.textBoxdireccion);
			this.panel2.Controls.Add(this.textBoxtelefono);
			this.panel2.Controls.Add(this.textBoxduenio);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel2.Location = new System.Drawing.Point(0, 71);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(451, 166);
			this.panel2.TabIndex = 6;
			// 
			// textBoxdireccion
			// 
			this.textBoxdireccion.Location = new System.Drawing.Point(169, 111);
			this.textBoxdireccion.Name = "textBoxdireccion";
			this.textBoxdireccion.Size = new System.Drawing.Size(232, 37);
			this.textBoxdireccion.TabIndex = 11;
			// 
			// textBoxtelefono
			// 
			this.textBoxtelefono.Location = new System.Drawing.Point(169, 68);
			this.textBoxtelefono.Name = "textBoxtelefono";
			this.textBoxtelefono.Size = new System.Drawing.Size(232, 37);
			this.textBoxtelefono.TabIndex = 10;
			// 
			// textBoxduenio
			// 
			this.textBoxduenio.Location = new System.Drawing.Point(169, 25);
			this.textBoxduenio.Name = "textBoxduenio";
			this.textBoxduenio.Size = new System.Drawing.Size(232, 37);
			this.textBoxduenio.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(12, 111);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(115, 32);
			this.label5.TabIndex = 6;
			this.label5.Text = "Direccion:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 68);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(120, 32);
			this.label4.TabIndex = 4;
			this.label4.Text = "Telefono:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 32);
			this.label2.TabIndex = 2;
			this.label2.Text = "Duenio:";
			// 
			// labelConsola
			// 
			this.labelConsola.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.labelConsola.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelConsola.ForeColor = System.Drawing.SystemColors.Control;
			this.labelConsola.Location = new System.Drawing.Point(12, 3);
			this.labelConsola.Name = "labelConsola";
			this.labelConsola.Size = new System.Drawing.Size(249, 35);
			this.labelConsola.TabIndex = 0;
			this.labelConsola.Text = "label1";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(105)))), ((int)(((byte)(82)))));
			this.panel1.Controls.Add(this.buttonGuardarCambios);
			this.panel1.Controls.Add(this.labelConsola);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel1.Location = new System.Drawing.Point(0, 237);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(451, 65);
			this.panel1.TabIndex = 5;
			// 
			// buttonGuardarCambios
			// 
			this.buttonGuardarCambios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonGuardarCambios.BackgroundImage")));
			this.buttonGuardarCambios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonGuardarCambios.FlatAppearance.BorderSize = 0;
			this.buttonGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonGuardarCambios.Location = new System.Drawing.Point(384, 3);
			this.buttonGuardarCambios.Name = "buttonGuardarCambios";
			this.buttonGuardarCambios.Size = new System.Drawing.Size(50, 50);
			this.buttonGuardarCambios.TabIndex = 12;
			this.buttonGuardarCambios.UseVisualStyleBackColor = true;
			this.buttonGuardarCambios.Click += new System.EventHandler(this.ButtonGuardarCambiosClick);
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
			this.panelTitulo.Size = new System.Drawing.Size(451, 71);
			this.panelTitulo.TabIndex = 4;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(374, 8);
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
			this.label1.Size = new System.Drawing.Size(358, 42);
			this.label1.TabIndex = 1;
			this.label1.Text = "Editar Datos de Pasteleria";
			// 
			// VentanaEditarDatos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(451, 302);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panelTitulo);
			this.Name = "VentanaEditarDatos";
			this.Text = "VentanaEditarDatos";
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panelTitulo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button buttonGuardarCambios;
		private System.Windows.Forms.TextBox textBoxduenio;
		private System.Windows.Forms.TextBox textBoxtelefono;
		private System.Windows.Forms.TextBox textBoxdireccion;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panelTitulo;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label labelConsola;
		private System.Windows.Forms.Panel panel2;
	}
}
