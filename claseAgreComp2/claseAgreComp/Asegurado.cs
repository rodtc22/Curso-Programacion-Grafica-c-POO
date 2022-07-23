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
	/// Description of Asegurado.
	/// </summary>
	public class Asegurado
	{
		private string idAsegurado;
		private string nombre;
		private string paterno;
		private string materno;
		private string fechanac;
		
		public Asegurado()
		{
			idAsegurado = "ASE-XXXX";
			nombre = "carlos";
			paterno = "quispe";
			materno = "choque";
			fechanac = "01-02-2000";
		}
		
		public Asegurado(string nom,string pat, string mat, string fe)
		{
			idAsegurado = "ASE-XXXX";
			nombre = nom;
			paterno = pat;
			materno = mat;
			fechanac = fe;
		}
		
		public override string ToString()
		{
			string s = string.Format("[Asegurado IdAsegurado={0}, Nombre={1}, Paterno={2}, Materno={3}, Fechanac={4}]\n", idAsegurado, nombre, paterno, materno, fechanac);
			return s;
		}

		
		public string IdAsegurado {
			get { return idAsegurado; }
			set { idAsegurado = value; }
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

		public string Fechanac {
			get { return fechanac; }
			set { fechanac = value; }
		}
	}
}
