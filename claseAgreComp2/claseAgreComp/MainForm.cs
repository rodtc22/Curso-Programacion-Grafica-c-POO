/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 22/7/2022
 * Time: 13:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace claseAgreComp
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private Hospital hosp;
		
		public MainForm()
		{
			InitializeComponent();	
			hosp = new Hospital();
			hosp.agregaDoctor(new Doctor());
			hosp.agregaDoctor(new Doctor());
			hosp.agregaDoctor(new Doctor());
			hosp.agregaDoctor(new Doctor());
			mostrarDatos();
		}
		
		void mostrarDatos() {
			labeldirector.Text = "Director: " + hosp.DoctorEncargado.Nombre + " - " + hosp.DoctorEncargado.Especialidad ;
			
			dataGridViewListaDoctores.Rows.Clear(); 
			for (int i = 0 ;i < hosp.NroDoctores ;i++ ) {
				string [] fila = new string [3];
				Doctor doc = hosp.Doc[i];
				fila[0] = doc.IdDoctor;
				fila[1] = doc.Nombre;
				fila[2] = doc.Especialidad;
				
				dataGridViewListaDoctores.Rows.Add(fila);
			}
		}
		
		void mostrarConsola () {
//			hosp.agregaAsegurado(new Asegurado());
//			hosp.agregaAsegurado(new Asegurado());
//			hosp.agregaAsegurado(new Asegurado());
//			
//			hosp.agregaDoctor(new Doctor());
//			hosp.agregaDoctor(new Doctor());
//			hosp.agregaDoctor(new Doctor());
////			
//			hosp.eliminaAsegurado(1); //2 -> con index 0 -> 1
//			hosp.eliminaDoctor("DOC-003"); //LO MISMO
////			
//			hosp.Doc[0].agregaCita(new CitasMedicas());
			
			
			labelConsola.Text = hosp.ToString();
		}
		public Hospital Hosp {
			get { return hosp; }
			set { hosp = value; }
		}
		
		void ButtonMostrarAseguradosClick(object sender, EventArgs e)
		{
			VentanaListaAsegurados ven = new VentanaListaAsegurados(hosp);
			this.Visible = false;
			ven.ShowDialog();
			this.Visible = true;
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		
		void DataGridViewListaDoctoresCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if ( e.ColumnIndex == 3 ) {
				
				string idDoc = dataGridViewListaDoctores.Rows[e.RowIndex].Cells[0].Value.ToString();
				
				VentanaDoctor ven = new VentanaDoctor(idDoc, hosp);
				ven.ShowDialog();
				
				hosp = ven.ho;	
				
			}
		}
		
		void ButtonAgregarDoctorClick(object sender, EventArgs e)
		{
			VentanaAgregarDoctor ven = new VentanaAgregarDoctor (hosp);
			this.Visible = false;
			ven.ShowDialog();
			hosp = ven.ho;
			mostrarDatos();
			this.Visible = true;
		}
		
		
		
		void ButtonAgregarAseguradosClick(object sender, EventArgs e)
		{
			VentanaAgregarAsegurado ven = new VentanaAgregarAsegurado(hosp);
			this.Visible = false;
			ven.ShowDialog();
			hosp = ven.ho;
			this.Visible = true;
		}
		
		void ButtonMostrarEspecialidadClick(object sender, EventArgs e)
		{
			
			dataGridViewListaDoctores.Rows.Clear();
			
			string id = "ASE-0002";
			for (int i = 0 ;i < hosp.NroDoctores ; i++) {
				Doctor doc = hosp.Doc[i];
				if (doc.atiende(id)) {
					string [] fila = new string [3];
					fila[0] = doc.IdDoctor;
					fila[1] = doc.Nombre;
					fila[2] = doc.Especialidad;
					
					dataGridViewListaDoctores.Rows.Add(fila);
				}
			}
		}
		
		void ButtonFiltrarClick(object sender, EventArgs e)
		{
			if (textBoxEspecialidad.Text.Length == 0) {
//				MessageBox.Show("Tienes que escribir una especialidad, para usar esta funcion");
				mostrarDatos();
			} else {
				string esp = textBoxEspecialidad.Text;
				
				dataGridViewListaDoctores.Rows.Clear();
				for (int i = 0 ;i < hosp.NroDoctores ;i++ ) {
					string [] fila = new string [3];
					Doctor doc = hosp.Doc[i];
					fila[0] = doc.IdDoctor;
					fila[1] = doc.Nombre;
					fila[2] = doc.Especialidad;
					
					if (doc.Especialidad == esp) //aqui se modifica el filtrado
						dataGridViewListaDoctores.Rows.Add(fila);
				}
			}
		}
		
		void ButtonEliminarDoctorClick(object sender, EventArgs e)
		{
			if (dataGridViewListaDoctores.SelectedRows.Count == 1) {
				int fila = dataGridViewListaDoctores.CurrentRow.Index;
				string id = dataGridViewListaDoctores.Rows[fila].Cells[0].Value.ToString();
				
				hosp.eliminaDoctor(id);
				mostrarDatos();
			}
		}
	}
}
