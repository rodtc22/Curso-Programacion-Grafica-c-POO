/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 23/7/2022
 * Time: 01:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace claseAgreComp
{
	/// <summary>
	/// Description of VentanaAgregarAsegurado.
	/// </summary>
	public partial class VentanaAgregarAsegurado : Form
	{
		public Hospital ho;
		
		public VentanaAgregarAsegurado(Hospital p)
		{
			
			InitializeComponent();
			ho = p;
		}
		
		
		
		void ButtonokClick(object sender, EventArgs e)
		{
			Asegurado a = rescatar();
			settearDatos();
			ho.agregaAsegurado(a);
		}
		
		Asegurado rescatar () {
			string nom = textBoxNombre.Text;
			string pat = textBoxPaterno.Text;
			string mat = textBoxMaterno.Text;
			string nac = dateTimePickerFechaNacimiento.Value.ToString("dd-MM-yyyy");
			return new Asegurado(nom,pat,mat,nac);
		}
		
		void settearDatos () {
			textBoxNombre.Text = "";	
			textBoxPaterno.Text = "";	
			textBoxMaterno.Text = "";	
		}
	}
}
