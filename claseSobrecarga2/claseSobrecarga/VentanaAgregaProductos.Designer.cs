/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 7/7/2022
 * Time: 11:35 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace claseSobrecarga
{
	partial class VentanaAgregaProductos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaAgregaProductos));
			this.panel2 = new System.Windows.Forms.Panel();
			this.comboBoxtipo = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxcantidad = new System.Windows.Forms.TextBox();
			this.textBoxcosto = new System.Windows.Forms.TextBox();
			this.textBoxnombre = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.buttonAgregar = new System.Windows.Forms.Button();
			this.labelConsola = new System.Windows.Forms.Label();
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
			this.panel2.Controls.Add(this.comboBoxtipo);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.textBoxcantidad);
			this.panel2.Controls.Add(this.textBoxcosto);
			this.panel2.Controls.Add(this.textBoxnombre);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel2.Location = new System.Drawing.Point(0, 71);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(413, 220);
			this.panel2.TabIndex = 9;
			// 
			// comboBoxtipo
			// 
			this.comboBoxtipo.FormattingEnabled = true;
			this.comboBoxtipo.Items.AddRange(new object[] {
									"Bebida",
									"Comida",
									"Postre"});
			this.comboBoxtipo.Location = new System.Drawing.Point(169, 155);
			this.comboBoxtipo.Name = "comboBoxtipo";
			this.comboBoxtipo.Size = new System.Drawing.Size(232, 37);
			this.comboBoxtipo.TabIndex = 13;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 154);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(115, 32);
			this.label3.TabIndex = 12;
			this.label3.Text = "Tipo:";
			// 
			// textBoxcantidad
			// 
			this.textBoxcantidad.Location = new System.Drawing.Point(169, 111);
			this.textBoxcantidad.Name = "textBoxcantidad";
			this.textBoxcantidad.Size = new System.Drawing.Size(232, 37);
			this.textBoxcantidad.TabIndex = 11;
			// 
			// textBoxcosto
			// 
			this.textBoxcosto.AcceptsTab = true;
			this.textBoxcosto.Location = new System.Drawing.Point(169, 68);
			this.textBoxcosto.Name = "textBoxcosto";
			this.textBoxcosto.Size = new System.Drawing.Size(232, 37);
			this.textBoxcosto.TabIndex = 10;
			// 
			// textBoxnombre
			// 
			this.textBoxnombre.AcceptsReturn = true;
			this.textBoxnombre.Location = new System.Drawing.Point(169, 25);
			this.textBoxnombre.Name = "textBoxnombre";
			this.textBoxnombre.Size = new System.Drawing.Size(232, 37);
			this.textBoxnombre.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(12, 111);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(115, 32);
			this.label5.TabIndex = 6;
			this.label5.Text = "Cantidad:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 68);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(120, 32);
			this.label4.TabIndex = 4;
			this.label4.Text = "Costo:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(115, 32);
			this.label2.TabIndex = 2;
			this.label2.Text = "Nombre:";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(105)))), ((int)(((byte)(82)))));
			this.panel1.Controls.Add(this.buttonAgregar);
			this.panel1.Controls.Add(this.labelConsola);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel1.Location = new System.Drawing.Point(0, 291);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(413, 45);
			this.panel1.TabIndex = 8;
			// 
			// buttonAgregar
			// 
			this.buttonAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonAgregar.FlatAppearance.BorderSize = 0;
			this.buttonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAgregar.Location = new System.Drawing.Point(306, 6);
			this.buttonAgregar.Name = "buttonAgregar";
			this.buttonAgregar.Size = new System.Drawing.Size(90, 37);
			this.buttonAgregar.TabIndex = 12;
			this.buttonAgregar.Text = "Agrega";
			this.buttonAgregar.UseVisualStyleBackColor = true;
			this.buttonAgregar.Click += new System.EventHandler(this.ButtonAgregarClick);
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
			this.panelTitulo.Size = new System.Drawing.Size(413, 71);
			this.panelTitulo.TabIndex = 7;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(336, 8);
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
			this.label1.Text = "Agrega Producto";
			// 
			// VentanaAgregaProductos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(413, 336);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panelTitulo);
			this.Name = "VentanaAgregaProductos";
			this.Text = "VentanaAgregaProductos";
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panelTitulo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ComboBox comboBoxtipo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panelTitulo;
		private System.Windows.Forms.Label labelConsola;
		private System.Windows.Forms.Button buttonAgregar;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxnombre;
		private System.Windows.Forms.TextBox textBoxcosto;
		private System.Windows.Forms.TextBox textBoxcantidad;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel2;
	}
}
