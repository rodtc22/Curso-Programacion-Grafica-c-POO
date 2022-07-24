/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 24/7/2022
 * Time: 00:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace clasePersistencia
{
	/// <summary>
	/// Description of VentanaContrato.
	/// </summary>
	public partial class VentanaContrato : Form
	{
		private int index;
		ArchivoCondominio arc;
		
		public VentanaContrato( string idInq, string r)
		{
			InitializeComponent();
			
			arc = new ArchivoCondominio (r);
			index = arc.buscarInquilinoArchivo(idInq);
			
			mostrarDatosContrato();
		}
		
		void mostrarDatosContrato() {
			Inquilino inq = arc.buscarInquilinoArchivo(index);
			labelContrato.Text += inq.Nombre + " " + inq.Paterno + " "+ inq.Materno;
			
			labelIdDepartamento.Text = inq.Contrato.IdDepartamento;
			labelInicioContrato.Text = inq.Contrato.Fechainicio;
			labelFinContrato.Text = inq.Contrato.Fechafin;
			
			labelImagen.ImageIndex = arc.dimeTipoDepartamentoArchivo (inq.Contrato.IdDepartamento);
		}
		
		
		void LabelContratoClick(object sender, EventArgs e)
		{
			
		}
		
		void VentanaContratoLoad(object sender, EventArgs e)
		{
			
		}
	}
}
