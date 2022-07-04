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
			this.labelconsola = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// labelconsola
			// 
			this.labelconsola.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.labelconsola.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelconsola.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.labelconsola.Location = new System.Drawing.Point(86, 19);
			this.labelconsola.Name = "labelconsola";
			this.labelconsola.Size = new System.Drawing.Size(538, 304);
			this.labelconsola.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(656, 332);
			this.Controls.Add(this.labelconsola);
			this.Name = "MainForm";
			this.Text = "clasePOO";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label labelconsola;
	}
}
