/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 24/7/2022
 * Time: 02:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace clasePersistencia
{
	partial class VentanaAgregaDepartamento
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaAgregaDepartamento));
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.labeltitulo = new System.Windows.Forms.Label();
			this.buttonOK = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.buttonAnt = new System.Windows.Forms.Button();
			this.buttonSig = new System.Windows.Forms.Button();
			this.labelImagen = new System.Windows.Forms.Label();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.textBoxSuperficie = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxCosto = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(73)))), ((int)(((byte)(64)))));
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.labeltitulo);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(462, 74);
			this.panel1.TabIndex = 5;
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
			// labeltitulo
			// 
			this.labeltitulo.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labeltitulo.Location = new System.Drawing.Point(99, 19);
			this.labeltitulo.Name = "labeltitulo";
			this.labeltitulo.Size = new System.Drawing.Size(331, 37);
			this.labeltitulo.TabIndex = 0;
			this.labeltitulo.Text = "Agrega Departamento";
			// 
			// buttonOK
			// 
			this.buttonOK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonOK.BackgroundImage")));
			this.buttonOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonOK.FlatAppearance.BorderSize = 0;
			this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonOK.Location = new System.Drawing.Point(397, 182);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(53, 48);
			this.buttonOK.TabIndex = 2;
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.ButtonOKClick);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
			this.panel2.Controls.Add(this.buttonAnt);
			this.panel2.Controls.Add(this.buttonSig);
			this.panel2.Controls.Add(this.buttonOK);
			this.panel2.Controls.Add(this.labelImagen);
			this.panel2.Controls.Add(this.textBoxSuperficie);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.textBoxCosto);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(73)))), ((int)(((byte)(64)))));
			this.panel2.Location = new System.Drawing.Point(0, 74);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(462, 267);
			this.panel2.TabIndex = 6;
			// 
			// buttonAnt
			// 
			this.buttonAnt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAnt.BackgroundImage")));
			this.buttonAnt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonAnt.Location = new System.Drawing.Point(12, 182);
			this.buttonAnt.Name = "buttonAnt";
			this.buttonAnt.Size = new System.Drawing.Size(38, 39);
			this.buttonAnt.TabIndex = 22;
			this.buttonAnt.UseVisualStyleBackColor = true;
			this.buttonAnt.Click += new System.EventHandler(this.ButtonAntClick);
			// 
			// buttonSig
			// 
			this.buttonSig.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSig.BackgroundImage")));
			this.buttonSig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonSig.Location = new System.Drawing.Point(202, 182);
			this.buttonSig.Name = "buttonSig";
			this.buttonSig.Size = new System.Drawing.Size(38, 39);
			this.buttonSig.TabIndex = 21;
			this.buttonSig.UseVisualStyleBackColor = true;
			this.buttonSig.Click += new System.EventHandler(this.ButtonSigClick);
			// 
			// labelImagen
			// 
			this.labelImagen.ImageIndex = 0;
			this.labelImagen.ImageList = this.imageList1;
			this.labelImagen.Location = new System.Drawing.Point(12, 12);
			this.labelImagen.Name = "labelImagen";
			this.labelImagen.Size = new System.Drawing.Size(228, 209);
			this.labelImagen.TabIndex = 20;
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
			// textBoxSuperficie
			// 
			this.textBoxSuperficie.Location = new System.Drawing.Point(261, 119);
			this.textBoxSuperficie.Name = "textBoxSuperficie";
			this.textBoxSuperficie.Size = new System.Drawing.Size(141, 34);
			this.textBoxSuperficie.TabIndex = 11;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(261, 93);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(131, 23);
			this.label2.TabIndex = 10;
			this.label2.Text = "Superficie";
			// 
			// textBoxCosto
			// 
			this.textBoxCosto.Location = new System.Drawing.Point(261, 45);
			this.textBoxCosto.Name = "textBoxCosto";
			this.textBoxCosto.Size = new System.Drawing.Size(140, 34);
			this.textBoxCosto.TabIndex = 9;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(261, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 23);
			this.label1.TabIndex = 8;
			this.label1.Text = "Costo";
			// 
			// VentanaAgregaDepartamento
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(462, 341);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "VentanaAgregaDepartamento";
			this.Text = "VentanaAgregaDepartamento";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxCosto;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxSuperficie;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Label labelImagen;
		private System.Windows.Forms.Button buttonSig;
		private System.Windows.Forms.Button buttonAnt;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label labeltitulo;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Panel panel1;
	}
}
