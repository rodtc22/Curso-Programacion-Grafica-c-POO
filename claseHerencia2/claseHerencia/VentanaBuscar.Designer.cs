/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 14/7/2022
 * Time: 20:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace claseHerencia
{
	partial class VentanaBuscar
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaBuscar));
			this.panel2 = new System.Windows.Forms.Panel();
			this.textBoxNombre = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonBuscar = new System.Windows.Forms.Button();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(170)))), ((int)(((byte)(160)))));
			this.panel2.Controls.Add(this.buttonBuscar);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.textBoxNombre);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(25)))), ((int)(((byte)(23)))));
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(333, 132);
			this.panel2.TabIndex = 5;
			// 
			// textBoxNombre
			// 
			this.textBoxNombre.Location = new System.Drawing.Point(84, 74);
			this.textBoxNombre.Name = "textBoxNombre";
			this.textBoxNombre.Size = new System.Drawing.Size(221, 27);
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
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(227, 23);
			this.label1.TabIndex = 5;
			this.label1.Text = "Ingresa el nombre para buscar";
			// 
			// buttonBuscar
			// 
			this.buttonBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBuscar.BackgroundImage")));
			this.buttonBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonBuscar.Location = new System.Drawing.Point(265, 10);
			this.buttonBuscar.Name = "buttonBuscar";
			this.buttonBuscar.Size = new System.Drawing.Size(40, 40);
			this.buttonBuscar.TabIndex = 6;
			this.buttonBuscar.UseVisualStyleBackColor = true;
			this.buttonBuscar.Click += new System.EventHandler(this.ButtonBuscarClick);
			// 
			// VentanaBuscar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(333, 132);
			this.Controls.Add(this.panel2);
			this.Name = "VentanaBuscar";
			this.Text = "VentanaBuscar";
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxNombre;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonBuscar;
		private System.Windows.Forms.Panel panel2;
	}
}
