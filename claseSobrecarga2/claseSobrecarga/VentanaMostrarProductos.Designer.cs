/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 7/7/2022
 * Time: 10:27 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace claseSobrecarga
{
	partial class VentanaMostrarProductos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaMostrarProductos));
			this.panel2 = new System.Windows.Forms.Panel();
			this.labelcosto = new System.Windows.Forms.Label();
			this.labeldisponible = new System.Windows.Forms.Label();
			this.labelnombre = new System.Windows.Forms.Label();
			this.labeltipo = new System.Windows.Forms.Label();
			this.labelnro = new System.Windows.Forms.Label();
			this.panelTitulo = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel2.SuspendLayout();
			this.panelTitulo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(205)))), ((int)(((byte)(191)))));
			this.panel2.Controls.Add(this.labelcosto);
			this.panel2.Controls.Add(this.labeldisponible);
			this.panel2.Controls.Add(this.labelnombre);
			this.panel2.Controls.Add(this.labeltipo);
			this.panel2.Controls.Add(this.labelnro);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel2.Location = new System.Drawing.Point(0, 74);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(587, 445);
			this.panel2.TabIndex = 6;
			// 
			// labelcosto
			// 
			this.labelcosto.BackColor = System.Drawing.Color.Transparent;
			this.labelcosto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelcosto.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelcosto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelcosto.Location = new System.Drawing.Point(258, 0);
			this.labelcosto.Name = "labelcosto";
			this.labelcosto.Size = new System.Drawing.Size(90, 445);
			this.labelcosto.TabIndex = 6;
			this.labelcosto.Text = "Costo";
			this.labelcosto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// labeldisponible
			// 
			this.labeldisponible.BackColor = System.Drawing.Color.Transparent;
			this.labeldisponible.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labeldisponible.Dock = System.Windows.Forms.DockStyle.Right;
			this.labeldisponible.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labeldisponible.Location = new System.Drawing.Point(348, 0);
			this.labeldisponible.Name = "labeldisponible";
			this.labeldisponible.Size = new System.Drawing.Size(121, 445);
			this.labeldisponible.TabIndex = 5;
			this.labeldisponible.Text = "Disponible";
			this.labeldisponible.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// labelnombre
			// 
			this.labelnombre.BackColor = System.Drawing.Color.Transparent;
			this.labelnombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelnombre.Dock = System.Windows.Forms.DockStyle.Left;
			this.labelnombre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelnombre.Location = new System.Drawing.Point(54, 0);
			this.labelnombre.Name = "labelnombre";
			this.labelnombre.Size = new System.Drawing.Size(204, 445);
			this.labelnombre.TabIndex = 4;
			this.labelnombre.Text = "Nombre";
			this.labelnombre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// labeltipo
			// 
			this.labeltipo.BackColor = System.Drawing.Color.Transparent;
			this.labeltipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labeltipo.Dock = System.Windows.Forms.DockStyle.Right;
			this.labeltipo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labeltipo.Location = new System.Drawing.Point(469, 0);
			this.labeltipo.Name = "labeltipo";
			this.labeltipo.Size = new System.Drawing.Size(118, 445);
			this.labeltipo.TabIndex = 3;
			this.labeltipo.Text = "Tipo";
			this.labeltipo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// labelnro
			// 
			this.labelnro.BackColor = System.Drawing.Color.Transparent;
			this.labelnro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelnro.Dock = System.Windows.Forms.DockStyle.Left;
			this.labelnro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelnro.Location = new System.Drawing.Point(0, 0);
			this.labelnro.Name = "labelnro";
			this.labelnro.Size = new System.Drawing.Size(54, 445);
			this.labelnro.TabIndex = 2;
			this.labelnro.Text = "Nro";
			this.labelnro.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// panelTitulo
			// 
			this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(25)))), ((int)(((byte)(20)))));
			this.panelTitulo.Controls.Add(this.label1);
			this.panelTitulo.Controls.Add(this.pictureBox1);
			this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTitulo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panelTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(165)))), ((int)(((byte)(182)))));
			this.panelTitulo.Location = new System.Drawing.Point(0, 0);
			this.panelTitulo.Name = "panelTitulo";
			this.panelTitulo.Size = new System.Drawing.Size(587, 74);
			this.panelTitulo.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(31, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(347, 43);
			this.label1.TabIndex = 2;
			this.label1.Text = "LISTA DE PRODUCTOS";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(515, 8);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(60, 60);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// VentanaMostrarProductos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(587, 519);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panelTitulo);
			this.Name = "VentanaMostrarProductos";
			this.Text = "VentanaMostrarProductos";
			this.panel2.ResumeLayout(false);
			this.panelTitulo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label labeltipo;
		private System.Windows.Forms.Label labeldisponible;
		private System.Windows.Forms.Label labelnombre;
		private System.Windows.Forms.Label labelcosto;
		private System.Windows.Forms.Label labelnro;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panelTitulo;
		private System.Windows.Forms.Panel panel2;
	}
}
