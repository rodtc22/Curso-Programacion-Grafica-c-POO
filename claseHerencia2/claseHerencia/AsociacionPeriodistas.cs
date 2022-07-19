/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 14/7/2022
 * Time: 10:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace claseHerencia
{
	/// <summary>
	/// Description of AsociacionPeriodistas.
	/// </summary>
	public class AsociacionPeriodistas
	{
		private string fechafundacion;
		private int nroConductores;
		private string [,] conductor = new string[100,8];
		private int nroEscritores;
		private string [,] escritor = new string[100,8];
		
		public AsociacionPeriodistas()
		{
			fechafundacion = "06/08/00";
			
			nroConductores = 1;
			conductor[0,0] = "rodrigo";
			conductor[0,1] = "06/09/99";
			conductor[0,2] = "123456";
			conductor[0,3] = "1";
			conductor[0,4] = "si"; //o desempleado = no
			conductor[0,5] = "1234.56";
			conductor[0,6] = "unitel";
			conductor[0,7] = "la revista";
			
			nroEscritores = 0;
		}
		
		public override string ToString()
		{
			string s =  string.Format("[AsociacionPeriodistas Fechafundacion={0}, NroConductores={1}]\n\r\n", fechafundacion, nroConductores);
			for (int i = 0 ;i < nroConductores ;i++) {
				s += "ConductorTV: " + (i+1);
				for (int j = 0 ;j < 8 ;j ++) {
					s += " " + conductor[i,j];
				}
				s += "\n\r\n";	
			}
			
			s += "nroEscritores: " + nroEscritores + "\n\r\n";
			for (int i = 0 ;i < nroEscritores ;i++) {
				s += "Escritor: " + (i+1);
				for (int j = 0 ;j < 8 ;j ++) {
					s += " " + escritor[i,j];
				}
				s += "\n\r\n";	
			}
			return s;
		}
		
		public void agregaConductor(ConductorTV c) {
			conductor[nroConductores,0] = c.Nombre;
			conductor[nroConductores,1] = c.Fechanac;
			conductor[nroConductores,2] = c.Ci.ToString();;
			conductor[nroConductores,3] = c.IdPeriodista.ToString();
			if (c.Empleado==true) {
				conductor[nroConductores,4] = "si";
			} else {
				conductor[nroConductores,4] = "no";
			}
			conductor[nroConductores,5] = c.Sueldo.ToString();
			
			conductor[nroConductores,6] = c.Casatelevisiva;
			conductor[nroConductores,7] = c.Programa;
			
			nroConductores++;
		}
		
		public void agregaEscritor(Escritor e) {
			escritor[nroEscritores,0] = e.Nombre;
			escritor[nroEscritores,1] = e.Fechanac;
			escritor[nroEscritores,2] = e.Ci.ToString();;
			escritor[nroEscritores,3] = e.IdPeriodista.ToString();
			if (e.Empleado==true) {
				escritor[nroEscritores,4] = "si";
			} else {
				escritor[nroEscritores,4] = "no";
			}
			escritor[nroEscritores,5] = e.Sueldo.ToString();
			
			escritor[nroEscritores,6] = e.NombrePeriodico;
			escritor[nroEscritores,7] = e.Sector;
			
			nroEscritores++;
		}

		
		public string Fechafundacion {
			get { return fechafundacion; }
			set { fechafundacion = value; }
		}

		public int NroConductores {
			get { return nroConductores; }
			set { nroConductores = value; }
		}

		public string[,] Conductor {
			get { return conductor; }
			set { conductor = value; }
		}

		public int NroEscritores {
			get { return nroEscritores; }
			set { nroEscritores = value; }
		}

		public string[,] Escritor {
			get { return escritor; }
			set { escritor = value; }
		}
	}
}
