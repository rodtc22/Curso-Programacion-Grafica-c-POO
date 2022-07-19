/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 14/7/2022
 * Time: 10:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace claseHerencia
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private AsociacionPeriodistas asoc;
		
		public MainForm()
		{

			InitializeComponent();
			asoc = new AsociacionPeriodistas();
			labelFechaFundacion.Text = "Fecha de fundacion: " + asoc.Fechafundacion;
		}
		
		
		
		
		void ButtonOcultarPanelIzqClick(object sender, EventArgs e)
		{
			bool ocultado = splitContainer1.Panel1Collapsed;
			
			if (! ocultado) {
				splitContainer1.Panel1Collapsed = true; 
			} else {
				splitContainer1.Panel1Collapsed = false; 
			}
		}
		
		void ButtonMostrarConductoresClick(object sender, EventArgs e)
		{
			mostrarConductores();
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
		void ButtonAgregarPeriodistaClick(object sender, EventArgs e)
		{
			VentanaAgregarPeriodista ven = new VentanaAgregarPeriodista(asoc);
			ven.ShowDialog();
			asoc = ven.Asoci;
			mostrarConductores();
		}
		
		void mostrarConductores() {
			
			string [,] copia = new string[100,8];
			
			label1.Text = "Nombre\n";
			label2.Text = "Fecha Nac\n";
			label3.Text = "Carnet\n";
			label4.Text = "ID\n";
			label5.Text = "Empleado\n";
			label6.Text = "Sueldo\n";
			label7.Text = "CasaTelevisiva\n";
			label8.Text = "Programa\n";
			
			for (int i = 0 ;i < asoc.NroConductores ;i++ ) {
//				int id = int.Parse(asoc.Conductor[i,3]);   para algun criterio antes de mostrar
				
				label1.Text += asoc.Conductor[i,0] + "\n";
				label2.Text += asoc.Conductor[i,1] + "\n";
				label3.Text += asoc.Conductor[i,2] + "\n";
				label4.Text += asoc.Conductor[i,3] + "\n";
				label5.Text += asoc.Conductor[i,4] + "\n";
				label6.Text += asoc.Conductor[i,5] + "\n";
				label7.Text += asoc.Conductor[i,6] + "\n";
				label8.Text += asoc.Conductor[i,7] + "\n";
				
				
			}
		}
		
		void ButtonBuscarPeriodistaClick(object sender, EventArgs e)
		{
			VentanaBuscar ven = new VentanaBuscar(asoc);
			ven.ShowDialog();
			
		}
	}
}
