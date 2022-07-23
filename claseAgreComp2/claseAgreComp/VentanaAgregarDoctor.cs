/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 23/7/2022
 * Time: 00:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace claseAgreComp
{
	/// <summary>
	/// Description of VentanaAgregarDoctor.
	/// </summary>
	public partial class VentanaAgregarDoctor : Form
	{
		public Hospital ho;
		
		public VentanaAgregarDoctor(Hospital h)
		{
			InitializeComponent();	
			ho = h;
		}
		
		
		
		void ButtonokClick(object sender, EventArgs e)
		{
			string nombre = textBoxNombre.Text;
			string espe = textBoxEspecialidad.Text;
			
			Doctor doc = new Doctor();
			doc.Nombre = nombre;
			doc.Especialidad = espe;
			
			ho.agregaDoctor(doc);
			
			limpiar();
		}
		
		void limpiar() {
			textBoxNombre.Text = "";
			textBoxEspecialidad.Text = "";
		}
	}
}
