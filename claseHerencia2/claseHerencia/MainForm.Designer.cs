/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 14/7/2022
 * Time: 10:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace claseHerencia
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.buttonOcultarPanelIzq = new System.Windows.Forms.Button();
			this.labelFechaFundacion = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.labelTitulo = new System.Windows.Forms.Label();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.buttonBuscarPeriodista = new System.Windows.Forms.Button();
			this.buttonAgregarPeriodista = new System.Windows.Forms.Button();
			this.buttonMostrarEscritores = new System.Windows.Forms.Button();
			this.buttonMostrarConductores = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.flowLayoutPanelDatos = new System.Windows.Forms.FlowLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.flowLayoutPanelDatos.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(25)))), ((int)(((byte)(23)))));
			this.panel1.Controls.Add(this.buttonOcultarPanelIzq);
			this.panel1.Controls.Add(this.labelFechaFundacion);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.labelTitulo);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(170)))), ((int)(((byte)(160)))));
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(693, 88);
			this.panel1.TabIndex = 0;
			// 
			// buttonOcultarPanelIzq
			// 
			this.buttonOcultarPanelIzq.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonOcultarPanelIzq.BackgroundImage")));
			this.buttonOcultarPanelIzq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonOcultarPanelIzq.FlatAppearance.BorderSize = 0;
			this.buttonOcultarPanelIzq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonOcultarPanelIzq.Location = new System.Drawing.Point(606, 20);
			this.buttonOcultarPanelIzq.Name = "buttonOcultarPanelIzq";
			this.buttonOcultarPanelIzq.Size = new System.Drawing.Size(52, 53);
			this.buttonOcultarPanelIzq.TabIndex = 0;
			this.buttonOcultarPanelIzq.UseVisualStyleBackColor = true;
			this.buttonOcultarPanelIzq.Click += new System.EventHandler(this.ButtonOcultarPanelIzqClick);
			// 
			// labelFechaFundacion
			// 
			this.labelFechaFundacion.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelFechaFundacion.Location = new System.Drawing.Point(208, 50);
			this.labelFechaFundacion.Name = "labelFechaFundacion";
			this.labelFechaFundacion.Size = new System.Drawing.Size(184, 23);
			this.labelFechaFundacion.TabIndex = 2;
			this.labelFechaFundacion.Text = "labelFechafundacion";
			this.labelFechaFundacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(29, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(50, 50);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// labelTitulo
			// 
			this.labelTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelTitulo.Font = new System.Drawing.Font("Impact", 22.25F);
			this.labelTitulo.Location = new System.Drawing.Point(148, 9);
			this.labelTitulo.Name = "labelTitulo";
			this.labelTitulo.Size = new System.Drawing.Size(395, 41);
			this.labelTitulo.TabIndex = 0;
			this.labelTitulo.Text = "FEDERACION DE PERIODISTAS";
			this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Location = new System.Drawing.Point(12, 103);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(81)))), ((int)(((byte)(64)))));
			this.splitContainer1.Panel1.Controls.Add(this.buttonBuscarPeriodista);
			this.splitContainer1.Panel1.Controls.Add(this.buttonAgregarPeriodista);
			this.splitContainer1.Panel1.Controls.Add(this.buttonMostrarEscritores);
			this.splitContainer1.Panel1.Controls.Add(this.buttonMostrarConductores);
			this.splitContainer1.Panel1.Controls.Add(this.panel2);
			this.splitContainer1.Panel1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.splitContainer1.Panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(170)))), ((int)(((byte)(160)))));
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(170)))), ((int)(((byte)(160)))));
			this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanelDatos);
			this.splitContainer1.Panel2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.splitContainer1.Panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(25)))), ((int)(((byte)(23)))));
			this.splitContainer1.Size = new System.Drawing.Size(669, 347);
			this.splitContainer1.SplitterDistance = 175;
			this.splitContainer1.TabIndex = 1;
			// 
			// buttonBuscarPeriodista
			// 
			this.buttonBuscarPeriodista.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonBuscarPeriodista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(25)))), ((int)(((byte)(23)))));
			this.buttonBuscarPeriodista.Location = new System.Drawing.Point(0, 191);
			this.buttonBuscarPeriodista.Name = "buttonBuscarPeriodista";
			this.buttonBuscarPeriodista.Size = new System.Drawing.Size(175, 48);
			this.buttonBuscarPeriodista.TabIndex = 4;
			this.buttonBuscarPeriodista.Text = "Buscar Periodista";
			this.buttonBuscarPeriodista.UseVisualStyleBackColor = true;
			this.buttonBuscarPeriodista.Click += new System.EventHandler(this.ButtonBuscarPeriodistaClick);
			// 
			// buttonAgregarPeriodista
			// 
			this.buttonAgregarPeriodista.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonAgregarPeriodista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(25)))), ((int)(((byte)(23)))));
			this.buttonAgregarPeriodista.Location = new System.Drawing.Point(0, 143);
			this.buttonAgregarPeriodista.Name = "buttonAgregarPeriodista";
			this.buttonAgregarPeriodista.Size = new System.Drawing.Size(175, 48);
			this.buttonAgregarPeriodista.TabIndex = 3;
			this.buttonAgregarPeriodista.Text = "Agregar Periodista";
			this.buttonAgregarPeriodista.UseVisualStyleBackColor = true;
			this.buttonAgregarPeriodista.Click += new System.EventHandler(this.ButtonAgregarPeriodistaClick);
			// 
			// buttonMostrarEscritores
			// 
			this.buttonMostrarEscritores.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonMostrarEscritores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(25)))), ((int)(((byte)(23)))));
			this.buttonMostrarEscritores.Location = new System.Drawing.Point(0, 87);
			this.buttonMostrarEscritores.Name = "buttonMostrarEscritores";
			this.buttonMostrarEscritores.Size = new System.Drawing.Size(175, 56);
			this.buttonMostrarEscritores.TabIndex = 2;
			this.buttonMostrarEscritores.Text = "Mostrar Escritores";
			this.buttonMostrarEscritores.UseVisualStyleBackColor = true;
			// 
			// buttonMostrarConductores
			// 
			this.buttonMostrarConductores.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonMostrarConductores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(25)))), ((int)(((byte)(23)))));
			this.buttonMostrarConductores.Location = new System.Drawing.Point(0, 35);
			this.buttonMostrarConductores.Name = "buttonMostrarConductores";
			this.buttonMostrarConductores.Size = new System.Drawing.Size(175, 52);
			this.buttonMostrarConductores.TabIndex = 1;
			this.buttonMostrarConductores.Text = "Mostrar Conductores";
			this.buttonMostrarConductores.UseVisualStyleBackColor = true;
			this.buttonMostrarConductores.Click += new System.EventHandler(this.ButtonMostrarConductoresClick);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(81)))), ((int)(((byte)(64)))));
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(175, 35);
			this.panel2.TabIndex = 0;
			// 
			// flowLayoutPanelDatos
			// 
			this.flowLayoutPanelDatos.AutoScroll = true;
			this.flowLayoutPanelDatos.Controls.Add(this.label1);
			this.flowLayoutPanelDatos.Controls.Add(this.label2);
			this.flowLayoutPanelDatos.Controls.Add(this.label3);
			this.flowLayoutPanelDatos.Controls.Add(this.label4);
			this.flowLayoutPanelDatos.Controls.Add(this.label5);
			this.flowLayoutPanelDatos.Controls.Add(this.label6);
			this.flowLayoutPanelDatos.Controls.Add(this.label7);
			this.flowLayoutPanelDatos.Controls.Add(this.label8);
			this.flowLayoutPanelDatos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanelDatos.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanelDatos.Name = "flowLayoutPanelDatos";
			this.flowLayoutPanelDatos.Size = new System.Drawing.Size(490, 347);
			this.flowLayoutPanelDatos.TabIndex = 1;
			this.flowLayoutPanelDatos.WrapContents = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 22);
			this.label1.TabIndex = 1;
			this.label1.Text = "label1";
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label2.Location = new System.Drawing.Point(58, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 22);
			this.label2.TabIndex = 2;
			this.label2.Text = "label2";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label3.Location = new System.Drawing.Point(115, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 22);
			this.label3.TabIndex = 3;
			this.label3.Text = "label3";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label4.Location = new System.Drawing.Point(172, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(51, 22);
			this.label4.TabIndex = 4;
			this.label4.Text = "label4";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label5.Location = new System.Drawing.Point(229, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(52, 22);
			this.label5.TabIndex = 5;
			this.label5.Text = "label5";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label6.Location = new System.Drawing.Point(287, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(52, 22);
			this.label6.TabIndex = 6;
			this.label6.Text = "label6";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label7.Location = new System.Drawing.Point(345, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(49, 22);
			this.label7.TabIndex = 7;
			this.label7.Text = "label7";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label8.Location = new System.Drawing.Point(400, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(52, 22);
			this.label8.TabIndex = 8;
			this.label8.Text = "label8";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(693, 468);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.panel1);
			this.Name = "MainForm";
			this.Text = "claseHerencia";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.flowLayoutPanelDatos.ResumeLayout(false);
			this.flowLayoutPanelDatos.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDatos;
		private System.Windows.Forms.Button buttonBuscarPeriodista;
		private System.Windows.Forms.Button buttonOcultarPanelIzq;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button buttonMostrarConductores;
		private System.Windows.Forms.Button buttonMostrarEscritores;
		private System.Windows.Forms.Button buttonAgregarPeriodista;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Label labelFechaFundacion;
		private System.Windows.Forms.Label labelTitulo;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
	}
}
