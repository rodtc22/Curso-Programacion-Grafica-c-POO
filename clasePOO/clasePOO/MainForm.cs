/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 7/4/2022
 * Time: 10:06 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace clasePOO
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			Estudiante est = new Estudiante(1,"mate",2,"-1","carlitos","quispe","mamani");
			labelconsola.Text = est.mostrar();
		}
	}
}
