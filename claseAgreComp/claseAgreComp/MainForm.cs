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
			mostrarConsola();
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
	}
}
