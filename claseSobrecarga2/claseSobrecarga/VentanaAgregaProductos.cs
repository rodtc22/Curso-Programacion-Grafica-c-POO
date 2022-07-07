/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 7/7/2022
 * Time: 11:35 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace claseSobrecarga
{
	/// <summary>
	/// Description of VentanaAgregaProductos.
	/// </summary>
	public partial class VentanaAgregaProductos : Form
	{
		public Pasteleria pas; 
			
		public VentanaAgregaProductos(Pasteleria p)
		{
			InitializeComponent();
			pas = p;
		}

		void ButtonAgregarClick(object sender, EventArgs e)
		{
			string nombre =	textBoxnombre.Text;
			string costo = (textBoxcosto.Text);
			string cantidad = (textBoxcantidad.Text);
			string tipo = comboBoxtipo.Text;
			
			pas.agregaProducto(nombre,costo,cantidad,tipo);
			limpiarTextbox();
			MessageBox.Show("Agregado Exitosamente!");
		}
		
		void limpiarTextbox(){
			textBoxnombre.Text = "";
			textBoxcosto.Text = "";
			textBoxcantidad.Text = "";
			comboBoxtipo.Text = "";
		}
	}
}
