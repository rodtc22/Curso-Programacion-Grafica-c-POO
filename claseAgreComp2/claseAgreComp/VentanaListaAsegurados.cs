/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 22/7/2022
 * Time: 23:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace claseAgreComp
{
	/// <summary>
	/// Description of VentanaListaAsegurados.
	/// </summary>
	public partial class VentanaListaAsegurados : Form
	{
		private Hospital ho;
		public VentanaListaAsegurados(Hospital h)
		{
			
			InitializeComponent();
			ho = h;
			mostrarDatosDataGridView();
		}
		
		void mostrarDatosDataGridView() {
			for (int i = 0 ;i < ho.NroAsegurados ;i++) {
				
				string [] fila = new string[5];
				fila[0] = ho.Aseg[i].IdAsegurado;
				fila[1] = ho.Aseg[i].Nombre;
				fila[2] = ho.Aseg[i].Paterno;
				fila[3] = ho.Aseg[i].Materno;
				fila[4] = ho.Aseg[i].Fechanac;
				
				dataGridViewListaAsegurados.Rows.Add(fila);
			}
		}
		
	}
}
