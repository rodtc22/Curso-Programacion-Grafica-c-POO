/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 7/4/2022
 * Time: 10:06 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace clasePOO
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
			this.labelconsola = new System.Windows.Forms.Label();
			this.panelcabecera = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panelpie = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panelcontenido = new System.Windows.Forms.Panel();
			this.buttonGenerarNomUsuario = new System.Windows.Forms.Button();
			this.buttonMayorEdad = new System.Windows.Forms.Button();
			this.buttonNombrePalindrome = new System.Windows.Forms.Button();
			this.buttonGuardar = new System.Windows.Forms.Button();
			this.textBoxMaterno = new System.Windows.Forms.TextBox();
			this.labelMaterno = new System.Windows.Forms.Label();
			this.textBoxPaterno = new System.Windows.Forms.TextBox();
			this.labelPaterno = new System.Windows.Forms.Label();
			this.textBoxNombre = new System.Windows.Forms.TextBox();
			this.labelNombre = new System.Windows.Forms.Label();
			this.textBoxFechaNac = new System.Windows.Forms.TextBox();
			this.labelFechaNac = new System.Windows.Forms.Label();
			this.textBoxCi = new System.Windows.Forms.TextBox();
			this.labelCi = new System.Windows.Forms.Label();
			this.textBoxCarrera = new System.Windows.Forms.TextBox();
			this.labelCarrera = new System.Windows.Forms.Label();
			this.textBoxidEstudiante = new System.Windows.Forms.TextBox();
			this.labelidEstudiante = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panelcabecera.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panelpie.SuspendLayout();
			this.panelcontenido.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelconsola
			// 
			this.labelconsola.BackColor = System.Drawing.Color.Black;
			this.labelconsola.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelconsola.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.labelconsola.Location = new System.Drawing.Point(331, 12);
			this.labelconsola.Name = "labelconsola";
			this.labelconsola.Size = new System.Drawing.Size(64, 32);
			this.labelconsola.TabIndex = 0;
			// 
			// panelcabecera
			// 
			this.panelcabecera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(90)))), ((int)(((byte)(51)))));
			this.panelcabecera.Controls.Add(this.pictureBox1);
			this.panelcabecera.Controls.Add(this.label1);
			this.panelcabecera.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelcabecera.Font = new System.Drawing.Font("Consolas", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panelcabecera.Location = new System.Drawing.Point(0, 0);
			this.panelcabecera.Name = "panelcabecera";
			this.panelcabecera.Size = new System.Drawing.Size(407, 64);
			this.panelcabecera.TabIndex = 1;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox1.Location = new System.Drawing.Point(327, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(68, 57);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("Consolas", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(407, 64);
			this.label1.TabIndex = 0;
			this.label1.Text = "Control de Estudiante";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panelpie
			// 
			this.panelpie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(22)))), ((int)(((byte)(44)))));
			this.panelpie.Controls.Add(this.label4);
			this.panelpie.Controls.Add(this.labelconsola);
			this.panelpie.Controls.Add(this.label3);
			this.panelpie.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelpie.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panelpie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(169)))), ((int)(((byte)(149)))));
			this.panelpie.Location = new System.Drawing.Point(0, 443);
			this.panelpie.Name = "panelpie";
			this.panelpie.Size = new System.Drawing.Size(407, 67);
			this.panelpie.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 34);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(233, 23);
			this.label4.TabIndex = 1;
			this.label4.Text = "Correo: rodritc99@gmail.com";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 11);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(243, 23);
			this.label3.TabIndex = 0;
			this.label3.Text = "Autor: Rodrigo Ticona Coronel";
			// 
			// panelcontenido
			// 
			this.panelcontenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(169)))), ((int)(((byte)(149)))));
			this.panelcontenido.Controls.Add(this.buttonGenerarNomUsuario);
			this.panelcontenido.Controls.Add(this.buttonMayorEdad);
			this.panelcontenido.Controls.Add(this.buttonNombrePalindrome);
			this.panelcontenido.Controls.Add(this.buttonGuardar);
			this.panelcontenido.Controls.Add(this.textBoxMaterno);
			this.panelcontenido.Controls.Add(this.labelMaterno);
			this.panelcontenido.Controls.Add(this.textBoxPaterno);
			this.panelcontenido.Controls.Add(this.labelPaterno);
			this.panelcontenido.Controls.Add(this.textBoxNombre);
			this.panelcontenido.Controls.Add(this.labelNombre);
			this.panelcontenido.Controls.Add(this.textBoxFechaNac);
			this.panelcontenido.Controls.Add(this.labelFechaNac);
			this.panelcontenido.Controls.Add(this.textBoxCi);
			this.panelcontenido.Controls.Add(this.labelCi);
			this.panelcontenido.Controls.Add(this.textBoxCarrera);
			this.panelcontenido.Controls.Add(this.labelCarrera);
			this.panelcontenido.Controls.Add(this.textBoxidEstudiante);
			this.panelcontenido.Controls.Add(this.labelidEstudiante);
			this.panelcontenido.Controls.Add(this.label2);
			this.panelcontenido.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelcontenido.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panelcontenido.Location = new System.Drawing.Point(0, 64);
			this.panelcontenido.Name = "panelcontenido";
			this.panelcontenido.Size = new System.Drawing.Size(407, 379);
			this.panelcontenido.TabIndex = 4;
			// 
			// buttonGenerarNomUsuario
			// 
			this.buttonGenerarNomUsuario.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonGenerarNomUsuario.Location = new System.Drawing.Point(270, 312);
			this.buttonGenerarNomUsuario.Name = "buttonGenerarNomUsuario";
			this.buttonGenerarNomUsuario.Size = new System.Drawing.Size(129, 51);
			this.buttonGenerarNomUsuario.TabIndex = 19;
			this.buttonGenerarNomUsuario.Text = "Generar Nombre Usuario";
			this.buttonGenerarNomUsuario.UseVisualStyleBackColor = true;
			this.buttonGenerarNomUsuario.Click += new System.EventHandler(this.ButtonGenerarNomUsuarioClick);
			// 
			// buttonMayorEdad
			// 
			this.buttonMayorEdad.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonMayorEdad.Location = new System.Drawing.Point(144, 312);
			this.buttonMayorEdad.Name = "buttonMayorEdad";
			this.buttonMayorEdad.Size = new System.Drawing.Size(111, 51);
			this.buttonMayorEdad.TabIndex = 18;
			this.buttonMayorEdad.Text = "Mayor de Edad";
			this.buttonMayorEdad.UseVisualStyleBackColor = true;
			this.buttonMayorEdad.Click += new System.EventHandler(this.ButtonMayorEdadClick);
			// 
			// buttonNombrePalindrome
			// 
			this.buttonNombrePalindrome.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonNombrePalindrome.Location = new System.Drawing.Point(12, 312);
			this.buttonNombrePalindrome.Name = "buttonNombrePalindrome";
			this.buttonNombrePalindrome.Size = new System.Drawing.Size(111, 51);
			this.buttonNombrePalindrome.TabIndex = 17;
			this.buttonNombrePalindrome.Text = "Nombre Palindrome";
			this.buttonNombrePalindrome.UseVisualStyleBackColor = true;
			this.buttonNombrePalindrome.Click += new System.EventHandler(this.ButtonNombrePalindromeClick);
			// 
			// buttonGuardar
			// 
			this.buttonGuardar.BackColor = System.Drawing.Color.Transparent;
			this.buttonGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonGuardar.BackgroundImage")));
			this.buttonGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonGuardar.FlatAppearance.BorderSize = 0;
			this.buttonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonGuardar.Location = new System.Drawing.Point(345, 6);
			this.buttonGuardar.Name = "buttonGuardar";
			this.buttonGuardar.Size = new System.Drawing.Size(45, 45);
			this.buttonGuardar.TabIndex = 16;
			this.buttonGuardar.UseVisualStyleBackColor = false;
			this.buttonGuardar.Click += new System.EventHandler(this.ButtonGuardarClick);
			// 
			// textBoxMaterno
			// 
			this.textBoxMaterno.Location = new System.Drawing.Point(123, 261);
			this.textBoxMaterno.Name = "textBoxMaterno";
			this.textBoxMaterno.Size = new System.Drawing.Size(199, 29);
			this.textBoxMaterno.TabIndex = 15;
			// 
			// labelMaterno
			// 
			this.labelMaterno.Location = new System.Drawing.Point(26, 264);
			this.labelMaterno.Name = "labelMaterno";
			this.labelMaterno.Size = new System.Drawing.Size(111, 23);
			this.labelMaterno.TabIndex = 14;
			this.labelMaterno.Text = "Materno";
			// 
			// textBoxPaterno
			// 
			this.textBoxPaterno.Location = new System.Drawing.Point(123, 226);
			this.textBoxPaterno.Name = "textBoxPaterno";
			this.textBoxPaterno.Size = new System.Drawing.Size(199, 29);
			this.textBoxPaterno.TabIndex = 13;
			// 
			// labelPaterno
			// 
			this.labelPaterno.Location = new System.Drawing.Point(26, 229);
			this.labelPaterno.Name = "labelPaterno";
			this.labelPaterno.Size = new System.Drawing.Size(111, 23);
			this.labelPaterno.TabIndex = 12;
			this.labelPaterno.Text = "Paterno";
			// 
			// textBoxNombre
			// 
			this.textBoxNombre.Location = new System.Drawing.Point(123, 191);
			this.textBoxNombre.Name = "textBoxNombre";
			this.textBoxNombre.Size = new System.Drawing.Size(199, 29);
			this.textBoxNombre.TabIndex = 11;
			// 
			// labelNombre
			// 
			this.labelNombre.Location = new System.Drawing.Point(26, 194);
			this.labelNombre.Name = "labelNombre";
			this.labelNombre.Size = new System.Drawing.Size(111, 23);
			this.labelNombre.TabIndex = 10;
			this.labelNombre.Text = "Nombre";
			// 
			// textBoxFechaNac
			// 
			this.textBoxFechaNac.Location = new System.Drawing.Point(123, 156);
			this.textBoxFechaNac.Name = "textBoxFechaNac";
			this.textBoxFechaNac.Size = new System.Drawing.Size(199, 29);
			this.textBoxFechaNac.TabIndex = 9;
			// 
			// labelFechaNac
			// 
			this.labelFechaNac.Location = new System.Drawing.Point(26, 159);
			this.labelFechaNac.Name = "labelFechaNac";
			this.labelFechaNac.Size = new System.Drawing.Size(111, 23);
			this.labelFechaNac.TabIndex = 8;
			this.labelFechaNac.Text = "Fecha Nac";
			// 
			// textBoxCi
			// 
			this.textBoxCi.Location = new System.Drawing.Point(123, 118);
			this.textBoxCi.Name = "textBoxCi";
			this.textBoxCi.Size = new System.Drawing.Size(199, 29);
			this.textBoxCi.TabIndex = 7;
			// 
			// labelCi
			// 
			this.labelCi.Location = new System.Drawing.Point(26, 124);
			this.labelCi.Name = "labelCi";
			this.labelCi.Size = new System.Drawing.Size(111, 23);
			this.labelCi.TabIndex = 6;
			this.labelCi.Text = "Ci";
			// 
			// textBoxCarrera
			// 
			this.textBoxCarrera.Location = new System.Drawing.Point(123, 83);
			this.textBoxCarrera.Name = "textBoxCarrera";
			this.textBoxCarrera.Size = new System.Drawing.Size(199, 29);
			this.textBoxCarrera.TabIndex = 5;
			// 
			// labelCarrera
			// 
			this.labelCarrera.Location = new System.Drawing.Point(26, 89);
			this.labelCarrera.Name = "labelCarrera";
			this.labelCarrera.Size = new System.Drawing.Size(111, 23);
			this.labelCarrera.TabIndex = 4;
			this.labelCarrera.Text = "Carrera";
			// 
			// textBoxidEstudiante
			// 
			this.textBoxidEstudiante.Location = new System.Drawing.Point(123, 48);
			this.textBoxidEstudiante.Name = "textBoxidEstudiante";
			this.textBoxidEstudiante.Size = new System.Drawing.Size(199, 29);
			this.textBoxidEstudiante.TabIndex = 3;
			// 
			// labelidEstudiante
			// 
			this.labelidEstudiante.Location = new System.Drawing.Point(26, 54);
			this.labelidEstudiante.Name = "labelidEstudiante";
			this.labelidEstudiante.Size = new System.Drawing.Size(134, 23);
			this.labelidEstudiante.TabIndex = 2;
			this.labelidEstudiante.Text = "Id";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(26, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(213, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Datos del Estudiante";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(407, 510);
			this.Controls.Add(this.panelcontenido);
			this.Controls.Add(this.panelpie);
			this.Controls.Add(this.panelcabecera);
			this.Name = "MainForm";
			this.Text = "clasePOO";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.panelcabecera.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panelpie.ResumeLayout(false);
			this.panelcontenido.ResumeLayout(false);
			this.panelcontenido.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button buttonNombrePalindrome;
		private System.Windows.Forms.Button buttonMayorEdad;
		private System.Windows.Forms.Button buttonGenerarNomUsuario;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button buttonGuardar;
		private System.Windows.Forms.Label labelidEstudiante;
		private System.Windows.Forms.TextBox textBoxidEstudiante;
		private System.Windows.Forms.Label labelCarrera;
		private System.Windows.Forms.TextBox textBoxCarrera;
		private System.Windows.Forms.Label labelCi;
		private System.Windows.Forms.TextBox textBoxCi;
		private System.Windows.Forms.Label labelFechaNac;
		private System.Windows.Forms.TextBox textBoxFechaNac;
		private System.Windows.Forms.Label labelNombre;
		private System.Windows.Forms.TextBox textBoxNombre;
		private System.Windows.Forms.Label labelPaterno;
		private System.Windows.Forms.TextBox textBoxPaterno;
		private System.Windows.Forms.Label labelMaterno;
		private System.Windows.Forms.TextBox textBoxMaterno;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panelpie;
		private System.Windows.Forms.Panel panelcontenido;
		private System.Windows.Forms.Panel panelcabecera;
		private System.Windows.Forms.Label labelconsola;
	}
}
