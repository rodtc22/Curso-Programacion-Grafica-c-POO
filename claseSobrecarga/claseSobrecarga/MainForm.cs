/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 7/7/2022
 * Time: 9:08 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace claseSobrecarga
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		Pasteleria p;
		
		public MainForm()
		{
			InitializeComponent();
			p =  new Pasteleria();
			mostrarConsola();
		}
	
		
		void mostrarConsola() {
			labelConsola.Text = p.mostrar();
		}
	}
}
