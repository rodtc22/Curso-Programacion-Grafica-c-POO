/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 23/7/2022
 * Time: 23:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace clasePersistencia
{
	/// <summary>
	/// Description of VentanaInquilino.
	/// </summary>
	public partial class VentanaInquilino : Form
	{
		private string ru;
		
		public VentanaInquilino(string r)
		{
			InitializeComponent();
			ru = r;
			mostrarInquilinosData();
		}
		
		void mostrarInquilinosData() {
			ArchivoCondominio arch = new ArchivoCondominio(ru);
			Condominio con = arch.dameCondominio();
			
			dataGridViewInquilinos.Rows.Clear();
			for (int i = 0 ;i < con.NroInqu; i++ ) {
				Inquilino inq = con.Inqu[i];
				
				string [] fila = {inq.IdInquilino,inq.Nombre,inq.Paterno,inq.Materno,inq.Ci.ToString(),inq.Fechanac};
				dataGridViewInquilinos.Rows.Add(fila);
			}
		}
		
		
		
		void DataGridViewInquilinosCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if ( e.ColumnIndex == 6) {
				int nrofila  = e.RowIndex;
				string id = dataGridViewInquilinos.Rows[nrofila].Cells[0].Value.ToString();
				
				VentanaContrato ven = new VentanaContrato (id,ru);
				ven.ShowDialog();
			}
		}
		
		
		public string Ru {
			get { return ru; }
			set { ru = value; }
		}
		
		void ButtonEliminaInquilinoClick(object sender, EventArgs e)
		{
			int fila = dataGridViewInquilinos.CurrentRow.Index;
			string id = dataGridViewInquilinos.Rows[fila].Cells[0].Value.ToString();
			
			ArchivoCondominio arch = new ArchivoCondominio(ru);
			arch.eliminaInquilinoArchivo(id);
			
			mostrarInquilinosData();
		}
	}
}
