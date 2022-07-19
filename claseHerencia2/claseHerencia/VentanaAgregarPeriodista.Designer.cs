/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 14/7/2022
 * Time: 19:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace claseHerencia
{
	partial class VentanaAgregarPeriodista
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaAgregarPeriodista));
			this.labelTitulo = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.buttonAgregar = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panelEscritor = new System.Windows.Forms.Panel();
			this.textBoxSector = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.textBoxPeriodico = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.panelConductor = new System.Windows.Forms.Panel();
			this.textBoxPrograma = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.textBoxCasa = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.comboBoxEmpleado = new System.Windows.Forms.ComboBox();
			this.textBoxSueldo = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxId = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxCi = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxFechaNac = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxNombre = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.radioButtonEscritor = new System.Windows.Forms.RadioButton();
			this.radioButtonConductor = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panelEscritor.SuspendLayout();
			this.panelConductor.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelTitulo
			// 
			this.labelTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelTitulo.Font = new System.Drawing.Font("Impact", 22.25F);
			this.labelTitulo.Location = new System.Drawing.Point(109, 14);
			this.labelTitulo.Name = "labelTitulo";
			this.labelTitulo.Size = new System.Drawing.Size(283, 41);
			this.labelTitulo.TabIndex = 0;
			this.labelTitulo.Text = "AGREGAR PERIODISTA";
			this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(12, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(62, 59);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(81)))), ((int)(((byte)(64)))));
			this.panel1.Controls.Add(this.buttonAgregar);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.labelTitulo);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(170)))), ((int)(((byte)(160)))));
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(530, 68);
			this.panel1.TabIndex = 2;
			// 
			// buttonAgregar
			// 
			this.buttonAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(25)))), ((int)(((byte)(23)))));
			this.buttonAgregar.Location = new System.Drawing.Point(411, 14);
			this.buttonAgregar.Name = "buttonAgregar";
			this.buttonAgregar.Size = new System.Drawing.Size(89, 41);
			this.buttonAgregar.TabIndex = 2;
			this.buttonAgregar.Text = "Agregar";
			this.buttonAgregar.UseVisualStyleBackColor = true;
			this.buttonAgregar.Click += new System.EventHandler(this.ButtonAgregarClick);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(170)))), ((int)(((byte)(160)))));
			this.panel2.Controls.Add(this.panelEscritor);
			this.panel2.Controls.Add(this.panelConductor);
			this.panel2.Controls.Add(this.comboBoxEmpleado);
			this.panel2.Controls.Add(this.textBoxSueldo);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.textBoxId);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.textBoxCi);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.textBoxFechaNac);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.textBoxNombre);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.radioButtonEscritor);
			this.panel2.Controls.Add(this.radioButtonConductor);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(25)))), ((int)(((byte)(23)))));
			this.panel2.Location = new System.Drawing.Point(0, 68);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(530, 304);
			this.panel2.TabIndex = 4;
			// 
			// panelEscritor
			// 
			this.panelEscritor.Controls.Add(this.textBoxSector);
			this.panelEscritor.Controls.Add(this.label10);
			this.panelEscritor.Controls.Add(this.textBoxPeriodico);
			this.panelEscritor.Controls.Add(this.label11);
			this.panelEscritor.Location = new System.Drawing.Point(352, 158);
			this.panelEscritor.Name = "panelEscritor";
			this.panelEscritor.Size = new System.Drawing.Size(144, 122);
			this.panelEscritor.TabIndex = 20;
			this.panelEscritor.Visible = false;
			// 
			// textBoxSector
			// 
			this.textBoxSector.Location = new System.Drawing.Point(3, 82);
			this.textBoxSector.Name = "textBoxSector";
			this.textBoxSector.Size = new System.Drawing.Size(128, 27);
			this.textBoxSector.TabIndex = 19;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(3, 57);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 23);
			this.label10.TabIndex = 18;
			this.label10.Text = "Sector";
			// 
			// textBoxPeriodico
			// 
			this.textBoxPeriodico.Location = new System.Drawing.Point(3, 27);
			this.textBoxPeriodico.Name = "textBoxPeriodico";
			this.textBoxPeriodico.Size = new System.Drawing.Size(128, 27);
			this.textBoxPeriodico.TabIndex = 17;
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(3, 2);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(128, 23);
			this.label11.TabIndex = 17;
			this.label11.Text = "Periodico";
			// 
			// panelConductor
			// 
			this.panelConductor.Controls.Add(this.textBoxPrograma);
			this.panelConductor.Controls.Add(this.label9);
			this.panelConductor.Controls.Add(this.textBoxCasa);
			this.panelConductor.Controls.Add(this.label8);
			this.panelConductor.Location = new System.Drawing.Point(352, 12);
			this.panelConductor.Name = "panelConductor";
			this.panelConductor.Size = new System.Drawing.Size(144, 122);
			this.panelConductor.TabIndex = 16;
			// 
			// textBoxPrograma
			// 
			this.textBoxPrograma.Location = new System.Drawing.Point(3, 82);
			this.textBoxPrograma.Name = "textBoxPrograma";
			this.textBoxPrograma.Size = new System.Drawing.Size(128, 27);
			this.textBoxPrograma.TabIndex = 19;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(3, 57);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 18;
			this.label9.Text = "Programa";
			// 
			// textBoxCasa
			// 
			this.textBoxCasa.Location = new System.Drawing.Point(3, 27);
			this.textBoxCasa.Name = "textBoxCasa";
			this.textBoxCasa.Size = new System.Drawing.Size(128, 27);
			this.textBoxCasa.TabIndex = 17;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(3, 2);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(128, 23);
			this.label8.TabIndex = 17;
			this.label8.Text = "Casa Televisiva";
			// 
			// comboBoxEmpleado
			// 
			this.comboBoxEmpleado.FormattingEnabled = true;
			this.comboBoxEmpleado.Items.AddRange(new object[] {
									"Si",
									"No"});
			this.comboBoxEmpleado.Location = new System.Drawing.Point(132, 210);
			this.comboBoxEmpleado.Name = "comboBoxEmpleado";
			this.comboBoxEmpleado.Size = new System.Drawing.Size(180, 28);
			this.comboBoxEmpleado.TabIndex = 15;
			// 
			// textBoxSueldo
			// 
			this.textBoxSueldo.Location = new System.Drawing.Point(132, 243);
			this.textBoxSueldo.Name = "textBoxSueldo";
			this.textBoxSueldo.Size = new System.Drawing.Size(180, 27);
			this.textBoxSueldo.TabIndex = 14;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(12, 243);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 13;
			this.label7.Text = "Sueldo";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(12, 210);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 11;
			this.label6.Text = "Empleado";
			// 
			// textBoxId
			// 
			this.textBoxId.Location = new System.Drawing.Point(132, 177);
			this.textBoxId.Name = "textBoxId";
			this.textBoxId.Size = new System.Drawing.Size(180, 27);
			this.textBoxId.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(12, 177);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 9;
			this.label5.Text = "ID:";
			// 
			// textBoxCi
			// 
			this.textBoxCi.Location = new System.Drawing.Point(132, 144);
			this.textBoxCi.Name = "textBoxCi";
			this.textBoxCi.Size = new System.Drawing.Size(180, 27);
			this.textBoxCi.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 144);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "Carnet";
			// 
			// textBoxFechaNac
			// 
			this.textBoxFechaNac.Location = new System.Drawing.Point(132, 111);
			this.textBoxFechaNac.Name = "textBoxFechaNac";
			this.textBoxFechaNac.Size = new System.Drawing.Size(180, 27);
			this.textBoxFechaNac.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 111);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Fecha Nac:";
			// 
			// textBoxNombre
			// 
			this.textBoxNombre.Location = new System.Drawing.Point(132, 78);
			this.textBoxNombre.Name = "textBoxNombre";
			this.textBoxNombre.Size = new System.Drawing.Size(180, 27);
			this.textBoxNombre.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 78);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Nombre:";
			// 
			// radioButtonEscritor
			// 
			this.radioButtonEscritor.Location = new System.Drawing.Point(170, 42);
			this.radioButtonEscritor.Name = "radioButtonEscritor";
			this.radioButtonEscritor.Size = new System.Drawing.Size(176, 24);
			this.radioButtonEscritor.TabIndex = 2;
			this.radioButtonEscritor.Text = "Escritor de Periodico";
			this.radioButtonEscritor.UseVisualStyleBackColor = true;
			this.radioButtonEscritor.CheckedChanged += new System.EventHandler(this.RadioButtonEscritorCheckedChanged);
			// 
			// radioButtonConductor
			// 
			this.radioButtonConductor.Checked = true;
			this.radioButtonConductor.Location = new System.Drawing.Point(170, 12);
			this.radioButtonConductor.Name = "radioButtonConductor";
			this.radioButtonConductor.Size = new System.Drawing.Size(142, 24);
			this.radioButtonConductor.TabIndex = 1;
			this.radioButtonConductor.TabStop = true;
			this.radioButtonConductor.Text = "Conductor de TV";
			this.radioButtonConductor.UseVisualStyleBackColor = true;
			this.radioButtonConductor.CheckedChanged += new System.EventHandler(this.RadioButtonConductorCheckedChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(3, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(139, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tipo de Periodista";
			// 
			// VentanaAgregarPeriodista
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(530, 372);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "VentanaAgregarPeriodista";
			this.Text = "VentanaAgregarPeriodista";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panelEscritor.ResumeLayout(false);
			this.panelEscritor.PerformLayout();
			this.panelConductor.ResumeLayout(false);
			this.panelConductor.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button buttonAgregar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxNombre;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxFechaNac;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxCi;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxId;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBoxSueldo;
		private System.Windows.Forms.ComboBox comboBoxEmpleado;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBoxCasa;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBoxPrograma;
		private System.Windows.Forms.Panel panelConductor;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textBoxPeriodico;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textBoxSector;
		private System.Windows.Forms.Panel panelEscritor;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton radioButtonConductor;
		private System.Windows.Forms.RadioButton radioButtonEscritor;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label labelTitulo;
	}
}
