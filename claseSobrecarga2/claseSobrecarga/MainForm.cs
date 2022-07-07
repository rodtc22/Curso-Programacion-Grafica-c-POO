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
			p =  new Pasteleria("irene","prado",3456);
			MainForm aux = this;
			aux --;
		}
		
		
		void llevarPasteleriaLabels() {
			labelduenio.Text = p.Duenio;
			labeltelefono.Text = p.Telefono.ToString();
			labeldireccion.Text = p.Direccion;
			labelNroProductos.Text = p.Nroproductos.ToString();
		}
		
		public static MainForm operator -- (MainForm pas) {
			pas.labelduenio.Text = pas.p.Duenio;
			pas.labeltelefono.Text = pas.p.Telefono.ToString();
			pas.labeldireccion.Text = pas.p.Direccion;
			pas.labelNroProductos.Text = pas.p.Nroproductos.ToString();
			
			
			return pas;
		}
	
		
		void mostrarConsola() {
			labelConsola.Text = p.ToString();
		}
		
		void PictureBoxproductosClick(object sender, EventArgs e)
		{
			VentanaMostrarProductos ven = new VentanaMostrarProductos();
			ven.recibirPasteleria(p);
			ven.mostrarProductos();
			ven.ShowDialog();
		}
		
		void ButtoneditardatosClick(object sender, EventArgs e)
		{
			VentanaEditarDatos ven = new VentanaEditarDatos(p);
			ven.ShowDialog();
			p = ven.Pas;
			llevarPasteleriaLabels();
		}
		
		void ButtonAgregarProductosClick(object sender, EventArgs e)
		{
			VentanaAgregaProductos ven = new VentanaAgregaProductos(p);
			ven.ShowDialog();
			p = ven.pas;
			llevarPasteleriaLabels();
			
		}
	}
}
