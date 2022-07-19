/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 14/7/2022
 * Time: 19:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace claseHerencia
{
	/// <summary>
	/// Description of VentanaAgregarPeriodista.
	/// </summary>
	public partial class VentanaAgregarPeriodista : Form
	{
		private AsociacionPeriodistas asoci;
		
		public VentanaAgregarPeriodista(AsociacionPeriodistas a){
		
			InitializeComponent();
			asoci = a;
		}
		
		void RadioButtonConductorCheckedChanged(object sender, EventArgs e)
		{
			if (radioButtonConductor.Checked) {
				panelConductor.Visible = true;
				panelEscritor.Visible = false;
			} else {
				panelConductor.Visible = false;
				panelEscritor.Visible = true;
			}
		}
		
		void RadioButtonEscritorCheckedChanged(object sender, EventArgs e)
		{
			if (radioButtonEscritor.Checked) {
				panelEscritor.Visible = true;
				panelConductor.Visible = false;
			} else {
				panelEscritor.Visible = false;
				panelConductor.Visible = true;
			}
		}
		
		void ButtonAgregarClick(object sender, EventArgs e)
		{
			if (radioButtonConductor.Checked) {
				ConductorTV con = rescatarDatosConductor();
				asoci.agregaConductor(con);
			}
			
			if (radioButtonEscritor.Checked) {
				Escritor esc = rescatarDatosEscritor();
				asoci.agregaEscritor(esc);
			}
//			label12.Text = asoci.ToString();
		}
		
		ConductorTV rescatarDatosConductor() {
			ConductorTV aux = new ConductorTV();
			
			aux.Nombre = textBoxNombre.Text;
			aux.Fechanac = textBoxFechaNac.Text;
			aux.Ci = int.Parse(textBoxCi.Text);
			aux.IdPeriodista = int.Parse(textBoxId.Text);
			if (comboBoxEmpleado.Text == "Si") {
				aux.Empleado = true;
			} else {
				aux.Empleado = false;
			}
			aux.Sueldo = double.Parse(textBoxSueldo.Text);
			
			aux.Casatelevisiva = textBoxCasa.Text;
			aux.Programa = textBoxPrograma.Text;
			
			return aux;
		}
		
		Escritor rescatarDatosEscritor () {
			Escritor aux = new Escritor();
			
			aux.Nombre = textBoxNombre.Text;
			aux.Fechanac = textBoxFechaNac.Text;
			aux.Ci = int.Parse(textBoxCi.Text);
			aux.IdPeriodista = int.Parse(textBoxId.Text);
			if (comboBoxEmpleado.Text == "Si") {
				aux.Empleado = true;
			} else {
				aux.Empleado = false;
			}
			aux.Sueldo = double.Parse(textBoxSueldo.Text);
			
			aux.NombrePeriodico = textBoxPeriodico.Text;
			aux.Sector = textBoxSector.Text;
			
			return aux;
		}
		
		public AsociacionPeriodistas Asoci {
			get { return asoci; }
			set { asoci = value; }
		}
	}
}
