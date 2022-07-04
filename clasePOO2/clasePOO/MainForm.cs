/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 7/4/2022
 * Time: 10:06 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace clasePOO
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		public Estudiante est;
		public bool ok;
		
		public MainForm()
		{
			InitializeComponent();
			est = new Estudiante();
			ok = false;
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}	
		
		void ButtonGuardarClick(object sender, EventArgs e)
		{
			est = rescatarDatosTextBox();
			mostrarEstudianteConsola();
			ok = true;
		}
		
		void mostrarEstudianteConsola() {
			labelconsola.Text = est.mostrar();
		}
		
		Estudiante rescatarDatosTextBox () {
			
			Estudiante aux = new Estudiante();
			aux.IdEstudiante = int.Parse(textBoxidEstudiante.Text);
			aux.Carrera = textBoxCarrera.Text;
			aux.Ci = int.Parse(textBoxCi.Text);
			aux.Fechanac = textBoxFechaNac.Text;
			aux.Nombre = textBoxNombre.Text;
			aux.Paterno = textBoxPaterno.Text;
			aux.Materno = textBoxMaterno.Text;
			
			return aux;
		}
		
		void ButtonNombrePalindromeClick(object sender, EventArgs e)
		{
			if (ok) {
				string s = est.Nombre;
				
				string t = "";
				for (int i = 0 ; i < s.Length ;i++) {
					t = s[i] + t;
				}
				
				if (s == t) {
//					labelconsola.Text += "espalindrome \n";
					MessageBox.Show("Es palindrome", "Verificacion Palindrome", MessageBoxButtons.OK, MessageBoxIcon.Information);
				} else {
//					labelconsola.Text += "NO espalindrome \n";
					MessageBox.Show("No Es palindrome", "Verificacion Palindrome", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
		}
		
		int ToDias (string f) {
			int dias = int.Parse(f.Substring(0,2));
			int meses = int.Parse(f.Substring(3,2));
			int anios = int.Parse(f.Substring(6,4));
			
			dias = dias + meses * 30 + anios * 365;
			return dias;
		}
		
		void ButtonMayorEdadClick(object sender, EventArgs e)
		{
			if (ok) {
				// 05/09/2017  -> 2000
				// 06/09/1999  -> 1635  365/365
				
				int fechaAhora = ToDias("06/09/2017");
				int fechaNac = ToDias(est.Fechanac);
				
				int dias = fechaAhora - fechaNac;
				int anios = dias / 365;
				if (anios >= 18) {
					MessageBox.Show("Si es Mayor de Edad", "Verificacion Edad", MessageBoxButtons.OK, MessageBoxIcon.Information);
				} else {
					MessageBox.Show("Es Menor de Edad", "Verificacion Edad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
		}
		
		void ButtonGenerarNomUsuarioClick(object sender, EventArgs e)
		{
			if (ok) {
				// Rodrigo Ticona Coronel id=123 ci=456 anio=1999
				// RTC369
				
				string s = "";
				s += est.Nombre[0];
				s += est.Paterno[0];
				s += est.Materno[0];
				
				s += est.IdEstudiante % 10;
				s += est.Ci % 10;
				
				int tam = est.Fechanac.Length;
				s += est.Fechanac[tam-1];
				
				MessageBox.Show("Nombre Usuario: " + s, "Obtener nombre de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
				
			}
		}
	}
}
