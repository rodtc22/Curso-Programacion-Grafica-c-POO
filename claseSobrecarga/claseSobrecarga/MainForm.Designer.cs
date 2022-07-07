/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 7/7/2022
 * Time: 9:08 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace claseSobrecarga
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
			this.labelConsola = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// labelConsola
			// 
			this.labelConsola.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.labelConsola.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelConsola.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelConsola.ForeColor = System.Drawing.SystemColors.Control;
			this.labelConsola.Location = new System.Drawing.Point(0, 0);
			this.labelConsola.Name = "labelConsola";
			this.labelConsola.Size = new System.Drawing.Size(705, 307);
			this.labelConsola.TabIndex = 0;
			this.labelConsola.Text = "label1";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(705, 307);
			this.Controls.Add(this.labelConsola);
			this.Name = "MainForm";
			this.Text = "claseSobrecarga";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label labelConsola;
	}
}
