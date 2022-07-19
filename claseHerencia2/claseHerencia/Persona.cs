/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 14/7/2022
 * Time: 10:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace claseHerencia
{
	/// <summary>
	/// Description of Persona.
	/// </summary>
	public class Persona
	{
		private string nombre;
		private string fechanac;
		private int ci;
		
		public Persona ()
		{
			nombre = "rodrigo ticona";
			fechanac = "06/09/99";
			ci = 123456;
		}
		
		public Persona (string n,string f, int c) {
			nombre = n;
			fechanac = f;
			ci = c;
		}
		
		
		public override string ToString()
		{
			return string.Format("[Persona Nombre={0}, Fechanac={1}, Ci={2}]\n\r\n", nombre, fechanac, ci);
		}

		
		public string Nombre {
			get { return nombre; }
			set { nombre = value; }
		}

		public string Fechanac {
			get { return fechanac; }
			set { fechanac = value; }
		}

		public int Ci {
			get { return ci; }
			set { ci = value; }
		}
	}
}
