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
			mostrarDatosCondominio();
			
//			arch.crearArchivo();
//			arch.agregarCondominio(new Condominio());
			
//			arch.agregarInquilinoArchivo(new Inquilino());
			
//			mostrarEnConsola();
		}
		
		void mostrarDatosCondominio () {
			labelFecha.Text = DateTime.Now.ToString();
			
			Condominio con = arch.dameCondominio();
			labelnombreDuenio.Text = con.Duenio.Nombre + " " +con.Duenio.Paterno + " " +con.Duenio.Materno ;
			labelnacimiento.Text += " "+ con.Duenio.Fechanac;
			
			labelNombreCondominio.Text = con.NombreCondominio;
			labeldireccion.Text += " "+ con.Direccion;
			labelTelefono.Text += " "+ con.Telefono.ToString();
		}
		
		void mostrarEnConsola () {
			Condominio con = arch.dameCondominio();
			if (con.NombreCondominio == "-1") {
				labelConsola.Text = "No hay condominio";
			} else {
				labelConsola.Text = con.ToString();	
				
			}
			
		}
		
		void ButtonCascadaClick(object sender, EventArgs e)
		{
			if (panelCascada.Visible == true) {
				panelCascada.Visible = false;
			} else {
				panelCascada.Visible = true;
			}
		}
		
		void ButtonInquilinosClick(object sender, EventArgs e)
		{
			VentanaInquilino ven = new VentanaInquilino (arch.Ruta);
			ven.ShowDialog();
			
		}
		
		void ButtonDepartamentosClick(object sender, EventArgs e)
		{
			VentanaDepartamento ven = new VentanaDepartamento(arch);
			ven.ShowDialog();
		}
		
		void ButtonAgregaDeptoClick(object sender, EventArgs e)
		{
			VentanaAgregaDepartamento ven = new VentanaAgregaDepartamento(arch);
			ven.ShowDialog();
		}
	}
}
