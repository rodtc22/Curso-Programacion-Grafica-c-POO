/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 7/7/2022
 * Time: 10:27 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace claseSobrecarga
{
	/// <summary>
	/// Description of VentanaMostrarProductos.
	/// </summary>
	public partial class VentanaMostrarProductos : Form
	{
		
		Pasteleria pas;
		
		public VentanaMostrarProductos()
		{
			InitializeComponent();
		}
		
		public void recibirPasteleria(Pasteleria p) {
			pas = p;
//			mostrarConsola();
		}
		
		public void mostrarProductos(){
			for (int i = 0 ;i < pas.Nroproductos ;i++){
				string nombre = pas.Producto[i,0];
				string costo = pas.Producto[i,1];
				string cantidad = pas.Producto[i,2];
				string tipo = pas.Producto[i,3];
				
				ponerDatosLabels(i+1,nombre,costo,cantidad,tipo);
			}
		}
		
		void ponerDatosLabels(int nro, string a, string b, string c, string d) {
			labelnro.Text += "\n" + nro.ToString();
			labelnombre.Text += "\n" + a;
			labelcosto.Text += "\n" + b;
			labeldisponible.Text += "\n" + c;
			labeltipo.Text += "\n" + d;
		}
		
		
		
		
		
		
	}
}
