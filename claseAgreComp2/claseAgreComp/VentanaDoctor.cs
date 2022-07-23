/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 23/7/2022
 * Time: 00:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace claseAgreComp
{
	/// <summary>
	/// Description of VentanaDoctor.
	/// </summary>
	public partial class VentanaDoctor : Form
	{
		public int index;
		public Hospital ho;
		
		public VentanaDoctor(string i, Hospital h)
		{
			InitializeComponent();
			ho = h;
			index = ho.buscarDoctor(i);
			mostrarDatosDoctor();
		}
		
		void mostrarDatosDoctor () {
			
			Doctor doc = ho.Doc[index];
			
			labelDoctor.Text = string.Format("Doctor: {0} - {1}", doc.Nombre, doc.Especialidad);
			labelNroCitas.Text = doc.Nrocitas.ToString();
			
			dataGridViewListaCitas.Rows.Clear();
			for (int i= 0 ;i < doc.Nrocitas ;i++ ) {
				string [] fila = new string [4];
				CitasMedicas aux = doc.Cita[i];
				fila[0] = aux.IdAsegurado;
				fila[1] = aux.Dia;
				fila[2] = aux.Horario;
				fila[3] = aux.EsReservado.ToString();
				
				dataGridViewListaCitas.Rows.Add(fila);
			}
		}
		
		
		
		void ButtonAgregar(object sender, EventArgs e)
		{
			//fecha
			string fecha = monthCalendar1.SelectionRange.End.ToString("dd-MM-yyyy");
			
			//hora
			string hora = dateTimePicker1.Value.ToString("HH:mm");
			
			//idasegurado
			string idasegurado = textBoxIdAsegurado.Text;
			
			CitasMedicas cita = new CitasMedicas();
			cita.IdAsegurado = idasegurado;
			cita.Horario = hora;
			cita.Dia = fecha;
			cita.EsReservado = true;
			
			ho.Doc[index].agregaCita(cita);
			
			textBoxIdAsegurado.Text = "";
			
			mostrarDatosDoctor();
		}
	}
}
