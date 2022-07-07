/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 7/7/2022
 * Time: 11:11 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace claseSobrecarga
{
	/// <summary>
	/// Description of VentanaEditarDatos.
	/// </summary>
	public partial class VentanaEditarDatos : Form
	{
		private Pasteleria pas;
		
		public VentanaEditarDatos(Pasteleria p)
		{
			InitializeComponent();
			pas = p;
			mostrarConsola();
		}
		
		void mostrarConsola() {
			labelConsola.Text = pas.ToString();
		}
		
		
		void ButtonGuardarCambiosClick(object sender, EventArgs e)
		{
			pas.Duenio = textBoxduenio.Text;
			pas.Direccion = textBoxdireccion.Text;
			pas.Telefono = int.Parse(textBoxtelefono.Text);
			
			this.Close();
		}
		
		public Pasteleria Pas {
			get { return pas; }
			set { pas = value; }
		}
	}
}
