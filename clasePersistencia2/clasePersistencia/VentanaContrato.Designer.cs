/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 24/7/2022
 * Time: 00:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace clasePersistencia
{
	partial class VentanaContrato
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaContrato));
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.labelContrato = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.labelFinContrato = new System.Windows.Forms.Label();
			this.labelInicioContrato = new System.Windows.Forms.Label();
			this.labelIdDepartamento = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.labelImagen = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(73)))), ((int)(((byte)(64)))));
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.labelContrato);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(481, 74);
			this.panel1.TabIndex = 3;
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
			// labelContrato
			// 
			this.labelContrato.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelContrato.Location = new System.Drawing.Point(85, 9);
			this.labelContrato.Name = "labelContrato";
			this.labelContrato.Size = new System.Drawing.Size(384, 58);
			this.labelContrato.TabIndex = 0;
			this.labelContrato.Text = "Contrato: ";
			this.labelContrato.Click += new System.EventHandler(this.LabelContratoClick);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
			this.panel2.Controls.Add(this.labelImagen);
			this.panel2.Controls.Add(this.labelFinContrato);
			this.panel2.Controls.Add(this.labelInicioContrato);
			this.panel2.Controls.Add(this.labelIdDepartamento);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(73)))), ((int)(((byte)(64)))));
			this.panel2.Location = new System.Drawing.Point(0, 74);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(481, 221);
			this.panel2.TabIndex = 4;
			// 
			// labelFinContrato
			// 
			this.labelFinContrato.Location = new System.Drawing.Point(249, 153);
			this.labelFinContrato.Name = "labelFinContrato";
			this.labelFinContrato.Size = new System.Drawing.Size(192, 23);
			this.labelFinContrato.TabIndex = 5;
			this.labelFinContrato.Text = "label6";
			// 
			// labelInicioContrato
			// 
			this.labelInicioContrato.Location = new System.Drawing.Point(249, 96);
			this.labelInicioContrato.Name = "labelInicioContrato";
			this.labelInicioContrato.Size = new System.Drawing.Size(192, 23);
			this.labelInicioContrato.TabIndex = 4;
			this.labelInicioContrato.Text = "label5";
			// 
			// labelIdDepartamento
			// 
			this.labelIdDepartamento.Location = new System.Drawing.Point(249, 39);
			this.labelIdDepartamento.Name = "labelIdDepartamento";
			this.labelIdDepartamento.Size = new System.Drawing.Size(192, 23);
			this.labelIdDepartamento.TabIndex = 3;
			this.labelIdDepartamento.Text = "label4";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(249, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(210, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Id Departamento";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(249, 130);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(182, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Fin Contrato";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(249, 73);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(182, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Inicio Contrato";
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
			// labelImagen
			// 
			this.labelImagen.ImageList = this.imageList1;
			this.labelImagen.Location = new System.Drawing.Point(12, 13);
			this.labelImagen.Name = "labelImagen";
			this.labelImagen.Size = new System.Drawing.Size(220, 175);
			this.labelImagen.TabIndex = 21;
			// 
			// VentanaContrato
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(481, 295);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "VentanaContrato";
			this.Text = "VentanaContrato";
			this.Load += new System.EventHandler(this.VentanaContratoLoad);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label labelImagen;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label labelIdDepartamento;
		private System.Windows.Forms.Label labelInicioContrato;
		private System.Windows.Forms.Label labelFinContrato;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label labelContrato;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
	}
}
