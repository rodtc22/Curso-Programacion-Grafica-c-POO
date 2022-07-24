/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 24/7/2022
 * Time: 00:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace clasePersistencia
{
	/// <summary>
	/// Description of VentanaDepartamento.
	/// </summary>
	public partial class VentanaDepartamento : Form
	{
		
		private ArchivoCondominio arc;
		
		public VentanaDepartamento(ArchivoCondominio ar)
		{
			
			InitializeComponent();
			arc = ar;
			mostrarDepartamentos();
		}
		
		void VentanaDepartamentoLoad(object sender, EventArgs e)
		{
			
		}
		
		void PictureBoxPanelSecretoClick(object sender, EventArgs e)
		{
			if (panelSecreto.Visible == true ) {
				panelSecreto.Visible = false;
			} else {
				panelSecreto.Visible = true;
			}
		}
		
		void mostrarDepartamentos () {
			Condominio co = arc.dameCondominio();
			
			dataGridViewDepartamentos.Rows.Clear();
			for (int i = 0 ;i < co.NroDepa ;i++) {
				Departamento dep = co.Depa[i];
				dataGridViewDepartamentos.Rows.Add(dep.IdDepartamento,dep.Costo.ToString(), dep.Superficie.ToString(),imageList1.Images[dep.Tipo] );
			}
			colorearfilas();
		}
		
		void colorearfilas() {
			Condominio con = arc.dameCondominio();
			
			for (int i = 0 ; i < con.NroDepa ;i++ ){
				bool ocupado = arc.verificaDepOcupadoArchivo(con.Depa[i].IdDepartamento);
				
				if (ocupado) {
					DataGridViewRow fila = dataGridViewDepartamentos.Rows[i];
					fila.DefaultCellStyle.BackColor = Color.Red;
				}
			}
		}
		
		void DataGridViewDepartamentosCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == 4) { //rentar el departamento
				int indexfila = e.RowIndex;
				string id = dataGridViewDepartamentos.Rows[indexfila].Cells[0].Value.ToString();
				
				bool ocupado = arc.verificaDepOcupadoArchivo(id);
				if (!ocupado) {
					//agrego inquilino
					VentanaAgregaInquilino ven = new VentanaAgregaInquilino (id,arc);
					ven.Show();	
					
					mostrarDepartamentos();
				}
			}
		}
		
		void ButtonEditarClick(object sender, EventArgs e)
		{
			
			
//			if (dataGridViewDepartamentos.ReadOnly == true) {
//				dataGridViewDepartamentos.ReadOnly = false;
//				buttonEditar.BackColor = Color.Green;
//			} else {
//				dataGridViewDepartamentos.ReadOnly = true;
//				buttonEditar.BackColor = Color.Red;
//			}
			
			mostrarDepartamentos();
		}
		
		
	}
}
