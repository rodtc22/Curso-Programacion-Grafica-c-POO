/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 23/7/2022
 * Time: 01:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace claseAgreComp
{
	partial class VentanaAgregarAsegurado
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaAgregarAsegurado));
			this.panel2 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.dateTimePickerFechaNacimiento = new System.Windows.Forms.DateTimePicker();
			this.textBoxMaterno = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonok = new System.Windows.Forms.Button();
			this.textBoxPaterno = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxNombre = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.labelDoctor = new System.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.dateTimePickerFechaNacimiento);
			this.panel2.Controls.Add(this.textBoxMaterno);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.buttonok);
			this.panel2.Controls.Add(this.textBoxPaterno);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.textBoxNombre);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel2.Location = new System.Drawing.Point(0, 69);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(229, 248);
			this.panel2.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 172);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 10;
			this.label4.Text = "Fecha de Nacimiento";
			// 
			// dateTimePickerFechaNacimiento
			// 
			this.dateTimePickerFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerFechaNacimiento.Location = new System.Drawing.Point(13, 198);
			this.dateTimePickerFechaNacimiento.Name = "dateTimePickerFechaNacimiento";
			this.dateTimePickerFechaNacimiento.Size = new System.Drawing.Size(112, 26);
			this.dateTimePickerFechaNacimiento.TabIndex = 9;
			// 
			// textBoxMaterno
			// 
			this.textBoxMaterno.Location = new System.Drawing.Point(13, 130);
			this.textBoxMaterno.Name = "textBoxMaterno";
			this.textBoxMaterno.Size = new System.Drawing.Size(192, 26);
			this.textBoxMaterno.TabIndex = 8;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 108);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 7;
			this.label1.Text = "Materno";
			// 
			// buttonok
			// 
			this.buttonok.Location = new System.Drawing.Point(143, 190);
			this.buttonok.Name = "buttonok";
			this.buttonok.Size = new System.Drawing.Size(62, 34);
			this.buttonok.TabIndex = 6;
			this.buttonok.Text = "ok";
			this.buttonok.UseVisualStyleBackColor = true;
			this.buttonok.Click += new System.EventHandler(this.ButtonokClick);
			// 
			// textBoxPaterno
			// 
			this.textBoxPaterno.Location = new System.Drawing.Point(13, 77);
			this.textBoxPaterno.Name = "textBoxPaterno";
			this.textBoxPaterno.Size = new System.Drawing.Size(192, 26);
			this.textBoxPaterno.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 55);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Paterno";
			// 
			// textBoxNombre
			// 
			this.textBoxNombre.Location = new System.Drawing.Point(13, 29);
			this.textBoxNombre.Name = "textBoxNombre";
			this.textBoxNombre.Size = new System.Drawing.Size(192, 26);
			this.textBoxNombre.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 3);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Nombre";
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
			this.panel1.Size = new System.Drawing.Size(229, 69);
			this.panel1.TabIndex = 7;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(157, 7);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(58, 56);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// labelDoctor
			// 
			this.labelDoctor.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDoctor.Location = new System.Drawing.Point(12, 0);
			this.labelDoctor.Name = "labelDoctor";
			this.labelDoctor.Size = new System.Drawing.Size(175, 62);
			this.labelDoctor.TabIndex = 0;
			this.labelDoctor.Text = "Agrega Asegurado";
			// 
			// VentanaAgregarAsegurado
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(229, 317);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "VentanaAgregarAsegurado";
			this.Text = "VentanaAgregarAsegurado";
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label labelDoctor;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxNombre;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxPaterno;
		private System.Windows.Forms.Button buttonok;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxMaterno;
		private System.Windows.Forms.DateTimePicker dateTimePickerFechaNacimiento;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel2;
	}
}
