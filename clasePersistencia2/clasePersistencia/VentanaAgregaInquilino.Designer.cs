/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 24/7/2022
 * Time: 01:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace clasePersistencia
{
	partial class VentanaAgregaInquilino
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaAgregaInquilino));
			this.panel1 = new System.Windows.Forms.Panel();
			this.buttonOK = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.labeltitulo = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.labelImagen = new System.Windows.Forms.Label();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.label7 = new System.Windows.Forms.Label();
			this.dateTimePickerfinal = new System.Windows.Forms.DateTimePicker();
			this.label6 = new System.Windows.Forms.Label();
			this.dateTimePickerInicio = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.monthCalendarNacimiento = new System.Windows.Forms.MonthCalendar();
			this.textBoxCarnet = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxMaterno = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxPaterno = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxNombre = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(73)))), ((int)(((byte)(64)))));
			this.panel1.Controls.Add(this.buttonOK);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.labeltitulo);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(686, 74);
			this.panel1.TabIndex = 4;
			// 
			// buttonOK
			// 
			this.buttonOK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonOK.BackgroundImage")));
			this.buttonOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonOK.FlatAppearance.BorderSize = 0;
			this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonOK.Location = new System.Drawing.Point(621, 12);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(53, 48);
			this.buttonOK.TabIndex = 2;
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.ButtonOKClick);
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
			this.labeltitulo.Size = new System.Drawing.Size(302, 37);
			this.labeltitulo.TabIndex = 0;
			this.labeltitulo.Text = "Agrega Inquilino";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
			this.panel2.Controls.Add(this.labelImagen);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.dateTimePickerfinal);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.dateTimePickerInicio);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.monthCalendarNacimiento);
			this.panel2.Controls.Add(this.textBoxCarnet);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.textBoxMaterno);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.textBoxPaterno);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.textBoxNombre);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(73)))), ((int)(((byte)(64)))));
			this.panel2.Location = new System.Drawing.Point(0, 74);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(686, 365);
			this.panel2.TabIndex = 5;
			// 
			// labelImagen
			// 
			this.labelImagen.ImageList = this.imageList1;
			this.labelImagen.Location = new System.Drawing.Point(3, 36);
			this.labelImagen.Name = "labelImagen";
			this.labelImagen.Size = new System.Drawing.Size(157, 140);
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
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(411, 280);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(210, 23);
			this.label7.TabIndex = 19;
			this.label7.Text = "final";
			// 
			// dateTimePickerfinal
			// 
			this.dateTimePickerfinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerfinal.Location = new System.Drawing.Point(409, 306);
			this.dateTimePickerfinal.Name = "dateTimePickerfinal";
			this.dateTimePickerfinal.Size = new System.Drawing.Size(156, 34);
			this.dateTimePickerfinal.TabIndex = 18;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(167, 280);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(210, 23);
			this.label6.TabIndex = 17;
			this.label6.Text = "Inicio";
			// 
			// dateTimePickerInicio
			// 
			this.dateTimePickerInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerInicio.Location = new System.Drawing.Point(165, 306);
			this.dateTimePickerInicio.Name = "dateTimePickerInicio";
			this.dateTimePickerInicio.Size = new System.Drawing.Size(156, 34);
			this.dateTimePickerInicio.TabIndex = 16;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(411, 79);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(210, 23);
			this.label5.TabIndex = 15;
			this.label5.Text = "Fecha Nacimiento";
			// 
			// monthCalendarNacimiento
			// 
			this.monthCalendarNacimiento.Location = new System.Drawing.Point(412, 106);
			this.monthCalendarNacimiento.Name = "monthCalendarNacimiento";
			this.monthCalendarNacimiento.TabIndex = 14;
			// 
			// textBoxCarnet
			// 
			this.textBoxCarnet.Location = new System.Drawing.Point(412, 33);
			this.textBoxCarnet.Name = "textBoxCarnet";
			this.textBoxCarnet.Size = new System.Drawing.Size(190, 34);
			this.textBoxCarnet.TabIndex = 13;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(411, 6);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(210, 23);
			this.label4.TabIndex = 12;
			this.label4.Text = "Carnet";
			// 
			// textBoxMaterno
			// 
			this.textBoxMaterno.Location = new System.Drawing.Point(168, 180);
			this.textBoxMaterno.Name = "textBoxMaterno";
			this.textBoxMaterno.Size = new System.Drawing.Size(221, 34);
			this.textBoxMaterno.TabIndex = 11;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(167, 153);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(210, 23);
			this.label2.TabIndex = 10;
			this.label2.Text = "Materno";
			// 
			// textBoxPaterno
			// 
			this.textBoxPaterno.Location = new System.Drawing.Point(167, 106);
			this.textBoxPaterno.Name = "textBoxPaterno";
			this.textBoxPaterno.Size = new System.Drawing.Size(221, 34);
			this.textBoxPaterno.TabIndex = 9;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(166, 79);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(210, 23);
			this.label1.TabIndex = 8;
			this.label1.Text = "Paterno";
			// 
			// textBoxNombre
			// 
			this.textBoxNombre.Location = new System.Drawing.Point(166, 33);
			this.textBoxNombre.Name = "textBoxNombre";
			this.textBoxNombre.Size = new System.Drawing.Size(221, 34);
			this.textBoxNombre.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(165, 6);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(210, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Nombre";
			// 
			// VentanaAgregaInquilino
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(686, 439);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "VentanaAgregaInquilino";
			this.Text = "VentanaAgregaInquilino";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Label labelImagen;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxNombre;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxPaterno;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxMaterno;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxCarnet;
		private System.Windows.Forms.MonthCalendar monthCalendarNacimiento;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dateTimePickerInicio;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DateTimePicker dateTimePickerfinal;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label labeltitulo;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
	}
}
