/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 24/7/2022
 * Time: 02:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace clasePersistencia
{
	/// <summary>
	/// Description of VentanaAgregaDepartamento.
	/// </summary>
	public partial class VentanaAgregaDepartamento : Form
	{
		ArchivoCondominio arc;
		public VentanaAgregaDepartamento(ArchivoCondominio a)
		{
			InitializeComponent();
			arc = a;
		}
		
		void ButtonSigClick(object sender, EventArgs e)
		{
			int len = imageList1.Images.Count;
			int pos = labelImagen.ImageIndex;
			pos = (pos + 1 ) % len;
			labelImagen.ImageIndex = pos;
		}
		
		void ButtonAntClick(object sender, EventArgs e)
		{
			int len = imageList1.Images.Count;
			int pos = labelImagen.ImageIndex;
			pos = (pos - 1 + len) % len;
			labelImagen.ImageIndex = pos;
		}
		
		void ButtonOKClick(object sender, EventArgs e)
		{
			double costo =  double.Parse(textBoxCosto.Text);
			int superficie = int.Parse(textBoxSuperficie.Text);
			int tipo = labelImagen.ImageIndex;
			
			Departamento dep = new Departamento(costo,superficie,tipo);
			arc.agregarDepartamentoArchivo(dep);
			
			this.Close();
		}
	}
}
