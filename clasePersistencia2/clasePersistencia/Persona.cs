/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 23/7/2022
 * Time: 17:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO; //no olvidar esto

namespace clasePersistencia
{
	
	public class Persona
	{
		protected string nombre,paterno,materno; //importante protected 
		protected int ci;
		protected string fechanac;
		
		public Persona() {
			nombre = "Rodrigo";
			paterno = "Ticona";
			materno = "Coronel";
			ci = 123456;
			fechanac = "06-09-1999";
		}
		
		public Persona (string nom, string pat, string mat, int c, string fe) {
			nombre = nom;
			paterno = pat;
			materno = mat;
			ci = c;
			fechanac = fe;
		}
		
		public override string ToString()
		{
			string s = string.Format("[Persona Nombre={0}, Paterno={1}, Materno={2}, Ci={3}, Fechanac={4}]\n", nombre, paterno, materno, ci, fechanac);
			return s;
		}
		
		public void escrituraPersona (BinaryWriter escritor) {
			escritor.Write(nombre);
			escritor.Write(paterno);
			escritor.Write(materno);
			escritor.Write(ci);
			escritor.Write(fechanac);
		}
		
		public void lecturaPersona (BinaryReader lector) {
			nombre = lector.ReadString();
			paterno = lector.ReadString();
			materno = lector.ReadString();
			ci = lector.ReadInt32();
			fechanac = lector.ReadString();
		}
		
		public string Nombre {
			get { return nombre; }
			set { nombre = value; }
		}

		public string Paterno {
			get { return paterno; }
			set { paterno = value; }
		}

		public string Materno {
			get { return materno; }
			set { materno = value; }
		}

		public int Ci {
			get { return ci; }
			set { ci = value; }
		}

		public string Fechanac {
			get { return fechanac; }
			set { fechanac = value; }
		}

	}
}
