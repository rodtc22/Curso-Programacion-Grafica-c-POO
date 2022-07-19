/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 14/7/2022
 * Time: 20:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace claseHerencia
{
	/// <summary>
	/// Description of VentanaBuscar.
	/// </summary>
	public partial class VentanaBuscar : Form
	{
		private AsociacionPeriodistas asoci;
		public VentanaBuscar(AsociacionPeriodistas a)
		{
			
			InitializeComponent();
			asoci = a;
		
		}
		
		void ButtonBuscarClick(object sender, EventArgs e)
		{
			bool encontrado = false;
			string nom = textBoxNombre.Text;
			
			for (int i = 0 ;i < asoci.NroConductores && !encontrado ;i++) {
				if (asoci.Conductor[i,0] == nom) {
					MessageBox.Show(nom + " Ha sido encontrado");
					encontrado = true;
				}
			}
			
			for (int i = 0 ;i < asoci.NroEscritores && !encontrado ;i++) {
				if (asoci.Escritor[i,0] == nom) {
					MessageBox.Show(nom + " Ha sido encontrado");
					encontrado = true;
				}
			}
			
			if (!encontrado) {
				MessageBox.Show("No existe tal periodista");
			}
		}
	}
}
