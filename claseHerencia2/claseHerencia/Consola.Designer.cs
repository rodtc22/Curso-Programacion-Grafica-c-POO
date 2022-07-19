/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 14/7/2022
 * Time: 11:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace claseHerencia
{
	partial class Consola
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
			this.textBoxConsola = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// textBoxConsola
			// 
			this.textBoxConsola.BackColor = System.Drawing.SystemColors.InfoText;
			this.textBoxConsola.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxConsola.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxConsola.ForeColor = System.Drawing.SystemColors.Info;
			this.textBoxConsola.Location = new System.Drawing.Point(0, 0);
			this.textBoxConsola.Multiline = true;
			this.textBoxConsola.Name = "textBoxConsola";
			this.textBoxConsola.ReadOnly = true;
			this.textBoxConsola.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxConsola.Size = new System.Drawing.Size(748, 379);
			this.textBoxConsola.TabIndex = 0;
			// 
			// Consola
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(748, 379);
			this.Controls.Add(this.textBoxConsola);
			this.Name = "Consola";
			this.Text = "Consola";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox textBoxConsola;
	}
}
