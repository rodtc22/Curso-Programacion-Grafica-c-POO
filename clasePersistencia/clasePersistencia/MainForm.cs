/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 23/7/2022
 * Time: 15:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace clasePersistencia
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		ArchivoCondominio arch;
		
		public MainForm()
		{
			InitializeComponent();
			arch = new ArchivoCondominio("datos.txt");
//			arch.crearArchivo();
//			arch.agregarCondominio(new Condominio());
			
			arch.agregarInquilinoArchivo(new Inquilino());
			
			mostrarEnConsola();
		}
		
		void mostrarEnConsola () {
			Condominio con = arch.dameCondominio();
			if (con.NombreCondominio == "-1") {
				labelConsola.Text = "No hay condominio";
			} else {
				labelConsola.Text = con.ToString();	
				
			}
			
		}
	}
}
