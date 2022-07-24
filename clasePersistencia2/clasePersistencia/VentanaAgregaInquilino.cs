/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 24/7/2022
 * Time: 01:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace clasePersistencia
{
	/// <summary>
	/// Description of VentanaAgregaInquilino.
	/// </summary>
	public partial class VentanaAgregaInquilino : Form
	{
		
		private ArchivoCondominio arc;
		private string iddep;
		
		public VentanaAgregaInquilino(string id, ArchivoCondominio ar)
		{
			InitializeComponent();
			arc = ar;	
			iddep =id;
			
			labelImagen.ImageIndex = arc.dimeTipoDepartamentoArchivo (iddep);
		}
		
		
		
		void ButtonOKClick(object sender, EventArgs e)
		{
			string nomi = textBoxNombre.Text;
			string pati = textBoxPaterno.Text;
			string mati = textBoxMaterno.Text;
			int cii = int.Parse(textBoxCarnet.Text);
			string naci = monthCalendarNacimiento.SelectionRange.End.ToString("dd-MM-yyyy");
			string ini = dateTimePickerInicio.Value.ToString("dd-MM-yyyy");
			string fin = dateTimePickerfinal.Value.ToString("dd-MM-yyyy");
			
			Inquilino inq = new Inquilino (nomi,pati,mati,cii,naci);
			inq.Contrato = new ContratoAlquiler (iddep,ini,fin);
			
			arc.agregarInquilinoArchivo (inq);
			
			this.Close();
		}
		
		public ArchivoCondominio Arc {
			get { return arc; }
			set { arc = value; }
		}

		public string Iddep {
			get { return iddep; }
			set { iddep = value; }
		}
		
		
	}
}
