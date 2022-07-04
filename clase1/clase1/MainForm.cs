/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 7/3/2022
 * Time: 11:31 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace clase1
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
		
		void ButtonSaludarClick(object sender, EventArgs e)
		{
			labeltitulo.Text = "Hola Rodrigo";
		}
	}
}
