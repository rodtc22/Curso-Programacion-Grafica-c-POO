/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 22/7/2022
 * Time: 13:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace claseAgreComp
{
	/// <summary>
	/// Description of Doctor.
	/// </summary>
	public class Doctor
	{
		private string idDoctor;
		private string nombre;
		private string especialidad;
		private int nrocitas;
		private CitasMedicas [] cita = new CitasMedicas[100];
		
		public Doctor()
		{
			idDoctor = "DOC-XXX";
			nombre = "Maria";
			especialidad = "Oftalmolgia";
			nrocitas = 0;
		}
		
		public Doctor(string id, string nom, string esp)
		{
			IdDoctor = id;
			nombre = nom;
			especialidad =  esp;
			nrocitas = 0;
		}
		
		public bool atiende(string id) {
			bool sw = false;
			for (int i = 0 ;i < nrocitas ;i++ ){
				if (cita[i].IdAsegurado == id) {
					sw = true;
				}
			}
			return sw;
		}
		
		public void agregaCita (CitasMedicas c) {
			cita[nrocitas] = c;
			nrocitas++;
		}
		
		public void eliminarCita (int index) {
			for (int i = index ;i < nrocitas-1 ;i++) 
				cita[i] = cita[i+1];
			nrocitas--;
		}
		
		public override string ToString()
		{
			string s =  string.Format("[Doctor IdDoctor={0}, Nombre={1}, Especialidad={2}, Nrocitas={3}]\n", idDoctor, nombre, especialidad, nrocitas);
			for (int i = 0 ;i < nrocitas ;i++) {
				s += cita[i].ToString();
				s += "\n";
			}
			return s;
		}

		
		public string IdDoctor {
			get { return idDoctor; }
			set { idDoctor = value; }
		}

		public string Nombre {
			get { return nombre; }
			set { nombre = value; }
		}

		public string Especialidad {
			get { return especialidad; }
			set { especialidad = value; }
		}

		public int Nrocitas {
			get { return nrocitas; }
			set { nrocitas = value; }
		}

		public CitasMedicas[] Cita {
			get { return cita; }
			set { cita = value; }
		}
		
		
	}
}
