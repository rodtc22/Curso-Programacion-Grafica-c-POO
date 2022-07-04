/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 7/3/2022
 * Time: 11:31 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace clase1
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
			this.labeltitulo = new System.Windows.Forms.Label();
			this.buttonSaludar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labeltitulo
			// 
			this.labeltitulo.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.labeltitulo.BackColor = System.Drawing.Color.Transparent;
			this.labeltitulo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.labeltitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.labeltitulo.Font = new System.Drawing.Font("Comic Sans MS", 25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labeltitulo.ForeColor = System.Drawing.Color.Cyan;
			this.labeltitulo.Location = new System.Drawing.Point(77, 42);
			this.labeltitulo.Name = "labeltitulo";
			this.labeltitulo.Size = new System.Drawing.Size(222, 121);
			this.labeltitulo.TabIndex = 0;
			this.labeltitulo.Text = "Bienvenido Usuario !!!";
			this.labeltitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// buttonSaludar
			// 
			this.buttonSaludar.BackColor = System.Drawing.Color.Transparent;
			this.buttonSaludar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSaludar.BackgroundImage")));
			this.buttonSaludar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonSaludar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonSaludar.FlatAppearance.BorderSize = 0;
			this.buttonSaludar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.buttonSaludar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSaludar.Location = new System.Drawing.Point(524, 264);
			this.buttonSaludar.Name = "buttonSaludar";
			this.buttonSaludar.Size = new System.Drawing.Size(97, 91);
			this.buttonSaludar.TabIndex = 1;
			this.buttonSaludar.UseVisualStyleBackColor = false;
			this.buttonSaludar.Click += new System.EventHandler(this.ButtonSaludarClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(672, 412);
			this.Controls.Add(this.buttonSaludar);
			this.Controls.Add(this.labeltitulo);
			this.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.Text = "Ventana Principal";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button buttonSaludar;
		private System.Windows.Forms.Label labeltitulo;
	}
}
